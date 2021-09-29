
namespace WindowsDiscordRPC
{
    partial class DiscordRPCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordRPCForm));
            this.LargeImage = new System.Windows.Forms.PictureBox();
            this.WindowsVersionExample = new System.Windows.Forms.Label();
            this.ControlsButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.WindowsTitleExample = new System.Windows.Forms.Label();
            this.ComputerUsageExample = new System.Windows.Forms.Label();
            this.TimeElapsedExample = new System.Windows.Forms.Label();
            this.HideNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.HideNotificationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.Show = new System.Windows.Forms.ToolStripMenuItem();
            this.Leave = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImage)).BeginInit();
            this.HideNotificationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LargeImage
            // 
            this.LargeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LargeImage.Location = new System.Drawing.Point(22, 12);
            this.LargeImage.Name = "LargeImage";
            this.LargeImage.Size = new System.Drawing.Size(100, 101);
            this.LargeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeImage.TabIndex = 0;
            this.LargeImage.TabStop = false;
            // 
            // WindowsVersionExample
            // 
            this.WindowsVersionExample.AutoSize = true;
            this.WindowsVersionExample.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsVersionExample.Location = new System.Drawing.Point(126, 28);
            this.WindowsVersionExample.Name = "WindowsVersionExample";
            this.WindowsVersionExample.Size = new System.Drawing.Size(85, 21);
            this.WindowsVersionExample.TabIndex = 1;
            this.WindowsVersionExample.Text = "Windows ";
            // 
            // ControlsButton
            // 
            this.ControlsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlsButton.Location = new System.Drawing.Point(157, 122);
            this.ControlsButton.Name = "ControlsButton";
            this.ControlsButton.Size = new System.Drawing.Size(101, 23);
            this.ControlsButton.TabIndex = 2;
            this.ControlsButton.Text = "Start";
            this.ControlsButton.UseVisualStyleBackColor = true;
            this.ControlsButton.Click += new System.EventHandler(this.ControlsButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideButton.Location = new System.Drawing.Point(157, 151);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(101, 23);
            this.HideButton.TabIndex = 3;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // WindowsTitleExample
            // 
            this.WindowsTitleExample.AutoSize = true;
            this.WindowsTitleExample.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsTitleExample.Location = new System.Drawing.Point(127, 49);
            this.WindowsTitleExample.Name = "WindowsTitleExample";
            this.WindowsTitleExample.Size = new System.Drawing.Size(93, 17);
            this.WindowsTitleExample.TabIndex = 4;
            this.WindowsTitleExample.Text = "Windows Title";
            // 
            // ComputerUsageExample
            // 
            this.ComputerUsageExample.AutoSize = true;
            this.ComputerUsageExample.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerUsageExample.Location = new System.Drawing.Point(127, 66);
            this.ComputerUsageExample.Name = "ComputerUsageExample";
            this.ComputerUsageExample.Size = new System.Drawing.Size(142, 17);
            this.ComputerUsageExample.TabIndex = 5;
            this.ComputerUsageExample.Text = "CPU: XX% | RAM: XX%";
            // 
            // TimeElapsedExample
            // 
            this.TimeElapsedExample.AutoSize = true;
            this.TimeElapsedExample.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeElapsedExample.Location = new System.Drawing.Point(128, 83);
            this.TimeElapsedExample.Name = "TimeElapsedExample";
            this.TimeElapsedExample.Size = new System.Drawing.Size(112, 17);
            this.TimeElapsedExample.TabIndex = 6;
            this.TimeElapsedExample.Text = "XX:XX:XX elapsed";
            // 
            // HideNotification
            // 
            this.HideNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HideNotification.BalloonTipText = "Click the tray icon to restore Windows Discord RPC.";
            this.HideNotification.BalloonTipTitle = "Windows Discord RPC";
            this.HideNotification.ContextMenuStrip = this.HideNotificationMenu;
            this.HideNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("HideNotification.Icon")));
            this.HideNotification.Text = "Windows Discord RPC";
            this.HideNotification.BalloonTipClicked += new System.EventHandler(this.HideNotification_BalloonTipClicked);
            this.HideNotification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HideNotification_MouseClick);
            // 
            // HideNotificationMenu
            // 
            this.HideNotificationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start,
            this.Stop,
            this.Show,
            this.Leave});
            this.HideNotificationMenu.Name = "HideNotificationMenu";
            this.HideNotificationMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // Start
            // 
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(180, 22);
            this.Start.Text = "Start";
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(180, 22);
            this.Stop.Text = "Stop";
            this.Stop.Visible = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Show
            // 
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(180, 22);
            this.Show.Text = "Show";
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Leave
            // 
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(180, 22);
            this.Leave.Text = "Leave";
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // DiscordRPCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 180);
            this.Controls.Add(this.TimeElapsedExample);
            this.Controls.Add(this.ComputerUsageExample);
            this.Controls.Add(this.WindowsTitleExample);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ControlsButton);
            this.Controls.Add(this.WindowsVersionExample);
            this.Controls.Add(this.LargeImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 218);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 218);
            this.Name = "DiscordRPCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Discord RPC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiscordRPCForm_FormClosing);
            this.Load += new System.EventHandler(this.DiscordRPCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LargeImage)).EndInit();
            this.HideNotificationMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LargeImage;
        private System.Windows.Forms.Label WindowsVersionExample;
        private System.Windows.Forms.Button ControlsButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label WindowsTitleExample;
        private System.Windows.Forms.Label ComputerUsageExample;
        private System.Windows.Forms.Label TimeElapsedExample;
        private System.Windows.Forms.NotifyIcon HideNotification;
        private System.Windows.Forms.ContextMenuStrip HideNotificationMenu;
        private System.Windows.Forms.ToolStripMenuItem Start;
        private System.Windows.Forms.ToolStripMenuItem Stop;
        private System.Windows.Forms.ToolStripMenuItem Show;
        private System.Windows.Forms.ToolStripMenuItem Leave;
    }
}

