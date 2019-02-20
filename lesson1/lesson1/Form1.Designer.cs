namespace lesson1
{
    partial class frmlesson1
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
            this.lblvalue1 = new System.Windows.Forms.Label();
            this.lblvalue2 = new System.Windows.Forms.Label();
            this.lblvalueresult = new System.Windows.Forms.Label();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.txtvalueresult = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvalue1
            // 
            this.lblvalue1.AutoSize = true;
            this.lblvalue1.Location = new System.Drawing.Point(23, 27);
            this.lblvalue1.Name = "lblvalue1";
            this.lblvalue1.Size = new System.Drawing.Size(43, 13);
            this.lblvalue1.TabIndex = 0;
            this.lblvalue1.Text = "Value &1";
            this.lblvalue1.Click += new System.EventHandler(this.lblvalue1_Click);
            // 
            // lblvalue2
            // 
            this.lblvalue2.AutoSize = true;
            this.lblvalue2.Location = new System.Drawing.Point(23, 103);
            this.lblvalue2.Name = "lblvalue2";
            this.lblvalue2.Size = new System.Drawing.Size(43, 13);
            this.lblvalue2.TabIndex = 2;
            this.lblvalue2.Text = "Value &2";
            this.lblvalue2.Click += new System.EventHandler(this.lblvalue2_Click);
            // 
            // lblvalueresult
            // 
            this.lblvalueresult.AutoSize = true;
            this.lblvalueresult.Location = new System.Drawing.Point(23, 266);
            this.lblvalueresult.Name = "lblvalueresult";
            this.lblvalueresult.Size = new System.Drawing.Size(37, 13);
            this.lblvalueresult.TabIndex = 6;
            this.lblvalueresult.Text = "&Result";
            this.lblvalueresult.Click += new System.EventHandler(this.lblvalueresult_Click);
            // 
            // txtvalue1
            // 
            this.txtvalue1.Location = new System.Drawing.Point(133, 24);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.Size = new System.Drawing.Size(100, 20);
            this.txtvalue1.TabIndex = 1;
            this.txtvalue1.TextChanged += new System.EventHandler(this.txtvalue1_TextChanged);
            // 
            // txtvalue2
            // 
            this.txtvalue2.Location = new System.Drawing.Point(133, 103);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.Size = new System.Drawing.Size(100, 20);
            this.txtvalue2.TabIndex = 3;
            this.txtvalue2.TextChanged += new System.EventHandler(this.txtvalue2_TextChanged);
            // 
            // txtvalueresult
            // 
            this.txtvalueresult.Location = new System.Drawing.Point(133, 259);
            this.txtvalueresult.Name = "txtvalueresult";
            this.txtvalueresult.Size = new System.Drawing.Size(100, 20);
            this.txtvalueresult.TabIndex = 7;
            this.txtvalueresult.TextChanged += new System.EventHandler(this.txtvalueresult_TextChanged);
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(74, 178);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(75, 23);
            this.btnresult.TabIndex = 4;
            this.btnresult.Text = "&Add";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(306, 178);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmlesson1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtvalueresult);
            this.Controls.Add(this.txtvalue2);
            this.Controls.Add(this.txtvalue1);
            this.Controls.Add(this.lblvalueresult);
            this.Controls.Add(this.lblvalue2);
            this.Controls.Add(this.lblvalue1);
            this.Name = "frmlesson1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalue1;
        private System.Windows.Forms.Label lblvalue2;
        private System.Windows.Forms.Label lblvalueresult;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.TextBox txtvalueresult;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

