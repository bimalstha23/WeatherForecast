namespace WeatherForecast
{
    partial class WeatherMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherMan));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblWindspeed = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.Label();
            this.timetxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.humiditybar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentweathericon = new System.Windows.Forms.PictureBox();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.lblCityname = new System.Windows.Forms.Label();
            this.lblTempstatus = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.activeContainerPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCalender = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logotitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settings1 = new WeatherForecast.Settings();
            this.calender1 = new WeatherForecast.Calender();
            this.mainDashBoard1 = new WeatherForecast.mainDashBoard();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentweathericon)).BeginInit();
            this.panelinfo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(118, 194);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(28, 15);
            this.lblPressure.TabIndex = 37;
            this.lblPressure.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "Wind Speed:";
            // 
            // lblWindspeed
            // 
            this.lblWindspeed.AutoSize = true;
            this.lblWindspeed.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindspeed.Location = new System.Drawing.Point(118, 173);
            this.lblWindspeed.Name = "lblWindspeed";
            this.lblWindspeed.Size = new System.Drawing.Size(28, 15);
            this.lblWindspeed.TabIndex = 35;
            this.lblWindspeed.Text = "N/A";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.Location = new System.Drawing.Point(118, 152);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(28, 15);
            this.lblVisibility.TabIndex = 34;
            this.lblVisibility.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Wind Speed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Visibility:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(119, 214);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(28, 15);
            this.lblHumidity.TabIndex = 31;
            this.lblHumidity.Text = "N/A";
            // 
            // datetxt
            // 
            this.datetxt.AutoSize = true;
            this.datetxt.Location = new System.Drawing.Point(36, 47);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(27, 13);
            this.datetxt.TabIndex = 3;
            this.datetxt.Text = "N/A";
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.Location = new System.Drawing.Point(36, 34);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(27, 13);
            this.timetxt.TabIndex = 2;
            this.timetxt.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Humidity:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(56, 126);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(30, 13);
            this.lblCountry.TabIndex = 29;
            this.lblCountry.Tag = "0";
            this.lblCountry.Text = "N/A";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(34, 79);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(61, 29);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "N/A°";
            // 
            // humiditybar
            // 
            this.humiditybar.BorderColor = System.Drawing.Color.Transparent;
            this.humiditybar.BorderRadius = 3;
            this.humiditybar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(255)))), ((int)(((byte)(168)))));
            this.humiditybar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiditybar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(255)))), ((int)(((byte)(168)))));
            this.humiditybar.Location = new System.Drawing.Point(6, 231);
            this.humiditybar.Name = "humiditybar";
            this.humiditybar.Size = new System.Drawing.Size(140, 5);
            this.humiditybar.TabIndex = 27;
            this.humiditybar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datetxt);
            this.panel2.Controls.Add(this.timetxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.currentweathericon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 65);
            this.panel2.TabIndex = 0;
            // 
            // currentweathericon
            // 
            this.currentweathericon.Image = ((System.Drawing.Image)(resources.GetObject("currentweathericon.Image")));
            this.currentweathericon.Location = new System.Drawing.Point(2, 23);
            this.currentweathericon.Name = "currentweathericon";
            this.currentweathericon.Size = new System.Drawing.Size(32, 33);
            this.currentweathericon.TabIndex = 0;
            this.currentweathericon.TabStop = false;
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.White;
            this.panelinfo.Controls.Add(this.lblPressure);
            this.panelinfo.Controls.Add(this.label13);
            this.panelinfo.Controls.Add(this.lblWindspeed);
            this.panelinfo.Controls.Add(this.lblVisibility);
            this.panelinfo.Controls.Add(this.label11);
            this.panelinfo.Controls.Add(this.label10);
            this.panelinfo.Controls.Add(this.lblHumidity);
            this.panelinfo.Controls.Add(this.label9);
            this.panelinfo.Controls.Add(this.lblCountry);
            this.panelinfo.Controls.Add(this.lblCityname);
            this.panelinfo.Controls.Add(this.lblTemp);
            this.panelinfo.Controls.Add(this.humiditybar);
            this.panelinfo.Controls.Add(this.panel2);
            this.panelinfo.Controls.Add(this.lblTempstatus);
            this.panelinfo.Location = new System.Drawing.Point(12, 299);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(158, 256);
            this.panelinfo.TabIndex = 5;
            // 
            // lblCityname
            // 
            this.lblCityname.AutoSize = true;
            this.lblCityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityname.Location = new System.Drawing.Point(55, 108);
            this.lblCityname.Name = "lblCityname";
            this.lblCityname.Size = new System.Drawing.Size(33, 16);
            this.lblCityname.TabIndex = 4;
            this.lblCityname.Text = "N/A";
            // 
            // lblTempstatus
            // 
            this.lblTempstatus.AutoSize = true;
            this.lblTempstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempstatus.Location = new System.Drawing.Point(89, 73);
            this.lblTempstatus.Name = "lblTempstatus";
            this.lblTempstatus.Size = new System.Drawing.Size(45, 42);
            this.lblTempstatus.TabIndex = 28;
            this.lblTempstatus.Text = "C";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.activeContainerPanel);
            this.panelMenu.Controls.Add(this.panelinfo);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnCalender);
            this.panelMenu.Controls.Add(this.btndashboard);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(195, 600);
            this.panelMenu.TabIndex = 29;
            // 
            // activeContainerPanel
            // 
            this.activeContainerPanel.BackColor = System.Drawing.Color.White;
            this.activeContainerPanel.Location = new System.Drawing.Point(185, 81);
            this.activeContainerPanel.Name = "activeContainerPanel";
            this.activeContainerPanel.Size = new System.Drawing.Size(10, 53);
            this.activeContainerPanel.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Settings";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCalender
            // 
            this.btnCalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalender.FlatAppearance.BorderSize = 0;
            this.btnCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalender.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalender.ForeColor = System.Drawing.Color.White;
            this.btnCalender.Image = ((System.Drawing.Image)(resources.GetObject("btnCalender.Image")));
            this.btnCalender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalender.Location = new System.Drawing.Point(0, 134);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(195, 53);
            this.btnCalender.TabIndex = 2;
            this.btnCalender.Text = "Calender";
            this.btnCalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 81);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(195, 53);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.Logotitle);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 81);
            this.panel1.TabIndex = 0;
            // 
            // Logotitle
            // 
            this.Logotitle.AutoSize = true;
            this.Logotitle.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logotitle.ForeColor = System.Drawing.Color.White;
            this.Logotitle.Location = new System.Drawing.Point(69, 26);
            this.Logotitle.Name = "Logotitle";
            this.Logotitle.Size = new System.Drawing.Size(119, 28);
            this.Logotitle.TabIndex = 1;
            this.Logotitle.Text = "Weatherman";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(195, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 17);
            this.panel3.TabIndex = 30;
            // 
            // settings1
            // 
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(195, 17);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(860, 583);
            this.settings1.TabIndex = 31;
            // 
            // calender1
            // 
            this.calender1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calender1.Location = new System.Drawing.Point(195, 17);
            this.calender1.Name = "calender1";
            this.calender1.Size = new System.Drawing.Size(860, 583);
            this.calender1.TabIndex = 32;
            // 
            // mainDashBoard1
            // 
            this.mainDashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashBoard1.Location = new System.Drawing.Point(195, 17);
            this.mainDashBoard1.Name = "mainDashBoard1";
            this.mainDashBoard1.Size = new System.Drawing.Size(860, 583);
            this.mainDashBoard1.TabIndex = 33;
            // 
            // WeatherMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 600);
            this.Controls.Add(this.mainDashBoard1);
            this.Controls.Add(this.calender1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeatherMan";
            this.Text = "WeatherMan";
            this.Load += new System.EventHandler(this.WeatherMan_Load_1);
            this.Shown += new System.EventHandler(this.WeatherMan_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentweathericon)).EndInit();
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblWindspeed;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label datetxt;
        private System.Windows.Forms.Label timetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTemp;
        private Guna.UI2.WinForms.Guna2ProgressBar humiditybar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox currentweathericon;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Label lblCityname;
        private System.Windows.Forms.Label lblTempstatus;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCalender;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Logotitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private Settings settings1;
        private Calender calender1;
        private mainDashBoard mainDashBoard1;
        private System.Windows.Forms.Panel activeContainerPanel;
    }
}

