namespace ErrorAmplifierCalculator
{
    partial class FormError1
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
            this.PicErrorAmp = new System.Windows.Forms.PictureBox();
            this.PicBodePole = new System.Windows.Forms.PictureBox();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.LabelCrossOverOut = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.BNCalculator = new System.Windows.Forms.Button();
            this.ComboTXTRUnit = new System.Windows.Forms.ComboBox();
            this.TXTR = new System.Windows.Forms.NumericUpDown();
            this.LabelR = new System.Windows.Forms.Label();
            this.ComboCrossOver = new System.Windows.Forms.ComboBox();
            this.LabelCrossOver = new System.Windows.Forms.Label();
            this.ComboTXTSWUnit = new System.Windows.Forms.ComboBox();
            this.TXTSW = new System.Windows.Forms.NumericUpDown();
            this.LabelSF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicErrorAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBodePole)).BeginInit();
            this.GroupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSW)).BeginInit();
            this.SuspendLayout();
            // 
            // PicErrorAmp
            // 
            this.PicErrorAmp.Image = global::ErrorAmplifierCalculator.Properties.Resources.error_amp_01;
            this.PicErrorAmp.Location = new System.Drawing.Point(8, 7);
            this.PicErrorAmp.Margin = new System.Windows.Forms.Padding(2);
            this.PicErrorAmp.Name = "PicErrorAmp";
            this.PicErrorAmp.Size = new System.Drawing.Size(398, 169);
            this.PicErrorAmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicErrorAmp.TabIndex = 0;
            this.PicErrorAmp.TabStop = false;
            // 
            // PicBodePole
            // 
            this.PicBodePole.Image = global::ErrorAmplifierCalculator.Properties.Resources.bode_01;
            this.PicBodePole.Location = new System.Drawing.Point(8, 180);
            this.PicBodePole.Margin = new System.Windows.Forms.Padding(2);
            this.PicBodePole.Name = "PicBodePole";
            this.PicBodePole.Size = new System.Drawing.Size(400, 169);
            this.PicBodePole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBodePole.TabIndex = 1;
            this.PicBodePole.TabStop = false;
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.Controls.Add(this.LabelCrossOverOut);
            this.GroupBoxInput.Controls.Add(this.LabelOutput);
            this.GroupBoxInput.Controls.Add(this.BNCalculator);
            this.GroupBoxInput.Controls.Add(this.ComboTXTRUnit);
            this.GroupBoxInput.Controls.Add(this.TXTR);
            this.GroupBoxInput.Controls.Add(this.LabelR);
            this.GroupBoxInput.Controls.Add(this.ComboCrossOver);
            this.GroupBoxInput.Controls.Add(this.LabelCrossOver);
            this.GroupBoxInput.Controls.Add(this.ComboTXTSWUnit);
            this.GroupBoxInput.Controls.Add(this.TXTSW);
            this.GroupBoxInput.Controls.Add(this.LabelSF);
            this.GroupBoxInput.Location = new System.Drawing.Point(411, 7);
            this.GroupBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxInput.Size = new System.Drawing.Size(393, 128);
            this.GroupBoxInput.TabIndex = 2;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "Input";
            // 
            // LabelCrossOverOut
            // 
            this.LabelCrossOverOut.AutoSize = true;
            this.LabelCrossOverOut.Location = new System.Drawing.Point(254, 48);
            this.LabelCrossOverOut.Name = "LabelCrossOverOut";
            this.LabelCrossOverOut.Size = new System.Drawing.Size(19, 15);
            this.LabelCrossOverOut.TabIndex = 9;
            this.LabelCrossOverOut.Text = "hz";
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(127, 104);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(11, 15);
            this.LabelOutput.TabIndex = 8;
            this.LabelOutput.Text = "f";
            // 
            // BNCalculator
            // 
            this.BNCalculator.Location = new System.Drawing.Point(5, 100);
            this.BNCalculator.Name = "BNCalculator";
            this.BNCalculator.Size = new System.Drawing.Size(75, 23);
            this.BNCalculator.TabIndex = 3;
            this.BNCalculator.Text = "Calculator";
            this.BNCalculator.UseVisualStyleBackColor = true;
            this.BNCalculator.Click += new System.EventHandler(this.BNCalculator_Click);
            // 
            // ComboTXTRUnit
            // 
            this.ComboTXTRUnit.FormattingEnabled = true;
            this.ComboTXTRUnit.Location = new System.Drawing.Point(253, 73);
            this.ComboTXTRUnit.Name = "ComboTXTRUnit";
            this.ComboTXTRUnit.Size = new System.Drawing.Size(134, 23);
            this.ComboTXTRUnit.TabIndex = 7;
            // 
            // TXTR
            // 
            this.TXTR.DecimalPlaces = 2;
            this.TXTR.Location = new System.Drawing.Point(127, 74);
            this.TXTR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TXTR.Name = "TXTR";
            this.TXTR.Size = new System.Drawing.Size(120, 23);
            this.TXTR.TabIndex = 6;
            this.TXTR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelR
            // 
            this.LabelR.AutoSize = true;
            this.LabelR.Location = new System.Drawing.Point(2, 76);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(104, 15);
            this.LabelR.TabIndex = 5;
            this.LabelR.Text = "Feedback Resistor:";
            // 
            // ComboCrossOver
            // 
            this.ComboCrossOver.FormattingEnabled = true;
            this.ComboCrossOver.Location = new System.Drawing.Point(127, 45);
            this.ComboCrossOver.Name = "ComboCrossOver";
            this.ComboCrossOver.Size = new System.Drawing.Size(121, 23);
            this.ComboCrossOver.TabIndex = 4;
            // 
            // LabelCrossOver
            // 
            this.LabelCrossOver.AutoSize = true;
            this.LabelCrossOver.Location = new System.Drawing.Point(2, 48);
            this.LabelCrossOver.Name = "LabelCrossOver";
            this.LabelCrossOver.Size = new System.Drawing.Size(122, 15);
            this.LabelCrossOver.TabIndex = 3;
            this.LabelCrossOver.Text = "CrossOver Frequency:";
            // 
            // ComboTXTSWUnit
            // 
            this.ComboTXTSWUnit.FormattingEnabled = true;
            this.ComboTXTSWUnit.Location = new System.Drawing.Point(254, 16);
            this.ComboTXTSWUnit.Name = "ComboTXTSWUnit";
            this.ComboTXTSWUnit.Size = new System.Drawing.Size(134, 23);
            this.ComboTXTSWUnit.TabIndex = 2;
            // 
            // TXTSW
            // 
            this.TXTSW.Location = new System.Drawing.Point(128, 16);
            this.TXTSW.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TXTSW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TXTSW.Name = "TXTSW";
            this.TXTSW.Size = new System.Drawing.Size(120, 23);
            this.TXTSW.TabIndex = 1;
            this.TXTSW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelSF
            // 
            this.LabelSF.AutoSize = true;
            this.LabelSF.Location = new System.Drawing.Point(2, 18);
            this.LabelSF.Name = "LabelSF";
            this.LabelSF.Size = new System.Drawing.Size(120, 15);
            this.LabelSF.TabIndex = 0;
            this.LabelSF.Text = "Switching Frequency:";
            // 
            // FormError1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 355);
            this.Controls.Add(this.GroupBoxInput);
            this.Controls.Add(this.PicBodePole);
            this.Controls.Add(this.PicErrorAmp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormError1";
            this.Text = "FormError1";
            ((System.ComponentModel.ISupportInitialize)(this.PicErrorAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBodePole)).EndInit();
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PicErrorAmp;
        private PictureBox PicBodePole;
        private GroupBox GroupBoxInput;
        private NumericUpDown TXTSW;
        private Label LabelSF;
        private ComboBox ComboTXTSWUnit;
        private Button BNCalculator;
        private ComboBox ComboCrossOver;
        private Label LabelCrossOver;
        private Label LabelR;
        private NumericUpDown TXTR;
        private ComboBox ComboTXTRUnit;
        private Label LabelOutput;
        private Label LabelCrossOverOut;
    }
}