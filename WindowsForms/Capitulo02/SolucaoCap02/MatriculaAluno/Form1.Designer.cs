namespace MatriculaAluno
{
    partial class formMatricula
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano Nascimento:";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(186, 64);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(50, 13);
            this.lblDataAtual.TabIndex = 2;
            this.lblDataAtual.Text = "Dia Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(12, 99);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(145, 23);
            this.btnCategoria.TabIndex = 4;
            this.btnCategoria.Text = "Identificar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Peru;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCategoria.Location = new System.Drawing.Point(215, 101);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(144, 22);
            this.txtCategoria.TabIndex = 5;
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Location = new System.Drawing.Point(101, 57);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(79, 20);
            this.txtAnoNasc.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 20);
            this.txtNome.TabIndex = 8;
            // 
            // formMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 141);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtAnoNasc);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formMatricula";
            this.Text = "Matricula Aluno";
            this.Load += new System.EventHandler(this.formMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.TextBox txtNome;
    }
}

