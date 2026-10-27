namespace agenda
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtTele = new TextBox();
            label4 = new Label();
            button1 = new Button();
            buttConsulta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label1.Location = new Point(115, 111);
            label1.Name = "label1";
            label1.Size = new Size(71, 27);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label2.Location = new Point(115, 163);
            label2.Name = "label2";
            label2.Size = new Size(68, 27);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            label3.Location = new Point(115, 215);
            label3.Name = "label3";
            label3.Size = new Size(101, 27);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 24);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 24);
            txtEmail.TabIndex = 4;
            // 
            // txtTele
            // 
            txtTele.Location = new Point(222, 218);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(100, 24);
            txtTele.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label4.Location = new Point(139, 24);
            label4.Name = "label4";
            label4.Size = new Size(139, 48);
            label4.TabIndex = 6;
            label4.Text = "Agenda";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            button1.Location = new Point(165, 267);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttConsulta
            // 
            buttConsulta.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            buttConsulta.Location = new Point(149, 323);
            buttConsulta.Name = "buttConsulta";
            buttConsulta.Size = new Size(162, 41);
            buttConsulta.TabIndex = 8;
            buttConsulta.Text = "Listar trens";
            buttConsulta.UseVisualStyleBackColor = true;
            buttConsulta.Click += buttConsulta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 11, 105);
            ClientSize = new Size(442, 394);
            Controls.Add(buttConsulta);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtTele);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 9F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtTele;
        private Label label4;
        private Button button1;
        private Button buttConsulta;
    }
}
