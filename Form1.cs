using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Vitoriano_Victor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool acertou;
            acertou = rdbB.Checked;
            if (acertou)
            {
                MessageBox.Show("Acertou, miserávi!");
            }
            else
            {
                MessageBox.Show("Errou meo!");
            }
        }


    }
}
