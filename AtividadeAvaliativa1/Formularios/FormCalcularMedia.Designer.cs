namespace AtividadeAvaliativa1.Formularios
{
    partial class FormCalcularMedia
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
            this.btnNovaSimulacao = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.lbMedia = new System.Windows.Forms.Label();
            this.txtSegundaNota = new System.Windows.Forms.TextBox();
            this.txtPrimeiraNota = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovaSimulacao
            // 
            this.btnNovaSimulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaSimulacao.Location = new System.Drawing.Point(444, 256);
            this.btnNovaSimulacao.Name = "btnNovaSimulacao";
            this.btnNovaSimulacao.Size = new System.Drawing.Size(173, 52);
            this.btnNovaSimulacao.TabIndex = 23;
            this.btnNovaSimulacao.Text = "Nova simulação";
            this.btnNovaSimulacao.UseVisualStyleBackColor = true;
            this.btnNovaSimulacao.Click += new System.EventHandler(this.btnNovaSimulacao_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(444, 157);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(173, 52);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lbMedia
            // 
            this.lbMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedia.Location = new System.Drawing.Point(61, 360);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(451, 20);
            this.lbMedia.TabIndex = 21;
            // 
            // txtSegundaNota
            // 
            this.txtSegundaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundaNota.Location = new System.Drawing.Point(83, 297);
            this.txtSegundaNota.Name = "txtSegundaNota";
            this.txtSegundaNota.Size = new System.Drawing.Size(136, 27);
            this.txtSegundaNota.TabIndex = 20;
            // 
            // txtPrimeiraNota
            // 
            this.txtPrimeiraNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiraNota.Location = new System.Drawing.Point(83, 216);
            this.txtPrimeiraNota.Name = "txtPrimeiraNota";
            this.txtPrimeiraNota.Size = new System.Drawing.Size(136, 27);
            this.txtPrimeiraNota.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(83, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 27);
            this.txtNome.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Segunda nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Primeira nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "MEDIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(61, 404);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(451, 22);
            this.lbResultado.TabIndex = 24;
            // 
            // FormCalcularMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnNovaSimulacao);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.txtSegundaNota);
            this.Controls.Add(this.txtPrimeiraNota);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCalcularMedia";
            this.Text = "FormCalcularMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaSimulacao;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.TextBox txtSegundaNota;
        private System.Windows.Forms.TextBox txtPrimeiraNota;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultado;
    }
}