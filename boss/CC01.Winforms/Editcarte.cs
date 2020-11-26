using CC01.BLL;
using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CC01.Winforms
{
    public partial class Editcarte : Form
    {

        private CarteBLO carteBLO;
        public Editcarte()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            carteBLO = new CarteBLO(ConfigurationManager.AppSettings["DbFolder"]);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadata()
        {
            
            string value = textsearch.Text.ToLower();
            var cartes = carteBLO.getby(
                 
               
               X =>
                  X.Matricule.ToLower().Contains(value)

                  ).OrderBy(X => X.Contact).ToArray();
            {
                dataGridView1.DataSource = cartes;
                count.Text = $"{dataGridView1.RowCount}rows";

                dataGridView1.DataSource = null;

                dataGridView1.ClearSelection();
            }


        }

        private void buttonajout_Click(object sender, EventArgs e)
        {
            CARTE c = new CARTE(loadata);
            c.Show();
        }

        private void buttonmodif_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form m = new CARTE(
  dataGridView1.SelectedRows[i].DataBoundItem as Carte,
  loadata
                      );
                    m.ShowDialog();

                }
            }
        }
        private void Editcarte_Load(object sender, EventArgs e)
        {

            loadata();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

            loadata();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonmodif_Click(sender, e);

        }

        private void buttonsupprim_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            { if(MessageBox.Show(
                "voulez-vous vraiment supprimer cette carte",
                "alerte",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) ==DialogResult.Yes
                )
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    carteBLO.deletecarte(dataGridView1.SelectedRows[i].DataBoundItem as Carte);

                }
                loadata();

            }
        }

        private void buttonimage_Click(object sender, EventArgs e)
        {

        }
    }
    }

