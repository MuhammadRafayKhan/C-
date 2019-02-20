namespace lesson2
{
    partial class frmlesson2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblval1 = new System.Windows.Forms.Label();
            this.lblval2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.rdbtnAdd = new System.Windows.Forms.RadioButton();
            this.rdbtnsub = new System.Windows.Forms.RadioButton();
            this.rdbtndiv = new System.Windows.Forms.RadioButton();
            this.rdbtnmul = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblval1
            // 
            this.lblval1.AutoSize = true;
            this.lblval1.Location = new System.Drawing.Point(0, 0);
            this.lblval1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblval1.Name = "lblval1";
            this.lblval1.Size = new System.Drawing.Size(73, 21);
            this.lblval1.TabIndex = 0;
            this.lblval1.Text = "Value &1";
            // 
            // lblval2
            // 
            this.lblval2.AutoSize = true;
            this.lblval2.Location = new System.Drawing.Point(0, 87);
            this.lblval2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblval2.Name = "lblval2";
            this.lblval2.Size = new System.Drawing.Size(67, 21);
            this.lblval2.TabIndex = 2;
            this.lblval2.Text = "value &2";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(5, 225);
            this.lblresult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(62, 21);
            this.lblresult.TabIndex = 9;
            this.lblresult.Text = "&Result";
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(101, 0);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(100, 29);
            this.txtval1.TabIndex = 1;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(101, 87);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(100, 29);
            this.txtval2.TabIndex = 3;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(106, 214);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 29);
            this.txtresult.TabIndex = 10;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(101, 148);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(100, 36);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // rdbtnAdd
            // 
            this.rdbtnAdd.AutoSize = true;
            this.rdbtnAdd.Location = new System.Drawing.Point(310, 22);
            this.rdbtnAdd.Name = "rdbtnAdd";
            this.rdbtnAdd.Size = new System.Drawing.Size(61, 25);
            this.rdbtnAdd.TabIndex = 4;
            this.rdbtnAdd.TabStop = true;
            this.rdbtnAdd.Text = "&Add";
            this.rdbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rdbtnsub
            // 
            this.rdbtnsub.AutoSize = true;
            this.rdbtnsub.Location = new System.Drawing.Point(310, 63);
            this.rdbtnsub.Name = "rdbtnsub";
            this.rdbtnsub.Size = new System.Drawing.Size(95, 25);
            this.rdbtnsub.TabIndex = 5;
            this.rdbtnsub.TabStop = true;
            this.rdbtnsub.Text = "&Subtract";
            this.rdbtnsub.UseVisualStyleBackColor = true;
            // 
            // rdbtndiv
            // 
            this.rdbtndiv.AutoSize = true;
            this.rdbtndiv.Location = new System.Drawing.Point(310, 107);
            this.rdbtndiv.Name = "rdbtndiv";
            this.rdbtndiv.Size = new System.Drawing.Size(82, 25);
            this.rdbtndiv.TabIndex = 6;
            this.rdbtndiv.TabStop = true;
            this.rdbtndiv.Text = "&Divide";
            this.rdbtndiv.UseVisualStyleBackColor = true;
            // 
            // rdbtnmul
            // 
            this.rdbtnmul.AutoSize = true;
            this.rdbtnmul.Location = new System.Drawing.Point(310, 148);
            this.rdbtnmul.Name = "rdbtnmul";
            this.rdbtnmul.Size = new System.Drawing.Size(100, 25);
            this.rdbtnmul.TabIndex = 7;
            this.rdbtnmul.TabStop = true;
            this.rdbtnmul.Text = "&Multiply";
            this.rdbtnmul.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmlesson2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 255);
            this.Controls.Add(this.rdbtnmul);
            this.Controls.Add(this.rdbtndiv);
            this.Controls.Add(this.rdbtnsub);
            this.Controls.Add(this.rdbtnAdd);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblval2);
            this.Controls.Add(this.lblval1);
            this.Font = new System.Drawing.Font("Centaur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmlesson2";
            this.Text = "frmlesson2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblval1;
        private System.Windows.Forms.Label lblval2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.RadioButton rdbtnAdd;
        private System.Windows.Forms.RadioButton rdbtnsub;
        private System.Windows.Forms.RadioButton rdbtndiv;
        private System.Windows.Forms.RadioButton rdbtnmul;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

