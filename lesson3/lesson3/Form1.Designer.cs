namespace lesson3
{
    partial class frmlesson3
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.lblvalue2 = new System.Windows.Forms.Label();
            this.lblvalue1 = new System.Windows.Forms.Label();
            this.chkBoxAdd = new System.Windows.Forms.CheckBox();
            this.chkBoxSub = new System.Windows.Forms.CheckBox();
            this.chkBoxMul = new System.Windows.Forms.CheckBox();
            this.chkBoxDiv = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtMul = new System.Windows.Forms.TextBox();
            this.txtDiv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(157, 297);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(150, 41);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtvalue2
            // 
            this.txtvalue2.Location = new System.Drawing.Point(272, 207);
            this.txtvalue2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.Size = new System.Drawing.Size(196, 31);
            this.txtvalue2.TabIndex = 3;
            this.txtvalue2.TextChanged += new System.EventHandler(this.txtvalue2_TextChanged);
            // 
            // txtvalue1
            // 
            this.txtvalue1.Location = new System.Drawing.Point(272, 67);
            this.txtvalue1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.Size = new System.Drawing.Size(196, 31);
            this.txtvalue1.TabIndex = 1;
            this.txtvalue1.TextChanged += new System.EventHandler(this.txtvalue1_TextChanged);
            // 
            // lblvalue2
            // 
            this.lblvalue2.AutoSize = true;
            this.lblvalue2.Location = new System.Drawing.Point(52, 207);
            this.lblvalue2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblvalue2.Name = "lblvalue2";
            this.lblvalue2.Size = new System.Drawing.Size(74, 23);
            this.lblvalue2.TabIndex = 2;
            this.lblvalue2.Text = "Value &2";
            this.lblvalue2.Click += new System.EventHandler(this.lblvalue2_Click);
            // 
            // lblvalue1
            // 
            this.lblvalue1.AutoSize = true;
            this.lblvalue1.Location = new System.Drawing.Point(52, 73);
            this.lblvalue1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblvalue1.Name = "lblvalue1";
            this.lblvalue1.Size = new System.Drawing.Size(72, 23);
            this.lblvalue1.TabIndex = 0;
            this.lblvalue1.Text = "Value &1";
            this.lblvalue1.Click += new System.EventHandler(this.lblvalue1_Click);
            // 
            // chkBoxAdd
            // 
            this.chkBoxAdd.AutoSize = true;
            this.chkBoxAdd.Location = new System.Drawing.Point(672, 21);
            this.chkBoxAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkBoxAdd.Name = "chkBoxAdd";
            this.chkBoxAdd.Size = new System.Drawing.Size(66, 27);
            this.chkBoxAdd.TabIndex = 4;
            this.chkBoxAdd.Text = "&Add";
            this.chkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // chkBoxSub
            // 
            this.chkBoxSub.AutoSize = true;
            this.chkBoxSub.Location = new System.Drawing.Point(672, 102);
            this.chkBoxSub.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkBoxSub.Name = "chkBoxSub";
            this.chkBoxSub.Size = new System.Drawing.Size(104, 27);
            this.chkBoxSub.TabIndex = 5;
            this.chkBoxSub.Text = "&Subtract";
            this.chkBoxSub.UseVisualStyleBackColor = true;
            // 
            // chkBoxMul
            // 
            this.chkBoxMul.AutoSize = true;
            this.chkBoxMul.Location = new System.Drawing.Point(672, 198);
            this.chkBoxMul.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkBoxMul.Name = "chkBoxMul";
            this.chkBoxMul.Size = new System.Drawing.Size(106, 27);
            this.chkBoxMul.TabIndex = 6;
            this.chkBoxMul.Text = "&Multiply";
            this.chkBoxMul.UseVisualStyleBackColor = true;
            // 
            // chkBoxDiv
            // 
            this.chkBoxDiv.AutoSize = true;
            this.chkBoxDiv.Location = new System.Drawing.Point(672, 300);
            this.chkBoxDiv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkBoxDiv.Name = "chkBoxDiv";
            this.chkBoxDiv.Size = new System.Drawing.Size(88, 27);
            this.chkBoxDiv.TabIndex = 7;
            this.chkBoxDiv.Text = "&Divide";
            this.chkBoxDiv.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(390, 297);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(628, 49);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(196, 31);
            this.txtAdd.TabIndex = 19;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(628, 139);
            this.txtSub.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(196, 31);
            this.txtSub.TabIndex = 20;
            // 
            // txtMul
            // 
            this.txtMul.Location = new System.Drawing.Point(628, 247);
            this.txtMul.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMul.Name = "txtMul";
            this.txtMul.Size = new System.Drawing.Size(196, 31);
            this.txtMul.TabIndex = 21;
            // 
            // txtDiv
            // 
            this.txtDiv.Location = new System.Drawing.Point(628, 333);
            this.txtDiv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDiv.Name = "txtDiv";
            this.txtDiv.Size = new System.Drawing.Size(196, 31);
            this.txtDiv.TabIndex = 22;
            // 
            // frmlesson3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 390);
            this.Controls.Add(this.txtDiv);
            this.Controls.Add(this.txtMul);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkBoxDiv);
            this.Controls.Add(this.chkBoxMul);
            this.Controls.Add(this.chkBoxSub);
            this.Controls.Add(this.chkBoxAdd);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtvalue2);
            this.Controls.Add(this.txtvalue1);
            this.Controls.Add(this.lblvalue2);
            this.Controls.Add(this.lblvalue1);
            this.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmlesson3";
            this.Text = "frmlesson3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.Label lblvalue2;
        private System.Windows.Forms.Label lblvalue1;
        private System.Windows.Forms.CheckBox chkBoxAdd;
        private System.Windows.Forms.CheckBox chkBoxSub;
        private System.Windows.Forms.CheckBox chkBoxMul;
        private System.Windows.Forms.CheckBox chkBoxDiv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDiv;
        private System.Windows.Forms.TextBox txtMul;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtAdd;

    }
}

