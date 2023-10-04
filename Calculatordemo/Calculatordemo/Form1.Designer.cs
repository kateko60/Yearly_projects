namespace Calculatordemo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.rdbuttonadd = new System.Windows.Forms.RadioButton();
            this.rdbuttondivide = new System.Windows.Forms.RadioButton();
            this.rdbuttonsub = new System.Windows.Forms.RadioButton();
            this.rdbuttonmultiply = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CalculatorDemo";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(307, 56);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(158, 20);
            this.txtnumber1.TabIndex = 1;
            this.txtnumber1.Text = "Enter number";
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(307, 93);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(158, 20);
            this.txtnumber2.TabIndex = 2;
            this.txtnumber2.Text = "Enter number";
            // 
            // rdbuttonadd
            // 
            this.rdbuttonadd.AutoSize = true;
            this.rdbuttonadd.Location = new System.Drawing.Point(309, 136);
            this.rdbuttonadd.Name = "rdbuttonadd";
            this.rdbuttonadd.Size = new System.Drawing.Size(87, 17);
            this.rdbuttonadd.TabIndex = 3;
            this.rdbuttonadd.TabStop = true;
            this.rdbuttonadd.Text = "Add numbers";
            this.rdbuttonadd.UseVisualStyleBackColor = true;
            // 
            // rdbuttondivide
            // 
            this.rdbuttondivide.AutoSize = true;
            this.rdbuttondivide.Location = new System.Drawing.Point(310, 182);
            this.rdbuttondivide.Name = "rdbuttondivide";
            this.rdbuttondivide.Size = new System.Drawing.Size(98, 17);
            this.rdbuttondivide.TabIndex = 4;
            this.rdbuttondivide.TabStop = true;
            this.rdbuttondivide.Text = "Divide numbers";
            this.rdbuttondivide.UseVisualStyleBackColor = true;
            // 
            // rdbuttonsub
            // 
            this.rdbuttonsub.AutoSize = true;
            this.rdbuttonsub.Location = new System.Drawing.Point(310, 159);
            this.rdbuttonsub.Name = "rdbuttonsub";
            this.rdbuttonsub.Size = new System.Drawing.Size(108, 17);
            this.rdbuttonsub.TabIndex = 5;
            this.rdbuttonsub.TabStop = true;
            this.rdbuttonsub.Text = "Subtract numbers";
            this.rdbuttonsub.UseVisualStyleBackColor = true;
            // 
            // rdbuttonmultiply
            // 
            this.rdbuttonmultiply.AutoSize = true;
            this.rdbuttonmultiply.Location = new System.Drawing.Point(310, 205);
            this.rdbuttonmultiply.Name = "rdbuttonmultiply";
            this.rdbuttonmultiply.Size = new System.Drawing.Size(103, 17);
            this.rdbuttonmultiply.TabIndex = 6;
            this.rdbuttonmultiply.TabStop = true;
            this.rdbuttonmultiply.Text = "Multiply numbers";
            this.rdbuttonmultiply.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(130, 326);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbuttonmultiply);
            this.Controls.Add(this.rdbuttonsub);
            this.Controls.Add(this.rdbuttondivide);
            this.Controls.Add(this.rdbuttonadd);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.RadioButton rdbuttonadd;
        private System.Windows.Forms.RadioButton rdbuttondivide;
        private System.Windows.Forms.RadioButton rdbuttonsub;
        private System.Windows.Forms.RadioButton rdbuttonmultiply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOutput;
    }
}

