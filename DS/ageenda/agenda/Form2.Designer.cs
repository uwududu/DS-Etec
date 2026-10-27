namespace agenda
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
            buttUPD = new Button();
            buttExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(79, 51);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.Size = new Size(642, 317);
            dgvContatos.TabIndex = 0;
            dgvContatos.CellDoubleClick += dgvContatos_CellDoubleClick;
            // 
            // buttUPD
            // 
            buttUPD.Location = new Point(163, 388);
            buttUPD.Name = "buttUPD";
            buttUPD.Size = new Size(105, 39);
            buttUPD.TabIndex = 1;
            buttUPD.Text = "Listar";
            buttUPD.UseVisualStyleBackColor = true;
            buttUPD.Click += buttUPD_Click;
            // 
            // buttExcluir
            // 
            buttExcluir.Location = new Point(524, 388);
            buttExcluir.Name = "buttExcluir";
            buttExcluir.Size = new Size(105, 39);
            buttExcluir.TabIndex = 2;
            buttExcluir.Text = "Excluir";
            buttExcluir.UseVisualStyleBackColor = true;
            buttExcluir.Click += buttExcluir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 11, 105);
            ClientSize = new Size(813, 457);
            Controls.Add(buttExcluir);
            Controls.Add(buttUPD);
            Controls.Add(dgvContatos);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContatos;
        private Button buttUPD;
        private Button buttExcluir;
    }
}