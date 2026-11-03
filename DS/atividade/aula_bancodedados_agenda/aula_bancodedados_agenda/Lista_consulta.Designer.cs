namespace aula_bancodedados_agenda
{
    partial class Lista_consulta
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
            btn_atualizar = new Button();
            dgv_contato = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            button1 = new Button();
            txt_busca = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_contato).BeginInit();
            SuspendLayout();
            // 
            // btn_atualizar
            // 
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Comic Sans MS", 9F);
            btn_atualizar.Location = new Point(253, 445);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(94, 47);
            btn_atualizar.TabIndex = 0;
            btn_atualizar.Text = "LISTAR";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // dgv_contato
            // 
            dgv_contato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contato.Location = new Point(67, 44);
            dgv_contato.MultiSelect = false;
            dgv_contato.Name = "dgv_contato";
            dgv_contato.RowHeadersWidth = 51;
            dgv_contato.ScrollBars = ScrollBars.None;
            dgv_contato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_contato.Size = new Size(657, 301);
            dgv_contato.TabIndex = 1;
            dgv_contato.CellDoubleClick += dgv_contato_CellDoubleClick;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 9F);
            button1.Location = new Point(429, 445);
            button1.Name = "button1";
            button1.Size = new Size(94, 47);
            button1.TabIndex = 2;
            button1.Text = "DELETAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_busca
            // 
            txt_busca.BackColor = Color.FromArgb(40, 1, 55);
            txt_busca.Font = new Font("Comic Sans MS", 17F);
            txt_busca.ForeColor = Color.FromArgb(176, 11, 105);
            txt_busca.Location = new Point(280, 392);
            txt_busca.Name = "txt_busca";
            txt_busca.Size = new Size(221, 47);
            txt_busca.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13F);
            label1.Location = new Point(293, 355);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 4;
            label1.Text = "Pesquisar:";
            // 
            // Lista_consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 1, 55);
            ClientSize = new Size(800, 523);
            Controls.Add(label1);
            Controls.Add(txt_busca);
            Controls.Add(button1);
            Controls.Add(dgv_contato);
            Controls.Add(btn_atualizar);
            ForeColor = Color.FromArgb(176, 11, 105);
            Name = "Lista_consulta";
            Text = "Lista_consulta";
            Load += Lista_consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_contato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_atualizar;
        private DataGridView dgv_contato;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button1;
        private TextBox txt_busca;
        private Label label1;
    }
}