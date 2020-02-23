namespace laCasaDeRoma
{
    partial class Bebidas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lacasa_romaDataSet33 = new laCasaDeRoma.lacasa_romaDataSet33();
            this.cadastroBebidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroBebidaTableAdapter = new laCasaDeRoma.lacasa_romaDataSet33TableAdapters.CadastroBebidaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lacasa_romaDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBebidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(101, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bebida";
            // 
            // cmbValor
            // 
            this.cmbValor.DataSource = this.cadastroBebidaBindingSource;
            this.cmbValor.DisplayMember = "valor_Bebida";
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.Location = new System.Drawing.Point(166, 102);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.Size = new System.Drawing.Size(48, 21);
            this.cmbValor.TabIndex = 8;
            this.cmbValor.ValueMember = "valor_Bebida";
            // 
            // cmbBebida
            // 
            this.cmbBebida.DataSource = this.cadastroBebidaBindingSource;
            this.cmbBebida.DisplayMember = "bebida";
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Location = new System.Drawing.Point(39, 102);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(121, 21);
            this.cmbBebida.TabIndex = 7;
            this.cmbBebida.ValueMember = "bebida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleciona a bebida desejado";
            // 
            // lacasa_romaDataSet33
            // 
            this.lacasa_romaDataSet33.DataSetName = "lacasa_romaDataSet33";
            this.lacasa_romaDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBebidaBindingSource
            // 
            this.cadastroBebidaBindingSource.DataMember = "CadastroBebida";
            this.cadastroBebidaBindingSource.DataSource = this.lacasa_romaDataSet33;
            // 
            // cadastroBebidaTableAdapter
            // 
            this.cadastroBebidaTableAdapter.ClearBeforeFill = true;
            // 
            // Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(288, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbValor);
            this.Controls.Add(this.cmbBebida);
            this.Controls.Add(this.label1);
            this.Name = "Bebidas";
            this.Text = "Bebidas";
            this.Load += new System.EventHandler(this.Bebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lacasa_romaDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBebidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.Label label1;
        private lacasa_romaDataSet33 lacasa_romaDataSet33;
        private System.Windows.Forms.BindingSource cadastroBebidaBindingSource;
        private lacasa_romaDataSet33TableAdapters.CadastroBebidaTableAdapter cadastroBebidaTableAdapter;
    }
}