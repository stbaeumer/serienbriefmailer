namespace Coelina
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serienbriefdateiAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allgemeineEinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serienbriefFelderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verteilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überMontyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serienbriefdateiAuswählenToolStripMenuItem,
            this.allgemeineEinstellungenToolStripMenuItem,
            this.serienbriefFelderToolStripMenuItem,
            this.verteilerToolStripMenuItem,
            this.überMontyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serienbriefdateiAuswählenToolStripMenuItem
            // 
            this.serienbriefdateiAuswählenToolStripMenuItem.Image = global::Coelina.Properties.Resources.pdf_icon;
            this.serienbriefdateiAuswählenToolStripMenuItem.Name = "serienbriefdateiAuswählenToolStripMenuItem";
            this.serienbriefdateiAuswählenToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.serienbriefdateiAuswählenToolStripMenuItem.Text = "Neue Serien-E-Mail";
            this.serienbriefdateiAuswählenToolStripMenuItem.Click += new System.EventHandler(this.serienbriefdateiAuswählenToolStripMenuItem_Click);
            // 
            // allgemeineEinstellungenToolStripMenuItem
            // 
            this.allgemeineEinstellungenToolStripMenuItem.Image = global::Coelina.Properties.Resources.cog1;
            this.allgemeineEinstellungenToolStripMenuItem.Name = "allgemeineEinstellungenToolStripMenuItem";
            this.allgemeineEinstellungenToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.allgemeineEinstellungenToolStripMenuItem.Text = "Einstellungen";
            this.allgemeineEinstellungenToolStripMenuItem.Click += new System.EventHandler(this.allgemeineEinstellungenToolStripMenuItem_Click);
            // 
            // serienbriefFelderToolStripMenuItem
            // 
            this.serienbriefFelderToolStripMenuItem.Image = global::Coelina.Properties.Resources.bbcode;
            this.serienbriefFelderToolStripMenuItem.Name = "serienbriefFelderToolStripMenuItem";
            this.serienbriefFelderToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.serienbriefFelderToolStripMenuItem.Text = "Serienbrief-Felder";
            this.serienbriefFelderToolStripMenuItem.Click += new System.EventHandler(this.serienbriefFelderToolStripMenuItem_Click);
            // 
            // verteilerToolStripMenuItem
            // 
            this.verteilerToolStripMenuItem.Image = global::Coelina.Properties.Resources.user;
            this.verteilerToolStripMenuItem.Name = "verteilerToolStripMenuItem";
            this.verteilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.verteilerToolStripMenuItem.Text = "Alias";
            this.verteilerToolStripMenuItem.Click += new System.EventHandler(this.verteilerToolStripMenuItem_Click);
            // 
            // überMontyToolStripMenuItem
            // 
            this.überMontyToolStripMenuItem.Image = global::Coelina.Properties.Resources.asterisk_orange;
            this.überMontyToolStripMenuItem.Name = "überMontyToolStripMenuItem";
            this.überMontyToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.überMontyToolStripMenuItem.Text = "über Coelina";
            this.überMontyToolStripMenuItem.Click += new System.EventHandler(this.überMontyToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 639);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(627, 678);
            this.MinimumSize = new System.Drawing.Size(627, 678);
            this.Name = "frmMDI";
            this.Text = "Coelina-Serienbrief-Mailer";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem überMontyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serienbriefdateiAuswählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allgemeineEinstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serienbriefFelderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verteilerToolStripMenuItem;
    }
}