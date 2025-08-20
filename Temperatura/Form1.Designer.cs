namespace Temperatura
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbltempo = new System.Windows.Forms.Label();
            this.txbtempo = new System.Windows.Forms.TextBox();
            this.btnclima = new System.Windows.Forms.Button();
            this.pibimagem = new System.Windows.Forms.PictureBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(142, 38);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(515, 39);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Verificador de Temperatura2000";
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempo.Location = new System.Drawing.Point(12, 126);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(212, 25);
            this.lbltempo.TabIndex = 1;
            this.lbltempo.Text = "Digite a temperatura:";
            // 
            // txbtempo
            // 
            this.txbtempo.Location = new System.Drawing.Point(230, 131);
            this.txbtempo.Name = "txbtempo";
            this.txbtempo.Size = new System.Drawing.Size(315, 20);
            this.txbtempo.TabIndex = 2;
            // 
            // btnclima
            // 
            this.btnclima.Location = new System.Drawing.Point(219, 157);
            this.btnclima.Name = "btnclima";
            this.btnclima.Size = new System.Drawing.Size(341, 46);
            this.btnclima.TabIndex = 3;
            this.btnclima.Text = "Verificar Clima";
            this.btnclima.UseVisualStyleBackColor = true;
            this.btnclima.Click += new System.EventHandler(this.btnclima_Click);
            // 
            // pibimagem
            // 
            this.pibimagem.Location = new System.Drawing.Point(230, 209);
            this.pibimagem.Name = "pibimagem";
            this.pibimagem.Size = new System.Drawing.Size(315, 241);
            this.pibimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibimagem.TabIndex = 4;
            this.pibimagem.TabStop = false;
            this.pibimagem.Click += new System.EventHandler(this.pibimagem_Click);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(288, 91);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 25);
            this.lbldata.TabIndex = 5;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(144, 493);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 25);
            this.lblresultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.pibimagem);
            this.Controls.Add(this.btnclima);
            this.Controls.Add(this.txbtempo);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.lbltitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Verificador De Temperatura ::";
            ((System.ComponentModel.ISupportInitialize)(this.pibimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.TextBox txbtempo;
        private System.Windows.Forms.Button btnclima;
        private System.Windows.Forms.PictureBox pibimagem;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblresultado;
    }
}

