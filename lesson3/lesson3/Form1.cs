using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson3
{
    public partial class frmlesson3 : Form
    {
        public frmlesson3()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double result = 0;

            errorProvider1.Clear();

            if (txtvalue1.TextLength == 0)
            {
                errorProvider1.SetError(txtvalue1, "please enter value 1");
                return;

            }

            if (txtvalue2.TextLength == 0)
            {
                errorProvider1.SetError(txtvalue2, "please enter value 2");
                return;
            }

            val1 = Convert.ToDouble(txtvalue1.Text);
            val2 = Convert.ToDouble(txtvalue2.Text);


            

            if(chkBoxAdd.Checked==true||chkBoxSub.Checked==true||chkBoxMul.Checked==true||chkBoxDiv.Checked==true)
            {
                if (chkBoxAdd.Checked == true)
                {

                    result = val1 + val2;
                    txtAdd.Text = Convert.ToString(result);
                }

                if (chkBoxSub.Checked == true)
                {

                    result = val1 - val2;
                    txtSub.Text = Convert.ToString(result);
                }

                if (chkBoxMul.Checked == true)
                {

                    result = val1 * val2;
                    txtMul.Text = Convert.ToString(result);
                }

                if (chkBoxDiv.Checked == true)
                {

                    result = val1 / val2;
                    txtDiv.Text = Convert.ToString(result);
                }
            }

            else
            {
                MessageBox.Show("Select check box");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtvalue1.Clear();
            txtvalue2.Clear();
            txtAdd.Clear();
            txtSub.Clear();
            txtMul.Clear();
            txtDiv.Clear();
        }

        private void txtvalue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblvalue2_Click(object sender, EventArgs e)
        {

        }

        private void lblvalue1_Click(object sender, EventArgs e)
        {

        }
    }
}
