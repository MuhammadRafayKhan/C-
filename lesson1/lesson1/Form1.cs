using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson1
{
    public partial class frmlesson1 : Form
    {
        public frmlesson1()
        {
            InitializeComponent();
        }

        private void txtvalue1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double result = 0;

            errorProvider1.Clear();
             
            if (txtvalue1.TextLength == 0 )
            {
                errorProvider1.SetError(txtvalue1,"please enter value 1");
                return;

            }

            if (txtvalue2.TextLength == 0)
            {
                errorProvider1.SetError(txtvalue2, "please enter value 2");
                return;
            }

            val1 = Convert.ToDouble(txtvalue1.Text);
            val2 = Convert.ToDouble(txtvalue2.Text);

            result = val1 + val2;

            txtvalueresult.Text = Convert.ToString(result);

        }

        private void txtvalueresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblvalueresult_Click(object sender, EventArgs e)
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
