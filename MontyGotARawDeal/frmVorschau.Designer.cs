namespace Coelina
{
    partial class frmVorschau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVorschau));
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.tbxSrienbriefAnhang = new System.Windows.Forms.TextBox();
            this.tbxEmpfänger = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxCc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxBetreff = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.tbxBcc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnhang1 = new System.Windows.Forms.Button();
            this.tbxAnhang1 = new System.Windows.Forms.TextBox();
            this.tbxAnhang2 = new System.Windows.Forms.TextBox();
            this.tbxAnhang3 = new System.Windows.Forms.TextBox();
            this.btnDieseNachrichtLöschen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnZurück = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnWeiter = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(6, 33);
            this.hScrollBar2.Maximum = 10;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(576, 36);
            this.hScrollBar2.TabIndex = 0;
            this.hScrollBar2.TabStop = true;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // tbxSrienbriefAnhang
            // 
            this.tbxSrienbriefAnhang.BackColor = System.Drawing.Color.White;
            this.tbxSrienbriefAnhang.Enabled = false;
            this.tbxSrienbriefAnhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSrienbriefAnhang.Location = new System.Drawing.Point(115, 225);
            this.tbxSrienbriefAnhang.Name = "tbxSrienbriefAnhang";
            this.tbxSrienbriefAnhang.Size = new System.Drawing.Size(397, 23);
            this.tbxSrienbriefAnhang.TabIndex = 7;
            this.tbxSrienbriefAnhang.Text = "Der Serienbrief-Anhang wird automatisch hinzugefügt";
            this.tbxSrienbriefAnhang.TextChanged += new System.EventHandler(this.tbxSrienbriefAnhang_TextChanged_1);
            // 
            // tbxEmpfänger
            // 
            this.tbxEmpfänger.BackColor = System.Drawing.Color.White;
            this.tbxEmpfänger.Enabled = false;
            this.tbxEmpfänger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpfänger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxEmpfänger.Location = new System.Drawing.Point(115, 24);
            this.tbxEmpfänger.Name = "tbxEmpfänger";
            this.tbxEmpfänger.Size = new System.Drawing.Size(397, 23);
            this.tbxEmpfänger.TabIndex = 2;
            this.tbxEmpfänger.TextChanged += new System.EventHandler(this.tbxEmpfänger_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(32, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "Anhang";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbxCc
            // 
            this.tbxCc.BackColor = System.Drawing.Color.White;
            this.tbxCc.Location = new System.Drawing.Point(115, 52);
            this.tbxCc.Name = "tbxCc";
            this.tbxCc.Size = new System.Drawing.Size(435, 20);
            this.tbxCc.TabIndex = 3;
            this.tbxCc.TextChanged += new System.EventHandler(this.tbxCc_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "CC";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Empfänger";
            // 
            // tbxBetreff
            // 
            this.tbxBetreff.BackColor = System.Drawing.Color.White;
            this.tbxBetreff.Location = new System.Drawing.Point(115, 103);
            this.tbxBetreff.Name = "tbxBetreff";
            this.tbxBetreff.Size = new System.Drawing.Size(435, 26);
            this.tbxBetreff.TabIndex = 5;
            this.tbxBetreff.Text = "";
            this.tbxBetreff.TextChanged += new System.EventHandler(this.tbxBetreff_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "BCC";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbxBody
            // 
            this.tbxBody.BackColor = System.Drawing.Color.White;
            this.tbxBody.Location = new System.Drawing.Point(115, 136);
            this.tbxBody.Name = "tbxBody";
            this.tbxBody.Size = new System.Drawing.Size(435, 83);
            this.tbxBody.TabIndex = 6;
            this.tbxBody.Text = "";
            this.tbxBody.TextChanged += new System.EventHandler(this.tbxBody_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Betreff";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.BackColor = System.Drawing.SystemColors.Control;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.ForeColor = System.Drawing.Color.Black;
            this.lblBody.Location = new System.Drawing.Point(32, 136);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(36, 18);
            this.lblBody.TabIndex = 22;
            this.lblBody.Text = "Text";
            this.lblBody.Click += new System.EventHandler(this.lblBody_Click);
            // 
            // tbxBcc
            // 
            this.tbxBcc.BackColor = System.Drawing.Color.White;
            this.tbxBcc.Location = new System.Drawing.Point(115, 77);
            this.tbxBcc.Name = "tbxBcc";
            this.tbxBcc.Size = new System.Drawing.Size(435, 20);
            this.tbxBcc.TabIndex = 4;
            this.tbxBcc.TextChanged += new System.EventHandler(this.tbxBcc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 22);
            this.label6.TabIndex = 73;
            this.label6.Text = "2. Postausgang durchblättern, verändern, verwerfen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnAnhang1);
            this.groupBox2.Controls.Add(this.tbxAnhang1);
            this.groupBox2.Controls.Add(this.tbxAnhang2);
            this.groupBox2.Controls.Add(this.tbxAnhang3);
            this.groupBox2.Controls.Add(this.btnDieseNachrichtLöschen);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxSrienbriefAnhang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbxEmpfänger);
            this.groupBox2.Controls.Add(this.tbxBody);
            this.groupBox2.Controls.Add(this.tbxCc);
            this.groupBox2.Controls.Add(this.tbxBcc);
            this.groupBox2.Controls.Add(this.lblBody);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxBetreff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 356);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jede Änderung gilt nur für die einzelne, ausgewählte E-Mail. Alle Änderungen sind" +
    " optional.";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Coelina.Properties.Resources.attach1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(524, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Coelina.Properties.Resources.attach1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(524, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAnhang1
            // 
            this.btnAnhang1.BackgroundImage = global::Coelina.Properties.Resources.attach1;
            this.btnAnhang1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnhang1.Location = new System.Drawing.Point(524, 264);
            this.btnAnhang1.Name = "btnAnhang1";
            this.btnAnhang1.Size = new System.Drawing.Size(26, 26);
            this.btnAnhang1.TabIndex = 39;
            this.btnAnhang1.UseVisualStyleBackColor = true;
            this.btnAnhang1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // tbxAnhang1
            // 
            this.tbxAnhang1.BackColor = System.Drawing.Color.White;
            this.tbxAnhang1.Location = new System.Drawing.Point(115, 268);
            this.tbxAnhang1.Name = "tbxAnhang1";
            this.tbxAnhang1.Size = new System.Drawing.Size(403, 20);
            this.tbxAnhang1.TabIndex = 38;
            this.tbxAnhang1.TabStop = false;
            // 
            // tbxAnhang2
            // 
            this.tbxAnhang2.BackColor = System.Drawing.Color.White;
            this.tbxAnhang2.Location = new System.Drawing.Point(115, 295);
            this.tbxAnhang2.Name = "tbxAnhang2";
            this.tbxAnhang2.Size = new System.Drawing.Size(403, 20);
            this.tbxAnhang2.TabIndex = 40;
            this.tbxAnhang2.TabStop = false;
            // 
            // tbxAnhang3
            // 
            this.tbxAnhang3.BackColor = System.Drawing.Color.White;
            this.tbxAnhang3.Location = new System.Drawing.Point(115, 322);
            this.tbxAnhang3.Name = "tbxAnhang3";
            this.tbxAnhang3.Size = new System.Drawing.Size(403, 20);
            this.tbxAnhang3.TabIndex = 42;
            this.tbxAnhang3.TabStop = false;
            // 
            // btnDieseNachrichtLöschen
            // 
            this.btnDieseNachrichtLöschen.BackColor = System.Drawing.SystemColors.Control;
            this.btnDieseNachrichtLöschen.Image = global::Coelina.Properties.Resources.cancel1;
            this.btnDieseNachrichtLöschen.Location = new System.Drawing.Point(518, 19);
            this.btnDieseNachrichtLöschen.Name = "btnDieseNachrichtLöschen";
            this.btnDieseNachrichtLöschen.Size = new System.Drawing.Size(32, 32);
            this.btnDieseNachrichtLöschen.TabIndex = 37;
            this.btnDieseNachrichtLöschen.UseVisualStyleBackColor = false;
            this.btnDieseNachrichtLöschen.Click += new System.EventHandler(this.btnDieseNachrichtLöschen_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackgroundImage = global::Coelina.Properties.Resources.find2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(518, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.hScrollBar2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blättern Sie durch den Postausgang. Jede einzelne E-Mail kann individuell verände" +
    "rt oder verworfen werden.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnZurück);
            this.groupBox4.Location = new System.Drawing.Point(12, 543);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zurück zu Schritt 1";
            // 
            // btnZurück
            // 
            this.btnZurück.BackgroundImage = global::Coelina.Properties.Resources.arrow_back1;
            this.btnZurück.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZurück.Location = new System.Drawing.Point(6, 21);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(111, 48);
            this.btnZurück.TabIndex = 12;
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnWeiter);
            this.groupBox5.Location = new System.Drawing.Point(481, 543);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 75);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Weiter zu Schritt 3";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // btnWeiter
            // 
            this.btnWeiter.AutoSize = true;
            this.btnWeiter.BackgroundImage = global::Coelina.Properties.Resources.arrow_forward1;
            this.btnWeiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWeiter.Location = new System.Drawing.Point(6, 21);
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.Size = new System.Drawing.Size(107, 48);
            this.btnWeiter.TabIndex = 0;
            this.btnWeiter.UseVisualStyleBackColor = true;
            this.btnWeiter.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(66, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(490, 49);
            this.groupBox6.TabIndex = 82;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Location = new System.Drawing.Point(369, 543);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(106, 75);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "E-Mail verwerfen";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Coelina.Properties.Resources.cancel;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(6, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 48);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Location = new System.Drawing.Point(141, 543);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(222, 75);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Den Anhang der angezeigte E-Mail öffnen";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Coelina.Properties.Resources.find1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Location = new System.Drawing.Point(6, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 48);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Coelina.Properties.Resources.infomation1;
            this.pictureBox6.Location = new System.Drawing.Point(562, 39);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 83;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Coelina.Properties.Resources.find2;
            this.pictureBox5.Location = new System.Drawing.Point(36, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coelina.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // frmVorschau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 627);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVorschau";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmVorschau_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.TextBox tbxSrienbriefAnhang;
        private System.Windows.Forms.TextBox tbxEmpfänger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxCc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tbxBetreff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbxBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox tbxBcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.Button btnWeiter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDieseNachrichtLöschen;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAnhang1;
        private System.Windows.Forms.TextBox tbxAnhang1;
        private System.Windows.Forms.TextBox tbxAnhang2;
        private System.Windows.Forms.TextBox tbxAnhang3;
    }
}