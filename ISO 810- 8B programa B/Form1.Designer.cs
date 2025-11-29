namespace ISO_810__8B_programa_B
{
    partial class Form1
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
            lblCedula = new Label();
            pbCheque = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCheque).BeginInit();
            SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(71, 36);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(62, 20);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cédula: ";
            // 
            // pbCheque
            // 
            pbCheque.Location = new Point(96, 88);
            pbCheque.Name = "pbCheque";
            pbCheque.Size = new Size(601, 259);
            pbCheque.SizeMode = PictureBoxSizeMode.Zoom;
            pbCheque.TabIndex = 1;
            pbCheque.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbCheque);
            Controls.Add(lblCedula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCheque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCedula;
        private PictureBox pbCheque;
    }
}
