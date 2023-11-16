namespace authorization
{
    partial class FinalForm
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
            labelLog = new Label();
            labelPass = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Location = new Point(12, 21);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(28, 15);
            labelLog.TabIndex = 0;
            labelLog.Text = "Text";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(12, 65);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(27, 15);
            labelPass.TabIndex = 1;
            labelPass.Text = "Test";
            labelPass.Click += labelPass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Логин:";
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 236);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelPass);
            Controls.Add(labelLog);
            MaximumSize = new Size(260, 275);
            MinimumSize = new Size(260, 275);
            Name = "FinalForm";
            Text = "Result";
            Load += FinalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLog;
        private Label labelPass;
        private Label label1;
        private Label label2;
    }
}