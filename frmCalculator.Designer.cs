namespace CalculatorApp2
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
            lblResult = new Label();
            btnOperand7 = new Button();
            btnOperand8 = new Button();
            btnOperand9 = new Button();
            btnOperand0 = new Button();
            btnEqual = new Button();
            btnOperand4 = new Button();
            btnOperand5 = new Button();
            btnOperand6 = new Button();
            btnOperatorDiv = new Button();
            btnOperatorMin = new Button();
            btnOperand1 = new Button();
            btnOperand2 = new Button();
            btnOperand3 = new Button();
            btnOperatorMul = new Button();
            btnOperatorPlus = new Button();
            txtResult = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblResult.Location = new Point(27, 36);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(40, 32);
            lblResult.TabIndex = 2;
            lblResult.Text = "00";
            lblResult.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnOperand7
            // 
            btnOperand7.Location = new Point(12, 201);
            btnOperand7.Name = "btnOperand7";
            btnOperand7.Size = new Size(71, 54);
            btnOperand7.TabIndex = 0;
            btnOperand7.Text = "7";
            btnOperand7.UseVisualStyleBackColor = true;
            btnOperand7.Click += NumButtonClick;
            // 
            // btnOperand8
            // 
            btnOperand8.Location = new Point(103, 201);
            btnOperand8.Name = "btnOperand8";
            btnOperand8.Size = new Size(71, 54);
            btnOperand8.TabIndex = 0;
            btnOperand8.Text = "8";
            btnOperand8.UseVisualStyleBackColor = true;
            btnOperand8.Click += NumButtonClick;
            // 
            // btnOperand9
            // 
            btnOperand9.Location = new Point(201, 201);
            btnOperand9.Name = "btnOperand9";
            btnOperand9.Size = new Size(71, 54);
            btnOperand9.TabIndex = 0;
            btnOperand9.Text = "9";
            btnOperand9.UseVisualStyleBackColor = true;
            btnOperand9.Click += NumButtonClick;
            // 
            // btnOperand0
            // 
            btnOperand0.Location = new Point(12, 442);
            btnOperand0.Name = "btnOperand0";
            btnOperand0.Size = new Size(260, 54);
            btnOperand0.TabIndex = 0;
            btnOperand0.Text = "0";
            btnOperand0.UseVisualStyleBackColor = true;
            btnOperand0.Click += NumButtonClick;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(387, 285);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(71, 211);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += ButtonEqualCLick;
            // 
            // btnOperand4
            // 
            btnOperand4.Location = new Point(12, 285);
            btnOperand4.Name = "btnOperand4";
            btnOperand4.Size = new Size(71, 54);
            btnOperand4.TabIndex = 0;
            btnOperand4.Text = "4";
            btnOperand4.UseVisualStyleBackColor = true;
            btnOperand4.Click += NumButtonClick;
            // 
            // btnOperand5
            // 
            btnOperand5.Location = new Point(103, 285);
            btnOperand5.Name = "btnOperand5";
            btnOperand5.Size = new Size(71, 54);
            btnOperand5.TabIndex = 0;
            btnOperand5.Text = "5";
            btnOperand5.UseVisualStyleBackColor = true;
            btnOperand5.Click += NumButtonClick;
            // 
            // btnOperand6
            // 
            btnOperand6.Location = new Point(201, 285);
            btnOperand6.Name = "btnOperand6";
            btnOperand6.Size = new Size(71, 54);
            btnOperand6.TabIndex = 0;
            btnOperand6.Text = "6";
            btnOperand6.UseVisualStyleBackColor = true;
            btnOperand6.Click += NumButtonClick;
            // 
            // btnOperatorDiv
            // 
            btnOperatorDiv.Location = new Point(291, 201);
            btnOperatorDiv.Name = "btnOperatorDiv";
            btnOperatorDiv.Size = new Size(71, 54);
            btnOperatorDiv.TabIndex = 0;
            btnOperatorDiv.Text = "/";
            btnOperatorDiv.UseVisualStyleBackColor = true;
            btnOperatorDiv.Click += OperatorClick;
            // 
            // btnOperatorMin
            // 
            btnOperatorMin.Location = new Point(291, 369);
            btnOperatorMin.Name = "btnOperatorMin";
            btnOperatorMin.Size = new Size(71, 54);
            btnOperatorMin.TabIndex = 0;
            btnOperatorMin.Text = "-";
            btnOperatorMin.UseVisualStyleBackColor = true;
            btnOperatorMin.Click += OperatorClick;
            // 
            // btnOperand1
            // 
            btnOperand1.Location = new Point(12, 369);
            btnOperand1.Name = "btnOperand1";
            btnOperand1.Size = new Size(71, 54);
            btnOperand1.TabIndex = 0;
            btnOperand1.Text = "1";
            btnOperand1.UseVisualStyleBackColor = true;
            btnOperand1.Click += NumButtonClick;
            // 
            // btnOperand2
            // 
            btnOperand2.Location = new Point(103, 369);
            btnOperand2.Name = "btnOperand2";
            btnOperand2.Size = new Size(71, 54);
            btnOperand2.TabIndex = 0;
            btnOperand2.Text = "2";
            btnOperand2.UseVisualStyleBackColor = true;
            btnOperand2.Click += NumButtonClick;
            // 
            // btnOperand3
            // 
            btnOperand3.Location = new Point(201, 369);
            btnOperand3.Name = "btnOperand3";
            btnOperand3.Size = new Size(71, 54);
            btnOperand3.TabIndex = 0;
            btnOperand3.Text = "3";
            btnOperand3.UseVisualStyleBackColor = true;
            btnOperand3.Click += NumButtonClick;
            // 
            // btnOperatorMul
            // 
            btnOperatorMul.Location = new Point(291, 285);
            btnOperatorMul.Name = "btnOperatorMul";
            btnOperatorMul.Size = new Size(71, 54);
            btnOperatorMul.TabIndex = 0;
            btnOperatorMul.Text = "*";
            btnOperatorMul.UseVisualStyleBackColor = true;
            btnOperatorMul.Click += OperatorClick;
            // 
            // btnOperatorPlus
            // 
            btnOperatorPlus.Location = new Point(291, 442);
            btnOperatorPlus.Name = "btnOperatorPlus";
            btnOperatorPlus.Size = new Size(71, 54);
            btnOperatorPlus.TabIndex = 0;
            btnOperatorPlus.Text = "+";
            btnOperatorPlus.UseVisualStyleBackColor = true;
            btnOperatorPlus.Click += OperatorClick;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Yu Gothic UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtResult.Location = new Point(27, 71);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(427, 108);
            txtResult.TabIndex = 1;
            txtResult.TabStop = false;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(387, 201);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 54);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 621);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(txtResult);
            Controls.Add(btnOperatorPlus);
            Controls.Add(btnOperatorMin);
            Controls.Add(btnEqual);
            Controls.Add(btnOperatorMul);
            Controls.Add(btnOperand3);
            Controls.Add(btnOperatorDiv);
            Controls.Add(btnOperand6);
            Controls.Add(btnOperand2);
            Controls.Add(btnOperand0);
            Controls.Add(btnOperand5);
            Controls.Add(btnOperand1);
            Controls.Add(btnOperand9);
            Controls.Add(btnOperand4);
            Controls.Add(btnOperand8);
            Controls.Add(btnOperand7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "電卓";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperand7;
        private Button btnOperand8;
        private Button btnOperand9;
        private Button btnOperand0;
        private Button btnEqual;
        private Button btnOperand4;
        private Button btnOperand5;
        private Button btnOperand6;
        private Button btnOperatorDiv;
        private Button btnOperatorMin;
        private Button btnOperand1;
        private Button btnOperand2;
        private Button btnOperand3;
        private Button btnOperatorMul;
        private Button btnOperatorPlus;
        private TextBox txtResult;
        private Label lblResult;
        private Button btnClear;
    }
}
