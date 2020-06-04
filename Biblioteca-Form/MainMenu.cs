//Agheorghiesei Madalina, grupa 3123A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Form
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mtCarti_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCarti = new Form1();
            formCarti.Closed += (s, args) => this.Close();
            formCarti.Show();
        }

        private void mtCititori_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCarti = new FormaCititori();
            formCarti.Closed += (s, args) => this.Close();
            formCarti.Show();
        }
    }
}
