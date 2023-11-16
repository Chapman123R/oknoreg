namespace authorization
{
    partial class LoginForm
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
            textBoxLog = new TextBox();
            textBoxPass = new TextBox();
            buttonReg = new Button();
            button1 = new Button();
            labelResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(12, 25);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(218, 23);
            textBoxLog.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(12, 79);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(218, 23);
            textBoxPass.TabIndex = 2;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(122, 108);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(92, 23);
            buttonReg.TabIndex = 3;
            buttonReg.Text = "Вход";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 108);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 4;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(88, 134);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Пароль:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 236);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(buttonReg);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLog);
            MaximumSize = new Size(260, 275);
            MinimumSize = new Size(260, 260);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLog;
        private TextBox textBoxPass;
        private Button buttonReg;
        private Button button1;
        private Label labelResult;
        private Label label1;
        private Label label2;
    }
}