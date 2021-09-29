using System;
using DiscordRPC;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsDiscordRPC {
    public partial class DiscordRPCForm : Form {
        public int Now = 0;
        public bool started = false;
        public DiscordRpcClient client = null;
        public int WindowsVersion = RPCDetails.GetCurrentOS();
        public Dictionary<int, string> ClientID = new Dictionary<int, string> {
            { 7, "883030956573855744" },
            { 8, "888027859707396096" },
            { 10, "888028337413431316" },
            { 11, "888028546629509181" }
        };

        public DiscordRPCForm() {
            InitializeComponent();
        }

        private void DiscordRPCForm_Load(object sender, EventArgs e) {
            switch (WindowsVersion) {
                case 7:
                    WindowsVersionExample.Text += '7';
                    LargeImage.Image = WindowsDiscordRPC.Properties.Resources.win7;
                    break;
                case 8:
                    WindowsVersionExample.Text += '8';
                    LargeImage.Image = WindowsDiscordRPC.Properties.Resources.win8;
                    break;
                case 10:
                    WindowsVersionExample.Text += "10";
                    LargeImage.Image = WindowsDiscordRPC.Properties.Resources.win10;
                    break;
                case 11:
                    WindowsVersionExample.Text += "11";
                    LargeImage.Image = WindowsDiscordRPC.Properties.Resources.win11;
                    break;
            }
        }

        private void Start_Click(object sender, EventArgs e) {
            StartRPC();
            this.Start.Visible = false;
        }

        private void Stop_Click(object sender, EventArgs e) {
            EndRPC();
            this.Stop.Visible = false;
        }

        private void Show_Click(object sender, EventArgs e) {
            this.Show();
            HideNotification.Visible = false;
        }

        private void Leave_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DiscordRPCForm_FormClosing(object sender, FormClosingEventArgs e) {
            started = false;
            if (client != null) client.Dispose();
        }

        private void HideButton_Click(object sender, EventArgs e) {
            this.Hide();
            HideNotification.Visible = true;
            HideNotification.ShowBalloonTip(3000);
        }

        private void HideNotification_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (started) this.Stop.Visible = true;
                else this.Start.Visible = true;
                HideNotificationMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            } else {
                this.Show();
                HideNotification.Visible = false;
            }
        }

        private void HideNotification_BalloonTipClicked(object sender, EventArgs e) {
            this.Show();
            HideNotification.Visible = false;
        }

        private void ControlsButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            if (started) EndRPC();
            else StartRPC();
        }

        private void EndRPC() {
            started = false;
            this.Stop.Visible = false;
            if (client != null) client.Dispose();
            ControlsButton.Text = "Start";
            WindowsTitleExample.Text = "Windows Title";
            TimeElapsedExample.Text = "XX:XX:XX elapsed";
            ComputerUsageExample.Text = "CPU: XX% | RAM: XX%";
            this.Refresh(); this.Cursor = Cursors.Default;
        }

        private void StartRPC() {
            started = true;
            this.Start.Visible = false;
            ControlsButton.Text = "Stop";
            client = new DiscordRpcClient(ClientID[WindowsVersion]);
            client.Initialize();
            Thread UpdateElapsedTimeText = new Thread(() => {
                Now = 0;
                while (started) {
                    Now++;
                    this.Invoke(new MethodInvoker(() => TimeElapsedExample.Text = String.Format("{0} elapsed", RPCDetails.GetDateFormat(Now))));
                    Thread.Sleep(1000);
                }
            });
            Thread RPC = new Thread(() => {
                UpdateElapsedTimeText.Start();
                Timestamps StartTime = Timestamps.Now;
                this.Invoke(new MethodInvoker(() => this.Cursor = Cursors.Default));
                while (started) {
                    decimal RamUsage = RPCDetails.GetCurrentRamUsage();
                    decimal CpuUsage = RPCDetails.GetCurrentCpuUsage();
                    string WindowsTitle = RPCDetails.GetCurrentWindowTitle();
                    client.SetPresence(new RichPresence() {
                        Details = (WindowsTitle.Length < 4) ? (WindowsTitle + (char)8203) : WindowsTitle,
                        State = String.Format("CPU: {0}% | RAM: {1}%", CpuUsage, RamUsage),
                        Timestamps = StartTime,
                        Assets = new Assets() {
                            LargeImageKey = "largeimage",
                            LargeImageText = String.Format("Windows {0}", WindowsVersion.ToString())
                        }
                    });
                    this.Invoke(new MethodInvoker(() => WindowsTitleExample.Text = WindowsTitle));
                    this.Invoke(new MethodInvoker(() => ComputerUsageExample.Text = String.Format("CPU: {0}% | RAM: {1}%", CpuUsage, RamUsage)));
                    this.Invoke(new MethodInvoker(() => this.Refresh()));
                    Thread.Sleep(3000);
                }
            });
            client.OnReady += (OnReadySender, OnReadyError) => RPC.Start();
        }
    }
}
