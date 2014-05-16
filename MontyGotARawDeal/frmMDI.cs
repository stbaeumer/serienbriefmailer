using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        
        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmSerienbriefdateiWählen frm = new frmSerienbriefdateiWählen();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        

        private void serienbriefdateiAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSerienbriefdateiWählen frm = new frmSerienbriefdateiWählen();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();        
        }

        //private void serienbriefErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmSerienbriefEntwurfErzeugen frm = new frmSerienbriefEntwurfErzeugen();
        //    frm.MdiParent = this;
        //    frm.WindowState = FormWindowState.Maximized;
        //    frm.Show();

        //}

        //private void eMailEinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmMailEinstellungen frm = new frmMailEinstellungen();
        //    frm.MdiParent = this;
        //    frm.WindowState = FormWindowState.Maximized;
        //    frm.Show();
        //}

        private void allgemeineEinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllgemeineEinstellungen frm = new frmAllgemeineEinstellungen();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void serienbriefFelderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSerienbriefFelder frm = new frmSerienbriefFelder();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void verteilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerteiler frm = new frmVerteiler();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void überMontyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÜberMonty frm = new frmÜberMonty();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vorschauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.neuesteDatei == "")
            {
                MessageBox.Show("Wählen Sie eine Serienbriefdatei oder ein Verzeichnis um zu Schritt 2 zu kommen.", "Coelina");
                return;
            }
            
            frmVorschau frm = new frmVorschau();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        //private void eMailEinstellungenToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    if (Properties.Settings.Default.neuesteDatei == "")
        //    {
        //        MessageBox.Show("Wählen Sie eine Serienbriefdatei oder ein Verzeichnis um zu Schritt 2 zu kommen.", "Monty Got A Raw Deal");
        //        return;
        //    }
            
        //    frmMailEinstellungen frm = new frmMailEinstellungen();
        //    frm.MdiParent = this;
        //    frm.WindowState = FormWindowState.Maximized;
        //    frm.Show();
        //}

        //private void serienbriefErstellenToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    if (Properties.Settings.Default.neuesteDatei == "")
        //    {
        //        MessageBox.Show("Wählen Sie eine Serienbriefdatei oder ein Verzeichnis um zu Schritt 2 zu kommen.", "Monty Got A Raw Deal");
        //        return;
        //    }
        //    if (Properties.Settings.Default.absender == "" || Properties.Settings.Default.smtpServer == "" || Properties.Settings.Default.smtpPort == 0 || Properties.Settings.Default.mailPassword == "")
        //    {
        //        MessageBox.Show("Geben Sie die vollständigen eMail-Einstellungen ein.");
        //        return;
        //    }
        //    frmSerienbriefEntwurfErzeugen frm = new frmSerienbriefEntwurfErzeugen();
        //    frm.MdiParent = this;
        //    frm.WindowState = FormWindowState.Maximized;
        //    frm.Show();
        //}

        private void vorschauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.neuesteDatei == "")
            {
                MessageBox.Show("Wählen Sie eine Serienbriefdatei oder ein Verzeichnis um zu Schritt 2 zu kommen.", "Monty Got A Raw Deal");
                return;
            }
            if (Properties.Settings.Default.absender == "" || Properties.Settings.Default.smtpServer == "" || Properties.Settings.Default.smtpPort == 0 || Properties.Settings.Default.mailPassword == "")
            {
                MessageBox.Show("Geben Sie die vollständigen eMail-Einstellungen ein.");
                return;
            }
            frmVorschau frm = new frmVorschau();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void logdateiAnsehenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.neuesteDatei == "")
            {
                MessageBox.Show("Wählen Sie eine Serienbriefdatei oder ein Verzeichnis um zu Schritt 2 zu kommen.", "Monty Got A Raw Deal");
                return;
            }
            if (Properties.Settings.Default.absender == "" || Properties.Settings.Default.smtpServer == "" || Properties.Settings.Default.smtpPort == 0 || Properties.Settings.Default.mailPassword == "")
            {
                MessageBox.Show("Geben Sie die vollständigen eMail-Einstellungen ein.");
                return;
            }
            frmVorschau frm = new frmVorschau();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void serienbriefdateiWählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSerienbriefdateiWählen frm = new frmSerienbriefdateiWählen();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
