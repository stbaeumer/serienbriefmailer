namespace Coelina
{
    partial class frmVerteiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerteiler));
            this.dgAlias = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kürzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alias4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliasListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListeLöschen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCsvImportVerteiler = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aliasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasListeBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlias
            // 
            this.dgAlias.AutoGenerateColumns = false;
            this.dgAlias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.kürzelDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.alias1DataGridViewTextBoxColumn,
            this.alias2DataGridViewTextBoxColumn,
            this.alias3DataGridViewTextBoxColumn,
            this.alias4DataGridViewTextBoxColumn});
            this.dgAlias.DataSource = this.aliasListeBindingSource;
            this.dgAlias.Location = new System.Drawing.Point(6, 128);
            this.dgAlias.Name = "dgAlias";
            this.dgAlias.Size = new System.Drawing.Size(570, 321);
            this.dgAlias.TabIndex = 5;
            this.dgAlias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlias_CellContentClick);
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kürzelDataGridViewTextBoxColumn
            // 
            this.kürzelDataGridViewTextBoxColumn.DataPropertyName = "Kürzel";
            this.kürzelDataGridViewTextBoxColumn.HeaderText = "Kürzel";
            this.kürzelDataGridViewTextBoxColumn.Name = "kürzelDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // alias1DataGridViewTextBoxColumn
            // 
            this.alias1DataGridViewTextBoxColumn.DataPropertyName = "Alias1";
            this.alias1DataGridViewTextBoxColumn.HeaderText = "Alias1";
            this.alias1DataGridViewTextBoxColumn.Name = "alias1DataGridViewTextBoxColumn";
            // 
            // alias2DataGridViewTextBoxColumn
            // 
            this.alias2DataGridViewTextBoxColumn.DataPropertyName = "Alias2";
            this.alias2DataGridViewTextBoxColumn.HeaderText = "Alias2";
            this.alias2DataGridViewTextBoxColumn.Name = "alias2DataGridViewTextBoxColumn";
            // 
            // alias3DataGridViewTextBoxColumn
            // 
            this.alias3DataGridViewTextBoxColumn.DataPropertyName = "Alias3";
            this.alias3DataGridViewTextBoxColumn.HeaderText = "Alias3";
            this.alias3DataGridViewTextBoxColumn.Name = "alias3DataGridViewTextBoxColumn";
            // 
            // alias4DataGridViewTextBoxColumn
            // 
            this.alias4DataGridViewTextBoxColumn.DataPropertyName = "Alias4";
            this.alias4DataGridViewTextBoxColumn.HeaderText = "Alias4";
            this.alias4DataGridViewTextBoxColumn.Name = "alias4DataGridViewTextBoxColumn";
            // 
            // aliasListeBindingSource
            // 
            //this.aliasListeBindingSource.DataSource = typeof(Coelina.AliasListe);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(66, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(490, 49);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(4, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Optionale Personalisierung";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgAlias);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 455);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 105);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnListeLöschen
            // 
            this.btnListeLöschen.Image = global::Coelina.Properties.Resources.delete;
            this.btnListeLöschen.Location = new System.Drawing.Point(6, 12);
            this.btnListeLöschen.Name = "btnListeLöschen";
            this.btnListeLöschen.Size = new System.Drawing.Size(188, 50);
            this.btnListeLöschen.TabIndex = 8;
            this.btnListeLöschen.UseVisualStyleBackColor = true;
            this.btnListeLöschen.Click += new System.EventHandler(this.btnListeLöschen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCsvImportVerteiler);
            this.groupBox2.Location = new System.Drawing.Point(12, 543);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 68);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CSV-Import";
            // 
            // btnCsvImportVerteiler
            // 
            this.btnCsvImportVerteiler.Image = global::Coelina.Properties.Resources.page_inport;
            this.btnCsvImportVerteiler.Location = new System.Drawing.Point(6, 13);
            this.btnCsvImportVerteiler.Name = "btnCsvImportVerteiler";
            this.btnCsvImportVerteiler.Size = new System.Drawing.Size(158, 50);
            this.btnCsvImportVerteiler.TabIndex = 6;
            this.btnCsvImportVerteiler.UseVisualStyleBackColor = true;
            this.btnCsvImportVerteiler.Click += new System.EventHandler(this.btnCsvImportVerteiler_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListeLöschen);
            this.groupBox3.Location = new System.Drawing.Point(188, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste leeren";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(394, 543);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 68);
            this.groupBox4.TabIndex = 81;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CSV-Export";
            // 
            // button1
            // 
            this.button1.Image = global::Coelina.Properties.Resources.page_export;
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureBox1.Image = global::Coelina.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // aliasBindingSource
            // 
            //this.aliasBindingSource.DataSource = typeof(Coelina.Alias);
            // 
            // frmVerteiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 627);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerteiler";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmVerteiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasListeBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCsvImportVerteiler;
        private System.Windows.Forms.DataGridView dgAlias;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.BindingSource aliasBindingSource;
        private System.Windows.Forms.BindingSource aliasListeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kürzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alias4DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListeLöschen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}