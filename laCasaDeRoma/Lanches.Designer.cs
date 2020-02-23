namespace laCasaDeRoma
{
    partial class Lanches
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanche = new System.Windows.Forms.ComboBox();
            this.lacasa_romaDataSet32 = new laCasaDeRoma.lacasa_romaDataSet32();
            this.cadastroLancheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroLancheTableAdapter = new laCasaDeRoma.lacasa_romaDataSet32TableAdapters.CadastroLancheTableAdapter();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lacasa_romaDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroLancheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleciona o Lanche desejado";
            // 
            // cmbLanche
            // 
            this.cmbLanche.DataSource = this.cadastroLancheBindingSource;
            this.cmbLanche.DisplayMember = "nome_Lanche";
            this.cmbLanche.FormattingEnabled = true;
            this.cmbLanche.Location = new System.Drawing.Point(62, 83);
            this.cmbLanche.Name = "cmbLanche";
            this.cmbLanche.Size = new System.Drawing.Size(121, 21);
            this.cmbLanche.TabIndex = 1;
            this.cmbLanche.ValueMember = "nome_Lanche";
            // 
            // lacasa_romaDataSet32
            // 
            this.lacasa_romaDataSet32.DataSetName = "lacasa_romaDataSet32";
            this.lacasa_romaDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroLancheBindingSource
            // 
            this.cadastroLancheBindingSource.DataMember = "CadastroLanche";
            this.cadastroLancheBindingSource.DataSource = this.lacasa_romaDataSet32;
            // 
            // cadastroLancheTableAdapter
            // 
            this.cadastroLancheTableAdapter.ClearBeforeFill = true;
            // 
            // cmbValor
            // 
            this.cmbValor.DataSource = this.cadastroLancheBindingSource;
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.Location = new System.Drawing.Point(189, 83);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.Size = new System.Drawing.Size(48, 21);
            this.cmbValor.TabIndex = 2;
            this.cmbValor.ValueMember = "preco_Lanche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lanche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(124, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(328, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbValor);
            this.Controls.Add(this.cmbLanche);
            this.Controls.Add(this.label1);
            this.Name = "Lanches";
            this.Text = "Lanches";
            this.Load += new System.EventHandler(this.Lanches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lacasa_romaDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroLancheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanche;
        private lacasa_romaDataSet32 lacasa_romaDataSet32;
        private System.Windows.Forms.BindingSource cadastroLancheBindingSource;
        private lacasa_romaDataSet32TableAdapters.CadastroLancheTableAdapter cadastroLancheTableAdapter;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}