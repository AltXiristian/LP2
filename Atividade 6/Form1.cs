using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class PrettyCalc97 : Form
    {
        double num1, num2, reslt;

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtn1.Text, out num1) || !double.TryParse(txtn2.Text, out num2))
                MessageBox.Show("Valores Invalidos");

            else
            {
                reslt = num1 - num2;
                txtR.Text = reslt.ToString("N2");
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtn1.Text, out num1) || !double.TryParse(txtn2.Text, out num2))
                MessageBox.Show("Valores Invalidos");

            else
            {
                reslt = num1 * num2;
                txtR.Text = reslt.ToString("N2");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtn1.Text, out num1) && double.TryParse(txtn2.Text, out num2))
                if (num2 == 0)
                {
                    MessageBox.Show("Não é possivel dividir por 0!");
                }
            else
                { reslt = num1 / num2;
                    txtR.Text = reslt.ToString("N2");
                }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtR.Clear();
            txtn1.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public PrettyCalc97()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtn1.Text, out num1) || !double.TryParse(txtn1.Text, out num2))
                MessageBox.Show("Valores Invalidos");

            else
            {
                reslt = num1 + num2;
                txtR.Text = reslt.ToString("N2");
            }   
                    

        }
    }
}
