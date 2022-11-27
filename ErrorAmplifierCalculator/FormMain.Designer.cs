namespace ErrorAmplifierCalculator
{
    partial class FormMain
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
            this.BNError1 = new System.Windows.Forms.Button();
            this.BNError2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNError1
            // 
            this.BNError1.Location = new System.Drawing.Point(12, 12);
            this.BNError1.Name = "BNError1";
            this.BNError1.Size = new System.Drawing.Size(75, 23);
            this.BNError1.TabIndex = 0;
            this.BNError1.Text = "Error1";
            this.BNError1.UseVisualStyleBackColor = true;
            this.BNError1.Click += new System.EventHandler(this.BNError1_Click);
            // 
            // BNError2
            // 
            this.BNError2.Location = new System.Drawing.Point(93, 12);
            this.BNError2.Name = "BNError2";
            this.BNError2.Size = new System.Drawing.Size(75, 23);
            this.BNError2.TabIndex = 1;
            this.BNError2.Text = "Error2";
            this.BNError2.UseVisualStyleBackColor = true;
            this.BNError2.Click += new System.EventHandler(this.BNError2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BNError2);
            this.Controls.Add(this.BNError1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BNError1;
        private Button BNError2;
    }
}