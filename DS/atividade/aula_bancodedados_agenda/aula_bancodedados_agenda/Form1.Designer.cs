namespace aula_bancodedados_agenda
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
            txt_nome = new TextBox();
            txt_email = new TextBox();
            txt_telefone = new TextBox();
            button1 = new Button();
            btn_abrirconsulta = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(176, 11, 105);
            label1.Location = new Point(76, 113);
            label1.Name = "label1";
            label1.Size = new Size(92, 35);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(176, 11, 105);
            label2.Location = new Point(76, 204);
            label2.Name = "label2";
            label2.Size = new Size(89, 35);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(176, 11, 105);
            label3.Location = new Point(76, 295);
            label3.Name = "label3";
            label3.Size = new Size(131, 35);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // txt_nome
            // 
            txt_nome.BackColor = Color.FromArgb(40, 1, 55);
            txt_nome.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txt_nome.ForeColor = Color.Red;
            txt_nome.Location = new Point(76, 155);
            txt_nome.Margin = new Padding(3, 4, 3, 4);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(242, 41);
            txt_nome.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(40, 1, 55);
            txt_email.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txt_email.ForeColor = Color.Red;
            txt_email.Location = new Point(76, 245);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(242, 41);
            txt_email.TabIndex = 4;
            // 
            // txt_telefone
            // 
            txt_telefone.BackColor = Color.FromArgb(40, 1, 55);
            txt_telefone.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txt_telefone.ForeColor = Color.Red;
            txt_telefone.Location = new Point(76, 336);
            txt_telefone.Margin = new Padding(3, 4, 3, 4);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(242, 41);
            txt_telefone.TabIndex = 5;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(176, 11, 105);
            button1.Location = new Point(118, 425);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 65);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_abrirconsulta
            // 
            btn_abrirconsulta.FlatStyle = FlatStyle.Flat;
            btn_abrirconsulta.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_abrirconsulta.ForeColor = Color.FromArgb(176, 11, 105);
            btn_abrirconsulta.Location = new Point(118, 513);
            btn_abrirconsulta.Margin = new Padding(3, 4, 3, 4);
            btn_abrirconsulta.Name = "btn_abrirconsulta";
            btn_abrirconsulta.Size = new Size(154, 51);
            btn_abrirconsulta.TabIndex = 7;
            btn_abrirconsulta.Text = "Listar Dados";
            btn_abrirconsulta.UseVisualStyleBackColor = true;
            btn_abrirconsulta.Click += btn_abrirconsulta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold);
            label4.Location = new Point(109, 39);
            label4.Name = "label4";
            label4.Size = new Size(181, 51);
            label4.TabIndex = 8;
            label4.Text = "Cadastro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 1, 55);
            ClientSize = new Size(423, 592);
            Controls.Add(label4);
            Controls.Add(btn_abrirconsulta);
            Controls.Add(button1);
            Controls.Add(txt_telefone);
            Controls.Add(txt_email);
            Controls.Add(txt_nome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(176, 11, 105);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nome;
        private TextBox txt_email;
        private TextBox txt_telefone;
        private Button button1;
        private Button btn_abrirconsulta;
        private Label label4;
    }
}
