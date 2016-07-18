namespace QR_CODE
{
    partial class QR_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decode_rbtn = new System.Windows.Forms.RadioButton();
            this.encode_rbtn = new System.Windows.Forms.RadioButton();
            this.en_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Qr_img = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slide_btn = new System.Windows.Forms.Button();
            this.auto_slide = new System.Windows.Forms.Timer(this.components);
            this.radiobox_checkedDetector = new System.Windows.Forms.Timer(this.components);
            this.page2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.QR_img2 = new System.Windows.Forms.PictureBox();
            this.Choose_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qr_img)).BeginInit();
            this.panel1.SuspendLayout();
            this.page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR_img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.decode_rbtn);
            this.groupBox1.Controls.Add(this.encode_rbtn);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Mission";
            // 
            // decode_rbtn
            // 
            this.decode_rbtn.AutoSize = true;
            this.decode_rbtn.Location = new System.Drawing.Point(379, 32);
            this.decode_rbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.decode_rbtn.Name = "decode_rbtn";
            this.decode_rbtn.Size = new System.Drawing.Size(117, 24);
            this.decode_rbtn.TabIndex = 1;
            this.decode_rbtn.TabStop = true;
            this.decode_rbtn.Text = "Decode QR";
            this.decode_rbtn.UseVisualStyleBackColor = true;
            this.decode_rbtn.CheckedChanged += new System.EventHandler(this.decode_rbtn_CheckedChanged);
            // 
            // encode_rbtn
            // 
            this.encode_rbtn.AutoSize = true;
            this.encode_rbtn.Location = new System.Drawing.Point(80, 28);
            this.encode_rbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.encode_rbtn.Name = "encode_rbtn";
            this.encode_rbtn.Size = new System.Drawing.Size(113, 24);
            this.encode_rbtn.TabIndex = 0;
            this.encode_rbtn.TabStop = true;
            this.encode_rbtn.Text = "Encode QR";
            this.encode_rbtn.UseVisualStyleBackColor = true;
            // 
            // en_txt
            // 
            this.en_txt.Location = new System.Drawing.Point(144, 118);
            this.en_txt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.en_txt.Multiline = true;
            this.en_txt.Name = "en_txt";
            this.en_txt.Size = new System.Drawing.Size(485, 58);
            this.en_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Text";
            // 
            // Qr_img
            // 
            this.Qr_img.Location = new System.Drawing.Point(173, 290);
            this.Qr_img.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Qr_img.Name = "Qr_img";
            this.Qr_img.Size = new System.Drawing.Size(205, 201);
            this.Qr_img.TabIndex = 3;
            this.Qr_img.TabStop = false;
            this.Qr_img.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Qr_img_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.slide_btn);
            this.panel1.Location = new System.Drawing.Point(144, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 32);
            this.panel1.TabIndex = 4;
            // 
            // slide_btn
            // 
            this.slide_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slide_btn.ForeColor = System.Drawing.Color.Red;
            this.slide_btn.Location = new System.Drawing.Point(0, 0);
            this.slide_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.slide_btn.Name = "slide_btn";
            this.slide_btn.Size = new System.Drawing.Size(56, 32);
            this.slide_btn.TabIndex = 0;
            this.slide_btn.Text = "OFF";
            this.slide_btn.UseVisualStyleBackColor = true;
            this.slide_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slide_btn_MouseDown);
            this.slide_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slide_btn_MouseMove);
            this.slide_btn.Move += new System.EventHandler(this.slide_btn_Move);
            // 
            // auto_slide
            // 
            this.auto_slide.Interval = 10;
            this.auto_slide.Tick += new System.EventHandler(this.auto_slide_Tick);
            // 
            // radiobox_checkedDetector
            // 
            this.radiobox_checkedDetector.Tick += new System.EventHandler(this.radiobox_checkedDetector_Tick);
            // 
            // page2
            // 
            this.page2.BackColor = System.Drawing.Color.Transparent;
            this.page2.Controls.Add(this.pictureBox2);
            this.page2.Controls.Add(this.linkLabel1);
            this.page2.Controls.Add(this.QR_img2);
            this.page2.Controls.Add(this.Choose_btn);
            this.page2.Controls.Add(this.textBox2);
            this.page2.Controls.Add(this.textBox1);
            this.page2.Location = new System.Drawing.Point(14, 101);
            this.page2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(641, 458);
            this.page2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(3, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "©Scannitor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // QR_img2
            // 
            this.QR_img2.InitialImage = global::QR_CODE.Properties.Resources.proifle_pic_;
            this.QR_img2.Location = new System.Drawing.Point(86, 164);
            this.QR_img2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.QR_img2.Name = "QR_img2";
            this.QR_img2.Size = new System.Drawing.Size(212, 188);
            this.QR_img2.TabIndex = 3;
            this.QR_img2.TabStop = false;
            // 
            // Choose_btn
            // 
            this.Choose_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Choose_btn.Location = new System.Drawing.Point(465, 16);
            this.Choose_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Choose_btn.Name = "Choose_btn";
            this.Choose_btn.Size = new System.Drawing.Size(125, 36);
            this.Choose_btn.TabIndex = 2;
            this.Choose_btn.Text = "Choose File";
            this.Choose_btn.UseVisualStyleBackColor = true;
            this.Choose_btn.Click += new System.EventHandler(this.Choose_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 19);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 96);
            this.textBox1.TabIndex = 0;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(16, 471);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(94, 20);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "©Scannitor";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QR_CODE.Properties.Resources.scannitor_with_border1;
            this.pictureBox1.Location = new System.Drawing.Point(468, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::QR_CODE.Properties.Resources.scannitor_with_border1;
            this.pictureBox2.Location = new System.Drawing.Point(454, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // QR_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::QR_CODE.Properties.Resources.stardust__2X;
            this.ClientSize = new System.Drawing.Size(669, 517);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.page2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Qr_img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.en_txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "QR_form";
            this.Text = "Scannitor";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.QR_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qr_img)).EndInit();
            this.panel1.ResumeLayout(false);
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QR_img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decode_rbtn;
        private System.Windows.Forms.RadioButton encode_rbtn;
        private System.Windows.Forms.TextBox en_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Qr_img;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button slide_btn;
        private System.Windows.Forms.Timer auto_slide;
        private System.Windows.Forms.Timer radiobox_checkedDetector;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox QR_img2;
        private System.Windows.Forms.Button Choose_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

