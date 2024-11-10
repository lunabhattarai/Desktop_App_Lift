namespace Elevator1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gfloor = new PictureBox();
            ffloor = new PictureBox();
            pictureBox3 = new PictureBox();
            mainelevator = new PictureBox();
            btnf = new Button();
            btng = new Button();
            btnopen = new Button();
            btnclose = new Button();
            btnfirst = new Button();
            btnground = new Button();
            lifttimer = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            doortimer1 = new System.Windows.Forms.Timer(components);
            doortimer2 = new System.Windows.Forms.Timer(components);
            btnclear = new Button();
            btnexit = new Button();
            datagridviewlogs = new DataGridView();
            doorleft1 = new PictureBox();
            doorright1 = new PictureBox();
            doorright2 = new PictureBox();
            doorleft2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            Floor1 = new PictureBox();
            upgif = new PictureBox();
            downgif = new PictureBox();
            lblFloorDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)gfloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ffloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainelevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewlogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorright2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doorleft2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Floor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upgif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downgif).BeginInit();
            SuspendLayout();
            // 
            // gfloor
            // 
            gfloor.Location = new Point(228, 371);
            gfloor.Name = "gfloor";
            gfloor.Size = new Size(330, 273);
            gfloor.TabIndex = 0;
            gfloor.TabStop = false;
            // 
            // ffloor
            // 
            ffloor.Location = new Point(228, 33);
            ffloor.Name = "ffloor";
            ffloor.Size = new Size(330, 273);
            ffloor.TabIndex = 1;
            ffloor.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(719, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(166, 660);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // mainelevator
            // 
            mainelevator.BackgroundImage = (Image)resources.GetObject("mainelevator.BackgroundImage");
            mainelevator.BackgroundImageLayout = ImageLayout.Stretch;
            mainelevator.Location = new Point(229, 371);
            mainelevator.Name = "mainelevator";
            mainelevator.Size = new Size(330, 273);
            mainelevator.TabIndex = 7;
            mainelevator.TabStop = false;
            // 
            // btnf
            // 
            btnf.BackgroundImage = (Image)resources.GetObject("btnf.BackgroundImage");
            btnf.BackgroundImageLayout = ImageLayout.Stretch;
            btnf.Location = new Point(781, 243);
            btnf.Name = "btnf";
            btnf.Size = new Size(66, 63);
            btnf.TabIndex = 8;
            btnf.UseVisualStyleBackColor = true;
            btnf.Click += btn_f_click;
            // 
            // btng
            // 
            btng.BackgroundImage = (Image)resources.GetObject("btng.BackgroundImage");
            btng.BackgroundImageLayout = ImageLayout.Stretch;
            btng.Location = new Point(781, 350);
            btng.Name = "btng";
            btng.Size = new Size(66, 56);
            btng.TabIndex = 9;
            btng.UseVisualStyleBackColor = true;
            btng.Click += btn_g_click;
            // 
            // btnopen
            // 
            btnopen.BackgroundImage = (Image)resources.GetObject("btnopen.BackgroundImage");
            btnopen.BackgroundImageLayout = ImageLayout.Stretch;
            btnopen.Location = new Point(739, 471);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(67, 69);
            btnopen.TabIndex = 10;
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += btn_open_click;
            // 
            // btnclose
            // 
            btnclose.BackgroundImage = (Image)resources.GetObject("btnclose.BackgroundImage");
            btnclose.BackgroundImageLayout = ImageLayout.Stretch;
            btnclose.Location = new Point(835, 471);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(50, 69);
            btnclose.TabIndex = 11;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btn_close_click;
            // 
            // btnfirst
            // 
            btnfirst.BackgroundImage = (Image)resources.GetObject("btnfirst.BackgroundImage");
            btnfirst.BackgroundImageLayout = ImageLayout.Stretch;
            btnfirst.Location = new Point(573, 159);
            btnfirst.Name = "btnfirst";
            btnfirst.Size = new Size(41, 31);
            btnfirst.TabIndex = 12;
            btnfirst.UseVisualStyleBackColor = true;
            btnfirst.Click += btn_first_click;
            // 
            // btnground
            // 
            btnground.BackgroundImage = (Image)resources.GetObject("btnground.BackgroundImage");
            btnground.BackgroundImageLayout = ImageLayout.Stretch;
            btnground.Location = new Point(573, 532);
            btnground.Name = "btnground";
            btnground.Size = new Size(41, 29);
            btnground.TabIndex = 13;
            btnground.UseVisualStyleBackColor = true;
            btnground.Click += btn_ground_click;
            // 
            // lifttimer
            // 
            lifttimer.Tick += lift_timer_tick;
            // 
            // doortimer1
            // 
            doortimer1.Tick += door_timer_tick_1;
            // 
            // doortimer2
            // 
            doortimer2.Tick += door_timer_tick_2;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(0, 0, 192);
            btnclear.ForeColor = SystemColors.ButtonFace;
            btnclear.Location = new Point(1171, 73);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 14;
            btnclear.Text = "Clear ";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += delete_data_click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(0, 0, 192);
            btnexit.BackgroundImageLayout = ImageLayout.None;
            btnexit.ForeColor = SystemColors.ButtonFace;
            btnexit.Location = new Point(1271, 73);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 15;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += close_click;
            // 
            // datagridviewlogs
            // 
            datagridviewlogs.BackgroundColor = Color.Gray;
            datagridviewlogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewlogs.Location = new Point(966, 108);
            datagridviewlogs.Name = "datagridviewlogs";
            datagridviewlogs.RowHeadersWidth = 51;
            datagridviewlogs.Size = new Size(399, 557);
            datagridviewlogs.TabIndex = 16;
            datagridviewlogs.CellContentClick += datagridviewlogs_CellContentClick;
            // 
            // doorleft1
            // 
            doorleft1.BackgroundImage = Properties.Resources.leftdoor3;
            doorleft1.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft1.Location = new Point(229, 33);
            doorleft1.Name = "doorleft1";
            doorleft1.Size = new Size(166, 273);
            doorleft1.TabIndex = 17;
            doorleft1.TabStop = false;
            // 
            // doorright1
            // 
            doorright1.BackgroundImage = Properties.Resources.leftdoor13;
            doorright1.BackgroundImageLayout = ImageLayout.Stretch;
            doorright1.Location = new Point(392, 33);
            doorright1.Name = "doorright1";
            doorright1.Size = new Size(166, 273);
            doorright1.TabIndex = 18;
            doorright1.TabStop = false;
            // 
            // doorright2
            // 
            doorright2.BackgroundImage = Properties.Resources.leftdoor13;
            doorright2.BackgroundImageLayout = ImageLayout.Stretch;
            doorright2.Location = new Point(392, 371);
            doorright2.Name = "doorright2";
            doorright2.Size = new Size(166, 273);
            doorright2.TabIndex = 19;
            doorright2.TabStop = false;
            // 
            // doorleft2
            // 
            doorleft2.BackgroundImage = Properties.Resources.leftdoor3;
            doorleft2.BackgroundImageLayout = ImageLayout.Stretch;
            doorleft2.Location = new Point(229, 371);
            doorleft2.Name = "doorleft2";
            doorleft2.Size = new Size(166, 273);
            doorleft2.TabIndex = 20;
            doorleft2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(376, 332);
            button1.Name = "button1";
            button1.Size = new Size(42, 29);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(377, 1);
            button2.Name = "button2";
            button2.Size = new Size(41, 26);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(86, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 273);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(86, 371);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(583, 273);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(966, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 27;
            textBox1.Text = "Log History of Elevator";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(Floor1);
            panel1.Controls.Add(upgif);
            panel1.Controls.Add(downgif);
            panel1.Controls.Add(lblFloorDisplay);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(757, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 101);
            panel1.TabIndex = 28;
            // 
            // Floor1
            // 
            Floor1.Image = Properties.Resources.images__1_;
            Floor1.Location = new Point(14, 17);
            Floor1.Name = "Floor1";
            Floor1.Size = new Size(85, 62);
            Floor1.SizeMode = PictureBoxSizeMode.Zoom;
            Floor1.TabIndex = 29;
            Floor1.TabStop = false;
            Floor1.Visible = false;
            // 
            // upgif
            // 
            upgif.Image = Properties.Resources.upward;
            upgif.Location = new Point(14, 17);
            upgif.Name = "upgif";
            upgif.Size = new Size(85, 62);
            upgif.SizeMode = PictureBoxSizeMode.Zoom;
            upgif.TabIndex = 29;
            upgif.TabStop = false;
            upgif.Visible = false;
            // 
            // downgif
            // 
            downgif.BackgroundImageLayout = ImageLayout.Stretch;
            downgif.Image = Properties.Resources.downl;
            downgif.Location = new Point(14, 17);
            downgif.Name = "downgif";
            downgif.Size = new Size(85, 62);
            downgif.SizeMode = PictureBoxSizeMode.Zoom;
            downgif.TabIndex = 1;
            downgif.TabStop = false;
            downgif.Visible = false;
            // 
            // lblFloorDisplay
            // 
            lblFloorDisplay.AutoSize = true;
            lblFloorDisplay.BackColor = Color.Black;
            lblFloorDisplay.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFloorDisplay.ForeColor = Color.White;
            lblFloorDisplay.Location = new Point(26, 17);
            lblFloorDisplay.Name = "lblFloorDisplay";
            lblFloorDisplay.Size = new Size(0, 62);
            lblFloorDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 677);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(doorleft2);
            Controls.Add(doorright2);
            Controls.Add(doorright1);
            Controls.Add(doorleft1);
            Controls.Add(datagridviewlogs);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnclose);
            Controls.Add(btnopen);
            Controls.Add(btng);
            Controls.Add(btnf);
            Controls.Add(pictureBox3);
            Controls.Add(mainelevator);
            Controls.Add(gfloor);
            Controls.Add(ffloor);
            Controls.Add(btnfirst);
            Controls.Add(btnground);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gfloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ffloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainelevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridviewlogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright1).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorright2).EndInit();
            ((System.ComponentModel.ISupportInitialize)doorleft2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Floor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)upgif).EndInit();
            ((System.ComponentModel.ISupportInitialize)downgif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gfloor;
        private PictureBox ffloor;
        private PictureBox pictureBox3;
        private PictureBox mainelevator;
        private Button btnf;
        private Button btng;
        private Button btnopen;
        private Button btnclose;
        private Button btnfirst;
        private Button btnground;
        private System.Windows.Forms.Timer lifttimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer doortimer1;
        private System.Windows.Forms.Timer doortimer2;
        private Button btnclear;
        private Button btnexit;
        private DataGridView datagridviewlogs;
        private PictureBox doorleft1;
        private PictureBox doorright1;
        private PictureBox doorright2;
        private PictureBox doorleft2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Panel panel1;
        private Label lblFloorDisplay;
        private PictureBox downgif;
        private PictureBox upgif;
        private PictureBox floor1;
        private PictureBox Floor1;
    }
}