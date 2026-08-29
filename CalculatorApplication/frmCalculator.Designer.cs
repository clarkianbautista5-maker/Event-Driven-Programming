namespace CalculatorApplication
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbOperator = new ComboBox();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            btnEqual = new Button();
            label4 = new Label();
            lblDisplayTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 145);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 2;
            label2.Text = "Answer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 3;
            label3.Text = "Enter Second Number:";
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(234, 62);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(68, 29);
            cbOperator.TabIndex = 4;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(184, 27);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(166, 29);
            txtBoxInput1.TabIndex = 5;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(184, 103);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(166, 29);
            txtBoxInput2.TabIndex = 6;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(206, 195);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(122, 31);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += this.btnEqual_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(186, 154);
            label4.Name = "label4";
            label4.Size = new Size(164, 21);
            label4.TabIndex = 8;
            label4.Text = "______________________";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayTotal.Location = new Point(184, 145);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(65, 21);
            lblDisplayTotal.TabIndex = 9;
            lblDisplayTotal.Text = "Answer:";
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 243);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label4);
            Controls.Add(btnEqual);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(cbOperator);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbOperator;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private Button btnEqual;
        private Label label4;
        private Label lblDisplayTotal;
    }
}
