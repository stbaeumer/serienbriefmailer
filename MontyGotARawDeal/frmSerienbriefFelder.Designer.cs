namespace Coelina
{
    partial class frmSerienbriefFelder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerienbriefFelder));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBegrenzer2 = new System.Windows.Forms.TextBox();
            this.tbxBegrenzer1 = new System.Windows.Forms.TextBox();
            this.tbxRegExBeschreibung = new System.Windows.Forms.TextBox();
            this.tbxRegExDefinition = new System.Windows.Forms.TextBox();
            this.cbxRegExName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegExFeldImportieren = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRegExExportieren = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Location = new System.Drawing.Point(66, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 49);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(4, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(425, 22);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sie können (eigene) reguläre Ausdrücke verwenden";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbxBegrenzer2);
            this.groupBox4.Controls.Add(this.tbxBegrenzer1);
            this.groupBox4.Controls.Add(this.tbxRegExBeschreibung);
            this.groupBox4.Controls.Add(this.tbxRegExDefinition);
            this.groupBox4.Controls.Add(this.cbxRegExName);
            this.groupBox4.Location = new System.Drawing.Point(12, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(588, 455);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reguläre Ausdrücke bearbeiten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Regulärer \r\nAusdruck";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Geben Sie den Regulären Ausdruck an, nach dem die Datei durchsucht werden soll. \r" +
    "\nOptional können Sie mit den beiden Begrenzern die Stelle einkreisen, an der ges" +
    "ucht werden soll. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Begrenzer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Begrenzer";
            // 
            // tbxBegrenzer2
            // 
            this.tbxBegrenzer2.Location = new System.Drawing.Point(113, 380);
            this.tbxBegrenzer2.Name = "tbxBegrenzer2";
            this.tbxBegrenzer2.Size = new System.Drawing.Size(447, 20);
            this.tbxBegrenzer2.TabIndex = 4;
            this.tbxBegrenzer2.TextChanged += new System.EventHandler(this.tbxBegrenzer2_TextChanged);
            // 
            // tbxBegrenzer1
            // 
            this.tbxBegrenzer1.Location = new System.Drawing.Point(113, 302);
            this.tbxBegrenzer1.Name = "tbxBegrenzer1";
            this.tbxBegrenzer1.Size = new System.Drawing.Size(447, 20);
            this.tbxBegrenzer1.TabIndex = 3;
            this.tbxBegrenzer1.TextChanged += new System.EventHandler(this.tbxBegrenzer1_TextChanged);
            // 
            // tbxRegExBeschreibung
            // 
            this.tbxRegExBeschreibung.Location = new System.Drawing.Point(23, 56);
            this.tbxRegExBeschreibung.Multiline = true;
            this.tbxRegExBeschreibung.Name = "tbxRegExBeschreibung";
            this.tbxRegExBeschreibung.Size = new System.Drawing.Size(537, 183);
            this.tbxRegExBeschreibung.TabIndex = 1;
            this.tbxRegExBeschreibung.TextChanged += new System.EventHandler(this.tbxRegExBeschreibung_TextChanged);
            // 
            // tbxRegExDefinition
            // 
            this.tbxRegExDefinition.Location = new System.Drawing.Point(113, 328);
            this.tbxRegExDefinition.Multiline = true;
            this.tbxRegExDefinition.Name = "tbxRegExDefinition";
            this.tbxRegExDefinition.Size = new System.Drawing.Size(447, 46);
            this.tbxRegExDefinition.TabIndex = 2;
            this.tbxRegExDefinition.TextChanged += new System.EventHandler(this.tbxRegExDefinition_TextChanged);
            // 
            // cbxRegExName
            // 
            this.cbxRegExName.FormattingEnabled = true;
            this.cbxRegExName.Items.AddRange(new object[] {
            "<<mail>>"});
            this.cbxRegExName.Location = new System.Drawing.Point(23, 27);
            this.cbxRegExName.Name = "cbxRegExName";
            this.cbxRegExName.Size = new System.Drawing.Size(537, 21);
            this.cbxRegExName.TabIndex = 0;
            this.cbxRegExName.SelectedIndexChanged += new System.EventHandler(this.cbxRegExName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(448, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alles auf Anfang";
            // 
            // button1
            // 
            this.button1.Image = global::Coelina.Properties.Resources.arrow_refresh;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(286, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 75);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regulären Ausdruck testen";
            // 
            // button2
            // 
            this.button2.Image = global::Coelina.Properties.Resources.flag_green;
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 48);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRegExFeldImportieren);
            this.groupBox3.Location = new System.Drawing.Point(149, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 75);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Felder Importieren";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnRegExFeldImportieren
            // 
            this.btnRegExFeldImportieren.Image = global::Coelina.Properties.Resources.page_white_inport;
            this.btnRegExFeldImportieren.Location = new System.Drawing.Point(6, 19);
            this.btnRegExFeldImportieren.Name = "btnRegExFeldImportieren";
            this.btnRegExFeldImportieren.Size = new System.Drawing.Size(119, 48);
            this.btnRegExFeldImportieren.TabIndex = 4;
            this.btnRegExFeldImportieren.UseVisualStyleBackColor = true;
            this.btnRegExFeldImportieren.Click += new System.EventHandler(this.btnRegExFeldImportieren_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRegExExportieren);
            this.groupBox6.Location = new System.Drawing.Point(12, 543);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 75);
            this.groupBox6.TabIndex = 81;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Felder Exportieren";
            // 
            // btnRegExExportieren
            // 
            this.btnRegExExportieren.Image = global::Coelina.Properties.Resources.page_white_export;
            this.btnRegExExportieren.Location = new System.Drawing.Point(6, 19);
            this.btnRegExExportieren.Name = "btnRegExExportieren";
            this.btnRegExExportieren.Size = new System.Drawing.Size(119, 48);
            this.btnRegExExportieren.TabIndex = 5;
            this.btnRegExExportieren.UseVisualStyleBackColor = true;
            this.btnRegExExportieren.Click += new System.EventHandler(this.btnRegExExportieren_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Coelina.Properties.Resources.infomation1;
            this.pictureBox4.Location = new System.Drawing.Point(562, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 78;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coelina.Properties.Resources.bbcode1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmSerienbriefFelder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 627);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSerienbriefFelder";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmSerienbriefFelder_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRegExExportieren;
        private System.Windows.Forms.Button btnRegExFeldImportieren;
        private System.Windows.Forms.TextBox tbxRegExBeschreibung;
        private System.Windows.Forms.TextBox tbxRegExDefinition;
        private System.Windows.Forms.ComboBox cbxRegExName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbxBegrenzer2;
        private System.Windows.Forms.TextBox tbxBegrenzer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}