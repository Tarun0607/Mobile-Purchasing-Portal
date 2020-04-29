namespace Online_Mobile_Purchasing
{
    partial class Appbody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appbody));
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.Titlebarpanel = new System.Windows.Forms.Panel();
            this.SlidingPaneltimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Slidingpanel = new System.Windows.Forms.Panel();
            this.Carttabbutton = new System.Windows.Forms.Button();
            this.Abouttabbutton = new System.Windows.Forms.Button();
            this.Settingstabbutton = new System.Windows.Forms.Button();
            this.Transactiontabbutton = new System.Windows.Forms.Button();
            this.PersonTabbutton = new System.Windows.Forms.Button();
            this.MobilesTabbutton = new System.Windows.Forms.Button();
            this.SlidingPanel_Togglebutton = new System.Windows.Forms.Button();
            this.LogOffbutton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Titlebarpanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.Slidingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Enabled = true;
            this.Log_in_Timer.Interval = 20;
            this.Log_in_Timer.Tick += new System.EventHandler(this.Log_in_Timer_Tick);
            // 
            // Titlebarpanel
            // 
            this.Titlebarpanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Titlebarpanel.Controls.Add(this.LogOffbutton);
            this.Titlebarpanel.Controls.Add(this.MinimizeButton);
            this.Titlebarpanel.Controls.Add(this.Closebutton);
            this.Titlebarpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebarpanel.Location = new System.Drawing.Point(0, 0);
            this.Titlebarpanel.Name = "Titlebarpanel";
            this.Titlebarpanel.Size = new System.Drawing.Size(800, 33);
            this.Titlebarpanel.TabIndex = 0;
            this.Titlebarpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Titlebarpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebarpanel_MouseDown);
            // 
            // SlidingPaneltimer
            // 
            this.SlidingPaneltimer.Tick += new System.EventHandler(this.SlidingPaneltimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImage = global::Online_Mobile_Purchasing.Properties.Resources.download__1_;
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(191, 33);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(609, 417);
            this.ContentPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Online Mobile Purchasing Portal\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Slidingpanel
            // 
            this.Slidingpanel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Slidingpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Slidingpanel.BackgroundImage")));
            this.Slidingpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slidingpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Slidingpanel.Controls.Add(this.Carttabbutton);
            this.Slidingpanel.Controls.Add(this.Abouttabbutton);
            this.Slidingpanel.Controls.Add(this.Settingstabbutton);
            this.Slidingpanel.Controls.Add(this.Transactiontabbutton);
            this.Slidingpanel.Controls.Add(this.PersonTabbutton);
            this.Slidingpanel.Controls.Add(this.MobilesTabbutton);
            this.Slidingpanel.Controls.Add(this.SlidingPanel_Togglebutton);
            this.Slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidingpanel.Location = new System.Drawing.Point(0, 33);
            this.Slidingpanel.Name = "Slidingpanel";
            this.Slidingpanel.Size = new System.Drawing.Size(193, 417);
            this.Slidingpanel.TabIndex = 1;
            this.Slidingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Carttabbutton
            // 
            this.Carttabbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Carttabbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Carttabbutton.BackgroundImage")));
            this.Carttabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carttabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carttabbutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.icons8_add_shopping_cart_32;
            this.Carttabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Carttabbutton.Location = new System.Drawing.Point(0, 177);
            this.Carttabbutton.Name = "Carttabbutton";
            this.Carttabbutton.Size = new System.Drawing.Size(193, 60);
            this.Carttabbutton.TabIndex = 8;
            this.Carttabbutton.Text = "CART";
            this.Carttabbutton.UseVisualStyleBackColor = false;
            this.Carttabbutton.Click += new System.EventHandler(this.Carttabbutton_Click);
            // 
            // Abouttabbutton
            // 
            this.Abouttabbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Abouttabbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Abouttabbutton.BackgroundImage")));
            this.Abouttabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Abouttabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abouttabbutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.iconfinder_about_71696;
            this.Abouttabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abouttabbutton.Location = new System.Drawing.Point(-1, 346);
            this.Abouttabbutton.Name = "Abouttabbutton";
            this.Abouttabbutton.Size = new System.Drawing.Size(193, 58);
            this.Abouttabbutton.TabIndex = 7;
            this.Abouttabbutton.Text = "ABOUT";
            this.Abouttabbutton.UseVisualStyleBackColor = false;
            this.Abouttabbutton.Click += new System.EventHandler(this.Abouttabbutton_Click);
            // 
            // Settingstabbutton
            // 
            this.Settingstabbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Settingstabbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settingstabbutton.BackgroundImage")));
            this.Settingstabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settingstabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settingstabbutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.icons8_automatic_26;
            this.Settingstabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settingstabbutton.Location = new System.Drawing.Point(-1, 290);
            this.Settingstabbutton.Name = "Settingstabbutton";
            this.Settingstabbutton.Size = new System.Drawing.Size(193, 59);
            this.Settingstabbutton.TabIndex = 6;
            this.Settingstabbutton.Text = "SETTINGS";
            this.Settingstabbutton.UseVisualStyleBackColor = false;
            this.Settingstabbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Transactiontabbutton
            // 
            this.Transactiontabbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.Transactiontabbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Transactiontabbutton.BackgroundImage")));
            this.Transactiontabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transactiontabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactiontabbutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.icons8_transaction_32;
            this.Transactiontabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transactiontabbutton.Location = new System.Drawing.Point(-1, 233);
            this.Transactiontabbutton.Name = "Transactiontabbutton";
            this.Transactiontabbutton.Size = new System.Drawing.Size(193, 60);
            this.Transactiontabbutton.TabIndex = 5;
            this.Transactiontabbutton.Text = "     TRANSACTIONS";
            this.Transactiontabbutton.UseVisualStyleBackColor = false;
            this.Transactiontabbutton.Click += new System.EventHandler(this.Transactiontabbutton_Click);
            // 
            // PersonTabbutton
            // 
            this.PersonTabbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.PersonTabbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PersonTabbutton.BackgroundImage")));
            this.PersonTabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PersonTabbutton.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.PersonTabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonTabbutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.icons8_user_24;
            this.PersonTabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonTabbutton.Location = new System.Drawing.Point(0, 118);
            this.PersonTabbutton.Name = "PersonTabbutton";
            this.PersonTabbutton.Size = new System.Drawing.Size(193, 59);
            this.PersonTabbutton.TabIndex = 4;
            this.PersonTabbutton.Text = "PROFILE";
            this.PersonTabbutton.UseVisualStyleBackColor = false;
            this.PersonTabbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MobilesTabbutton
            // 
            this.MobilesTabbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.MobilesTabbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MobilesTabbutton.BackgroundImage")));
            this.MobilesTabbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MobilesTabbutton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.MobilesTabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobilesTabbutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.icons8_mobile_26;
            this.MobilesTabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MobilesTabbutton.Location = new System.Drawing.Point(0, 62);
            this.MobilesTabbutton.Name = "MobilesTabbutton";
            this.MobilesTabbutton.Size = new System.Drawing.Size(193, 59);
            this.MobilesTabbutton.TabIndex = 3;
            this.MobilesTabbutton.Text = "MOBILES";
            this.MobilesTabbutton.UseVisualStyleBackColor = false;
            this.MobilesTabbutton.Click += new System.EventHandler(this.MobilesTabbutton_Click);
            // 
            // SlidingPanel_Togglebutton
            // 
            this.SlidingPanel_Togglebutton.BackColor = System.Drawing.Color.SpringGreen;
            this.SlidingPanel_Togglebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlidingPanel_Togglebutton.BackgroundImage")));
            this.SlidingPanel_Togglebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanel_Togglebutton.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.SlidingPanel_Togglebutton.ForeColor = System.Drawing.Color.White;
            this.SlidingPanel_Togglebutton.Image = global::Online_Mobile_Purchasing.Properties.Resources.icons8_forward_24;
            this.SlidingPanel_Togglebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingPanel_Togglebutton.Location = new System.Drawing.Point(0, 3);
            this.SlidingPanel_Togglebutton.Name = "SlidingPanel_Togglebutton";
            this.SlidingPanel_Togglebutton.Size = new System.Drawing.Size(193, 59);
            this.SlidingPanel_Togglebutton.TabIndex = 2;
            this.SlidingPanel_Togglebutton.UseVisualStyleBackColor = false;
            this.SlidingPanel_Togglebutton.ForeColorChanged += new System.EventHandler(this.SlidingPanel_Togglebutton_Click);
            this.SlidingPanel_Togglebutton.Click += new System.EventHandler(this.SlidingPanel_Togglebutton_Click);
            // 
            // LogOffbutton
            // 
            this.LogOffbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOffbutton.BackgroundImage = global::Online_Mobile_Purchasing.Properties.Resources.logoff1;
            this.LogOffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffbutton.ForeColor = System.Drawing.Color.LightCyan;
            this.LogOffbutton.Location = new System.Drawing.Point(686, 1);
            this.LogOffbutton.Name = "LogOffbutton";
            this.LogOffbutton.Size = new System.Drawing.Size(34, 29);
            this.LogOffbutton.TabIndex = 3;
            this.LogOffbutton.UseVisualStyleBackColor = false;
            this.LogOffbutton.Click += new System.EventHandler(this.LogOffbutton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::Online_Mobile_Purchasing.Properties.Resources.minimize;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.LightCyan;
            this.MinimizeButton.Location = new System.Drawing.Point(726, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 29);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.BackgroundImage = global::Online_Mobile_Purchasing.Properties.Resources.close;
            this.Closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.ForeColor = System.Drawing.Color.LightCyan;
            this.Closebutton.Location = new System.Drawing.Point(766, 1);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(34, 29);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.Slidingpanel);
            this.Controls.Add(this.Titlebarpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appbody";
            this.Text = "Appbody";
            this.Load += new System.EventHandler(this.Appbody_Load);
            this.Titlebarpanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.Slidingpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel Titlebarpanel;
        private System.Windows.Forms.Button LogOffbutton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Panel Slidingpanel;
        private System.Windows.Forms.Button SlidingPanel_Togglebutton;
        private System.Windows.Forms.Timer SlidingPaneltimer;
        private System.Windows.Forms.Button Abouttabbutton;
        private System.Windows.Forms.Button Settingstabbutton;
        private System.Windows.Forms.Button Transactiontabbutton;
        private System.Windows.Forms.Button PersonTabbutton;
        private System.Windows.Forms.Button MobilesTabbutton;
        private System.Windows.Forms.Button Carttabbutton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}