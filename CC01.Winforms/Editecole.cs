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
    public partial class Editecole : Form
    {
        public Editecole()
        {
            InitializeComponent();
        }

        private void ecoleajout_Click(object sender, EventArgs e)
        {
            ECOLE edit = new ECOLE();
            edit.Show();
        }

        private void Editecole_Load(object sender, EventArgs e)
        {

        }
    }
}
