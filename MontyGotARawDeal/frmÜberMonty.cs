using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coelina
{
    public partial class frmÜberMonty : Form
    {
        public frmÜberMonty()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress m = new MailAddress(tbxMeineMail.Text);
                tbxMeineMail.BackColor = System.Drawing.Color.White;
                Nachricht MailToTheEditor = new Nachricht();
                MailToTheEditor.versenden(Properties.Settings.Default.absender, "", "", "Eine Nachricht von Coelina!", tbxMailToTheEditor.Text + "\n\n" + tbxMeineMail.Text , "", "", "", "");
                MessageBox.Show("Danke für Ihre Nachricht.");
            }
            catch
            {
                tbxMeineMail.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Geben Sie IHRE E-Mail-Adresse an.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://coelina.de");
        }

        private void frmÜberMonty_Load(object sender, EventArgs e)
        {
            
        }
    }
}
