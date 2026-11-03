namespace aula_bancodedados_agenda
{
    partial class Form_Login
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
            btn_logar = new Button();
            txt_senha = new TextBox();
            txt_usuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_logar
            // 
            btn_logar.FlatStyle = FlatStyle.Flat;
            btn_logar.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logar.ForeColor = Color.FromArgb(176, 11, 105);
            btn_logar.Location = new Point(96, 331);
            btn_logar.Margin = new Padding(3, 4, 3, 4);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(154, 65);
            btn_logar.TabIndex = 11;
            btn_logar.Text = "Login";
            btn_logar.UseVisualStyleBackColor = true;
            btn_logar.Click += btn_logar_Click;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = Color.FromArgb(40, 1, 55);
            txt_senha.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            txt_senha.ForeColor = Color.FromArgb(176, 11, 105);
            txt_senha.Location = new Point(54, 242);
            txt_senha.Margin = new Padding(3, 4, 3, 4);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(242, 42);
            txt_senha.TabIndex = 10;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.FromArgb(40, 1, 55);
            txt_usuario.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            txt_usuario.ForeColor = Color.FromArgb(176, 11, 105);
            txt_usuario.Location = new Point(54, 151);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(242, 42);
            txt_usuario.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(176, 11, 105);
            label3.Location = new Point(54, 201);
            label3.Name = "label3";
            label3.Size = new Size(98, 35);
            label3.TabIndex = 8;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(176, 11, 105);
            label2.Location = new Point(54, 110);
            label2.Name = "label2";
            label2.Size = new Size(115, 35);
            label2.TabIndex = 7;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold);
            label1.Location = new Point(123, 34);
            label1.Name = "label1";
            label1.Size = new Size(110, 51);
            label1.TabIndex = 12;
            label1.Text = "Login";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 1, 55);
            ClientSize = new Size(357, 433);
            Controls.Add(label1);
            Controls.Add(btn_logar);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.FromArgb(176, 11, 105);
            Name = "Form_Login";
            Text = "Form_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_logar;
        private TextBox txt_senha;
        private TextBox txt_usuario;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}