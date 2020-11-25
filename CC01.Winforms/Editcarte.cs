using CC01.BLL;
using CC01.BO;
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
        private void loadata(IEnumerable<Carte> cartes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cartes;
            count.Text = $"{dataGridView1.RowCount}rows";
            dataGridView1.ClearSelection();
                                       
                       

        }

        private void buttonajout_Click(object sender, EventArgs e)
        {
            CARTE c = new CARTE();
            c.Show();
        }

        private void buttonmodif_Click(object sender, EventArgs e)
        {

        }
private void Editcarte_Load(object sender, EventArgs e)
        {

            loadata(carteBLO.getallcarte());


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
          //  string value = textsearch.Text.ToLower();
          //var cartes =  carteBLO.getby(
          //      x =>
          //      x.Matricule
          //                 .Contains(value) ||
          //      x.Nom.Contains(value)


          //      );
          //  loadata(cartes);
        }
    }
    }

