using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.Winforms
{
    public partial class PARENT : Form
    {
        public PARENT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editcarte edit = new Editcarte();
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editecole ecole = new Editecole();
            ecole.Show();
        }

        private void PARENT_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
