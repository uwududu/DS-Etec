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
            SuspendLayout();
            // 
            // btn_logar
            // 
            btn_logar.FlatStyle = FlatStyle.Flat;
            btn_logar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logar.ForeColor = Color.Red;
            btn_logar.Location = new Point(96, 271);
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
            txt_senha.BackColor = Color.Black;
            txt_senha.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txt_senha.ForeColor = Color.Red;
            txt_senha.Location = new Point(54, 182);
            txt_senha.Margin = new Padding(3, 4, 3, 4);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(242, 41);
            txt_senha.TabIndex = 10;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.Black;
            txt_usuario.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txt_usuario.ForeColor = Color.Red;
            txt_usuario.Location = new Point(54, 91);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(242, 41);
            txt_usuario.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(54, 141);
            label3.Name = "label3";
            label3.Size = new Size(93, 35);
            label3.TabIndex = 8;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(54, 50);
            label2.Name = "label2";
            label2.Size = new Size(111, 35);
            label2.TabIndex = 7;
            label2.Text = "Usuario:";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(357, 433);
            Controls.Add(btn_logar);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = Color.Red;
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
    }
}