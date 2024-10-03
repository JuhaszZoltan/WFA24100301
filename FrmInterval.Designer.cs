namespace WFA24100301
{
    partial class FrmInterval
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
            lblUI01 = new Label();
            nudMin = new NumericUpDown();
            lblUI02 = new Label();
            nudMax = new NumericUpDown();
            lblUI03 = new Label();
            nudNumber = new NumericUpDown();
            btnDetermine = new Button();
            lblStatement = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumber).BeginInit();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(40, 21);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "min:";
            // 
            // nudMin
            // 
            nudMin.Location = new Point(12, 33);
            nudMin.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMin.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudMin.Name = "nudMin";
            nudMin.Size = new Size(109, 29);
            nudMin.TabIndex = 1;
            nudMin.TextAlign = HorizontalAlignment.Right;
            nudMin.Value = new decimal(new int[] { 20, 0, 0, int.MinValue });
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(197, 9);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(42, 21);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "max:";
            // 
            // nudMax
            // 
            nudMax.Location = new Point(197, 33);
            nudMax.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudMax.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudMax.Name = "nudMax";
            nudMax.Size = new Size(109, 29);
            nudMax.TabIndex = 1;
            nudMax.TextAlign = HorizontalAlignment.Right;
            nudMax.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 65);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(68, 21);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "number:";
            // 
            // nudNumber
            // 
            nudNumber.Location = new Point(12, 89);
            nudNumber.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudNumber.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudNumber.Name = "nudNumber";
            nudNumber.Size = new Size(109, 29);
            nudNumber.TabIndex = 1;
            nudNumber.TextAlign = HorizontalAlignment.Right;
            nudNumber.Value = new decimal(new int[] { 26, 0, 0, 0 });
            // 
            // btnDetermine
            // 
            btnDetermine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDetermine.Location = new Point(169, 82);
            btnDetermine.Name = "btnDetermine";
            btnDetermine.Size = new Size(137, 36);
            btnDetermine.TabIndex = 2;
            btnDetermine.Text = "determine";
            btnDetermine.UseVisualStyleBackColor = true;
            // 
            // lblStatement
            // 
            lblStatement.AutoSize = true;
            lblStatement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatement.Location = new Point(12, 131);
            lblStatement.Name = "lblStatement";
            lblStatement.Size = new Size(192, 21);
            lblStatement.TabIndex = 0;
            lblStatement.Text = "###placeholder_text###";
            // 
            // FrmInterval
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 171);
            Controls.Add(btnDetermine);
            Controls.Add(nudMax);
            Controls.Add(lblUI02);
            Controls.Add(nudNumber);
            Controls.Add(lblStatement);
            Controls.Add(lblUI03);
            Controls.Add(nudMin);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmInterval";
            Text = "Interval";
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private NumericUpDown nudMin;
        private Label lblUI02;
        private NumericUpDown nudMax;
        private Label lblUI03;
        private NumericUpDown nudNumber;
        private Button btnDetermine;
        private Label lblStatement;
    }
}
