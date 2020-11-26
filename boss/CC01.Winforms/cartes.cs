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
        private Carte anciencarte;
        public CARTE()
        {
            InitializeComponent();
        }
        public CARTE( Carte carte , Action callback) :this(callback)
        {
            this.anciencarte = carte;
            textcontact.Text = carte.Contact.ToString();
            textdate.Text = carte.Date_naissance.ToString();
            textemail.Text = carte.Email.ToString();
            textnom.Text = carte.Nom.ToString();
            textmatricule.Text = carte.Matricule.ToString();
            textprenom.Text = carte.Prenom.ToString();
            textlieu.Text = carte.Lieu.ToString();


        }
        public CARTE(Action callback):this()
        {
            this.callback = callback;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkform();
                Carte nouveaucarte = new Carte
                    (
                    textnom.Text,
                    textprenom.Text,
                    textdate.Text,
                    textlieu.Text,
                    textcontact.Text,

                    textmatricule.Text.ToUpper(),
                    textemail.Text

                    ); ;
                CarteBLO carteBLO = new CarteBLO(ConfigurationManager.AppSettings["Dbolder"]);
                if (this.anciencarte == null)

                    carteBLO.createcarte(nouveaucarte);
                else
                    carteBLO.CARTE(anciencarte, nouveaucarte);



                MessageBox.Show(
                    "save done",
                    "confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                    );
                if (callback != null)
                    callback();
                if (anciencarte != null)
                    Close();
                textcontact.Clear();
                textdate.Clear();
                textemail.Clear();
                textlieu.Clear();
                textmatricule.Clear();
                textnom.Clear();
                textprenom.Clear();
                textmatricule.Focus();
            }
            catch (DuplicateNameException ex)
            {
                
                MessageBox.Show(ex.Message,
                    "duplicate error",

                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning

                    );
            }
            catch (KeyNotFoundException ex)
            {

                MessageBox.Show(ex.Message,
                    "not found error",

                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning

                    );
            } 

            catch (MesException ex)
            {
                ex.writetofile();
                MessageBox.Show(ex.Message,
                    "typing",

                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning

                    );
            }

            catch (Exception ex)
            {
                
                    MessageBox.Show(ex.Message,
                        "erreur d'occurence stp ressay encore plustard",

                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information

                        );
            }
           



        }
        private void checkform()
        {
            string text = string.Empty;
            textcontact.BackColor = Color.White;
            textmatricule.BackColor = Color.White;
            textemail.BackColor = Color.White;
            textprenom.BackColor = Color.White;
            textnom.BackColor = Color.White;
            textdate.BackColor = Color.White;
            textlieu.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(textmatricule.Text))
                text+= "svp entrer le matricule !";
            textmatricule.BackColor = Color.Red;

            if (string.IsNullOrWhiteSpace(textemail.Text))
                text += "svp entrer le email !";
            textemail.BackColor = Color.Blue;
            if (string.IsNullOrWhiteSpace(textcontact.Text))
                text += "svp entrer le contact !";
            textcontact.BackColor = Color.Green;
            if (string.IsNullOrWhiteSpace(textdate.Text))
                text += "svp entrer le date de naissance !";
            textdate.BackColor = Color.Pink;
            if (string.IsNullOrWhiteSpace(textlieu.Text))
                text += "svp entrer le lieu de naissance !";
            textlieu.BackColor = Color.Pink;
            if (string.IsNullOrWhiteSpace(textnom.Text))
                text += "svp entrer le nom !";
            textnom.BackColor = Color.Pink;
            if (!string.IsNullOrEmpty(text))
                throw new MesException(text);
           // throw new MesException("please enter the matricule");
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
