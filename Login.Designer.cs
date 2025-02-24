namespace WinFormsApp1
{
    partial class Login
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
            labelnum1 = new Label();
            textnum1 = new TextBox();
            labelsum = new Label();
            textsum = new TextBox();
            buttonadd = new Button();
            labelanimal = new Label();
            textBoxanimal = new TextBox();
            SuspendLayout();
            // 
            // labelnum1
            // 
            labelnum1.AutoSize = true;
            labelnum1.Location = new Point(68, 56);
            labelnum1.Name = "labelnum1";
            labelnum1.Size = new Size(49, 20);
            labelnum1.TabIndex = 0;
            labelnum1.Text = "Name";
            labelnum1.Click += label1_Click;
            // 
            // textnum1
            // 
            textnum1.Location = new Point(123, 53);
            textnum1.Name = "textnum1";
            textnum1.Size = new Size(125, 27);
            textnum1.TabIndex = 1;
            textnum1.TextChanged += textnum1_TextChanged;
            // 
            // labelsum
            // 
            labelsum.AutoSize = true;
            labelsum.Location = new Point(47, 89);
            labelsum.Name = "labelsum";
            labelsum.Size = new Size(70, 20);
            labelsum.TabIndex = 2;
            labelsum.Text = "Password";
            // 
            // textsum
            // 
            textsum.Location = new Point(123, 86);
            textsum.Name = "textsum";
            textsum.Size = new Size(125, 27);
            textsum.TabIndex = 3;
            // 
            // buttonadd
            // 
            buttonadd.Location = new Point(132, 175);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(94, 29);
            buttonadd.TabIndex = 4;
            buttonadd.Text = "Login";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += buttonadd_Click;
            // 
            // labelanimal
            // 
            labelanimal.AutoSize = true;
            labelanimal.Location = new Point(36, 127);
            labelanimal.Name = "labelanimal";
            labelanimal.Size = new Size(81, 20);
            labelanimal.TabIndex = 5;
            labelanimal.Text = "Fav Animal";
            // 
            // textBoxanimal
            // 
            textBoxanimal.Location = new Point(123, 124);
            textBoxanimal.Name = "textBoxanimal";
            textBoxanimal.Size = new Size(125, 27);
            textBoxanimal.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxanimal);
            Controls.Add(labelanimal);
            Controls.Add(buttonadd);
            Controls.Add(textsum);
            Controls.Add(labelsum);
            Controls.Add(textnum1);
            Controls.Add(labelnum1);
            ForeColor = Color.CornflowerBlue;
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnum1;
        private TextBox textnum1;
        private Label labelsum;
        private TextBox textsum;
        private Button buttonadd;
        private Label labelanimal;
        private TextBox textBoxanimal;
    }
}
