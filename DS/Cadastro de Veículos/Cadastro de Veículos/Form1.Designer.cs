namespace Cadastro_de_Veículos
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtAno = new TextBox();
            txtCor = new TextBox();
            btCadastro = new Button();
            btnAbrirConsulta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label1.Location = new Point(214, 34);
            label1.Name = "label1";
            label1.Size = new Size(416, 54);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Veículos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(109, 143);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 1;
            label2.Text = "Placa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(89, 191);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 2;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(109, 239);
            label4.Name = "label4";
            label4.Size = new Size(96, 37);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(117, 298);
            label5.Name = "label5";
            label5.Size = new Size(71, 37);
            label5.TabIndex = 4;
            label5.Text = "Ano:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(117, 349);
            label6.Name = "label6";
            label6.Size = new Size(65, 37);
            label6.TabIndex = 5;
            label6.Text = "Cor:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(214, 155);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(405, 25);
            txtPlaca.TabIndex = 6;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(214, 203);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(405, 25);
            txtModelo.TabIndex = 7;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(214, 252);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(405, 25);
            txtMarca.TabIndex = 8;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(214, 311);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(405, 25);
            txtAno.TabIndex = 9;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(214, 361);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(405, 25);
            txtCor.TabIndex = 10;
            // 
            // btCadastro
            // 
            btCadastro.BackColor = Color.Black;
            btCadastro.FlatStyle = FlatStyle.Flat;
            btCadastro.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btCadastro.Location = new Point(12, 418);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(228, 60);
            btCadastro.TabIndex = 11;
            btCadastro.Text = "Cadastrar ";
            btCadastro.UseVisualStyleBackColor = false;
            btCadastro.Click += btCadastro_Click;
            // 
            // btnAbrirConsulta
            // 
            btnAbrirConsulta.BackColor = Color.Black;
            btnAbrirConsulta.FlatStyle = FlatStyle.Flat;
            btnAbrirConsulta.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btnAbrirConsulta.Location = new Point(246, 418);
            btnAbrirConsulta.Name = "btnAbrirConsulta";
            btnAbrirConsulta.Size = new Size(542, 60);
            btnAbrirConsulta.TabIndex = 12;
            btnAbrirConsulta.Text = "Ver Contatos Cadastrados";
            btnAbrirConsulta.UseVisualStyleBackColor = false;
            btnAbrirConsulta.Click += btnAbrirConsulta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 510);
            Controls.Add(btnAbrirConsulta);
            Controls.Add(btCadastro);
            Controls.Add(txtCor);
            Controls.Add(txtAno);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtPlaca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.BlueViolet;
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
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtAno;
        private TextBox txtCor;
        private Button btCadastro;
        private Button btnAbrirConsulta;
    }
}
