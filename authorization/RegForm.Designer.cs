namespace authorization
{
    partial class RegForm
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
            textBoxLogReg = new TextBox();
            textBoxPassReg = new TextBox();
            buttonReg = new Button();
            resultLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxLogReg
            // 
            textBoxLogReg.Location = new Point(12, 43);
            textBoxLogReg.Name = "textBoxLogReg";
            textBoxLogReg.Size = new Size(218, 23);
            textBoxLogReg.TabIndex = 0;
            // 
            // textBoxPassReg
            // 
            textBoxPassReg.Location = new Point(12, 89);
            textBoxPassReg.Name = "textBoxPassReg";
            textBoxPassReg.Size = new Size(218, 23);
            textBoxPassReg.TabIndex = 1;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(74, 118);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(95, 23);
            buttonReg.TabIndex = 2;
            buttonReg.Text = "Регистрация";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            buttonReg.MouseDown += buttonReg_MouseDown;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.ImageAlign = ContentAlignment.BottomRight;
            resultLabel.Location = new Point(64, 164);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 7;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 8;
            label2.Text = "Пароль:";
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 236);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(buttonReg);
            Controls.Add(textBoxPassReg);
            Controls.Add(textBoxLogReg);
            MaximumSize = new Size(260, 275);
            MinimumSize = new Size(260, 275);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogReg;
        private TextBox textBoxPassReg;
        private Button buttonReg;
        private Label resultLabel;
        private Label label1;
        private Label label2;
    }
}