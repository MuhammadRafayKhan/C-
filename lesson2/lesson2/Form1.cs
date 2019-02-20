using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson2
{
    public partial class frmlesson2 : Form
    {
        public frmlesson2()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double result = 0;

            errorProvider1.Clear();
            //error provider
            if (txtval1.TextLength == 0)
            {
                errorProvider1.SetError(txtval1, "please enter value 1");
                return;

            }

            if (txtval2.TextLength == 0)
            {
                errorProvider1.SetError(txtval2, "please enter value 2");
                return;
            }

            val1 = Convert.ToDouble(txtval1.Text);
            val2 = Convert.ToDouble(txtval2.Text);

            //radio button
            if(rdbtnAdd.Checked==true)
            {
                result = val1 + val2;
                txtresult.Text = Convert.ToString(result);
            }
            
            if (rdbtnsub.Checked == true)
            {
                result = val1 - val2;
                txtresult.Text = Convert.ToString(result);
            }
            
            if (rdbtnmul.Checked == true)
            {
                result = val1 * val2;
                txtresult.Text = Convert.ToString(result);
            }

            if (rdbtndiv.Checked == true)
            {
                result = val1 / val2;
                txtresult.Text = Convert.ToString(result);
            }
        }
    }
}
