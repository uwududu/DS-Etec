namespace Cadastro_de_Veículos
{
    partial class Form2
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
            dgvContatos = new DataGridView();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(40, 23);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.Size = new Size(706, 336);
            dgvContatos.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = SystemColors.ControlDark;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 15F);
            btnAtualizar.ForeColor = Color.BlueViolet;
            btnAtualizar.Location = new Point(303, 384);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(162, 39);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar Lista";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvContatos);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContatos;
        private Button btnAtualizar;
    }
}