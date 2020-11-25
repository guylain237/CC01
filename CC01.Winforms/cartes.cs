using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CC01.BLL;
using CC01.BO;
using System.Configuration;

namespace CC01.Winforms
{
    public partial class CARTE : Form
    {
        private Action callback;
        public CARTE()
        {
            InitializeComponent();
        }
        public CARTE(Action callback):this()
        {
            this.callback = callback;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte
                (
                textnom.Text, 
                textprenom.Text,
                textdate.Text,
                textlieu.Text,
                textcontact.Text,
               
                textmatricule.Text,
                textemail.Text
                
                );
            CarteBLO carteBLO = new CarteBLO(ConfigurationManager.AppSettings["Dbfolder"]);
            carteBLO.createcarte(carte);

            MessageBox.Show(
                "save done",
                "confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information

                );
            if (callback != null)
                callback();
            textcontact.Clear();
            textdate.Clear();
            textemail.Clear();
            textlieu.Clear();
            textmatricule.Clear();
            textnom.Clear();
            textprenom.Clear();
            textmatricule.Focus();

          
        }

        private void ECOLE_Load(object sender, EventArgs e)
        {

        }

        private void buttonphoto_Click(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
