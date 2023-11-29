namespace CarProject
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.AddRemoveClientsBTN = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.settingbtn = new System.Windows.Forms.Button();
            this.AddRemoveCarBTN = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebarmenutimer = new System.Windows.Forms.Timer(this.components);
            this.settingtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 644);
            this.panel1.TabIndex = 0;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.menu);
            this.sidebar.Controls.Add(this.settingpanel);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Location = new System.Drawing.Point(3, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(227, 638);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 638);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(227, 638);
            this.sidebar.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.AddRemoveClientsBTN);
            this.panel8.Location = new System.Drawing.Point(1, 419);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(226, 50);
            this.panel8.TabIndex = 4;
            // 
            // AddRemoveClientsBTN
            // 
            this.AddRemoveClientsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRemoveClientsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemoveClientsBTN.ForeColor = System.Drawing.Color.White;
            this.AddRemoveClientsBTN.Image = ((System.Drawing.Image)(resources.GetObject("AddRemoveClientsBTN.Image")));
            this.AddRemoveClientsBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AddRemoveClientsBTN.Location = new System.Drawing.Point(-1, 5);
            this.AddRemoveClientsBTN.Name = "AddRemoveClientsBTN";
            this.AddRemoveClientsBTN.Size = new System.Drawing.Size(225, 45);
            this.AddRemoveClientsBTN.TabIndex = 4;
            this.AddRemoveClientsBTN.Text = "Add/Clients Car";
            this.AddRemoveClientsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRemoveClientsBTN.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.label1);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Location = new System.Drawing.Point(3, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(225, 45);
            this.menu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // settingpanel
            // 
            this.settingpanel.Controls.Add(this.panel2);
            this.settingpanel.Controls.Add(this.AddRemoveCarBTN);
            this.settingpanel.Location = new System.Drawing.Point(2, 325);
            this.settingpanel.MaximumSize = new System.Drawing.Size(226, 159);
            this.settingpanel.MinimumSize = new System.Drawing.Size(226, 50);
            this.settingpanel.Name = "settingpanel";
            this.settingpanel.Size = new System.Drawing.Size(226, 144);
            this.settingpanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.settingbtn);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 50);
            this.panel2.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 44);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(226, 50);
            this.panel9.TabIndex = 4;
            // 
            // settingbtn
            // 
            this.settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingbtn.ForeColor = System.Drawing.Color.White;
            this.settingbtn.Image = ((System.Drawing.Image)(resources.GetObject("settingbtn.Image")));
            this.settingbtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.settingbtn.Location = new System.Drawing.Point(0, 2);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(225, 45);
            this.settingbtn.TabIndex = 2;
            this.settingbtn.Text = "Settings";
            this.settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingbtn.UseVisualStyleBackColor = true;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // AddRemoveCarBTN
            // 
            this.AddRemoveCarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRemoveCarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemoveCarBTN.ForeColor = System.Drawing.Color.White;
            this.AddRemoveCarBTN.Image = ((System.Drawing.Image)(resources.GetObject("AddRemoveCarBTN.Image")));
            this.AddRemoveCarBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AddRemoveCarBTN.Location = new System.Drawing.Point(-1, 58);
            this.AddRemoveCarBTN.Name = "AddRemoveCarBTN";
            this.AddRemoveCarBTN.Size = new System.Drawing.Size(225, 45);
            this.AddRemoveCarBTN.TabIndex = 3;
            this.AddRemoveCarBTN.Text = "Add/Remove Car";
            this.AddRemoveCarBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRemoveCarBTN.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(1, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 50);
            this.panel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(6, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rental";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 50);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Car";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Location = new System.Drawing.Point(2, 274);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 50);
            this.panel7.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.Location = new System.Drawing.Point(6, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(225, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "Clients";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(2, 223);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 50);
            this.panel6.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.Location = new System.Drawing.Point(6, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "Return";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 50);
            this.panel4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // sidebarmenutimer
            // 
            this.sidebarmenutimer.Tick += new System.EventHandler(this.sidebarmenutimer_Tick);
            // 
            // settingtimer
            // 
            this.settingtimer.Tick += new System.EventHandler(this.settingtimer_Tick);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 644);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel settingpanel;
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarmenutimer;
        private System.Windows.Forms.Button AddRemoveCarBTN;
        private System.Windows.Forms.Timer settingtimer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddRemoveClientsBTN;
    }
}