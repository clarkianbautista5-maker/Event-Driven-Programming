namespace TrackThread_Bautista
{
    partial class frmTrackThread
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
            btnRun = new Button();
            lblThread = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(97, 119);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(106, 31);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThread.ForeColor = Color.White;
            lblThread.Location = new Point(70, 50);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(159, 30);
            lblThread.TabIndex = 1;
            lblThread.Text = "-Thread Starts-";
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(298, 181);
            Controls.Add(lblThread);
            Controls.Add(btnRun);
            Name = "frmTrackThread";
            Text = "frmTrackThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label lblThread;
    }
}
