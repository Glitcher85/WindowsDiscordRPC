using System;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;

namespace WindowsDiscordRPC {
    public static class RPCDetails {
        static PerformanceCounter RamCounter = new PerformanceCounter("Memory", "Available MBytes");
        static PerformanceCounter CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        static int TotalPhysicalMemory = Convert.ToInt32(new ComputerInfo().TotalPhysicalMemory / Math.Pow(1024, 2));

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet=CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public static decimal GetCurrentCpuUsage() {
            return Decimal.Round((decimal)CpuCounter.NextValue(), 1);
        }

        public static decimal GetCurrentRamUsage() {
            return Decimal.Round((decimal)(((TotalPhysicalMemory - RamCounter.NextValue()) / TotalPhysicalMemory) * 100), 1);
        }

        public static string GetDateFormat(int CurrentTime) {
            int hour = CurrentTime / 3600;
            int minute = CurrentTime % 3600 / 60;
            int second = CurrentTime % 3600 % 60;
            if (hour < 1) return String.Format("{0}:{1}", (minute < 10) ? '0' + minute.ToString() : minute.ToString(), (second < 10) ? '0' + second.ToString() : second.ToString());
            return String.Format("{0}:{1}:{2}", (hour < 10) ? '0' + hour.ToString() : hour.ToString(), (minute < 10) ? '0' + minute.ToString() : minute.ToString(), (second < 10) ? '0' + second.ToString() : second.ToString());
        }

        public static int GetCurrentOS() {
            char[] WindowsVersion = {};
            foreach (char letter in new ComputerInfo().OSFullName) {
                if (Char.IsDigit(letter)) {
                    if (WindowsVersion.Length > 0) {
                        if (WindowsVersion[0] != '8') {
                            List<char> WindowsVersionList = WindowsVersion.ToList();
                            WindowsVersionList.Add(letter);
                            WindowsVersion = WindowsVersionList.ToArray();
                        }
                    } else {
                        List<char> WindowsVersionList = WindowsVersion.ToList();
                        WindowsVersionList.Add(letter);
                        WindowsVersion = WindowsVersionList.ToArray();
                    }
                }
            }
            return (WindowsVersion.Length > 1) ? Int32.Parse(WindowsVersion.ToString()) : Int32.Parse(WindowsVersion[0].ToString());
        }

        public static string GetCurrentWindowTitle() {
            IntPtr handle = GetForegroundWindow();
            StringBuilder title = new StringBuilder(256);
            if (GetWindowText(handle, title, 256) > 0) {
                byte[] titleInBytes = Encoding.Unicode.GetBytes(title.ToString());
                if (titleInBytes.Length > 84) return Encoding.Unicode.GetString(titleInBytes.Take(84).ToArray());
                else return title.ToString();
            }
            return "Windows Desktop";
        }
    }
}