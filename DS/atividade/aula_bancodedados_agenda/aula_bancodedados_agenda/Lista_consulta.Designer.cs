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
            ((System.ComponentModel.ISupportInitialize)dgv_contato).BeginInit();
            SuspendLayout();
            // 
            // btn_atualizar
            // 
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Location = new Point(250, 379);
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
            button1.Location = new Point(426, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 47);
            button1.TabIndex = 2;
            button1.Text = "DELETAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lista_consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 523);
            Controls.Add(button1);
            Controls.Add(dgv_contato);
            Controls.Add(btn_atualizar);
            ForeColor = Color.Red;
            Name = "Lista_consulta";
            Text = "Lista_consulta";
            Load += Lista_consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_contato).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_atualizar;
        private DataGridView dgv_contato;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button button1;
    }
}