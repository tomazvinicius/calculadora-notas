namespace AtividadeAvaliativa1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnExameFinal = new System.Windows.Forms.Button();
            this.btnSituacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIMULADOR DE NOTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedia
            // 
            this.btnMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(275, 53);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(226, 120);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = " Simular média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnExameFinal
            // 
            this.btnExameFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExameFinal.Location = new System.Drawing.Point(275, 188);
            this.btnExameFinal.Name = "btnExameFinal";
            this.btnExameFinal.Size = new System.Drawing.Size(226, 120);
            this.btnExameFinal.TabIndex = 4;
            this.btnExameFinal.Text = "Nota mínima para ser aprovado no exame";
            this.btnExameFinal.UseVisualStyleBackColor = true;
            this.btnExameFinal.Click += new System.EventHandler(this.btnExameFinal_Click);
            // 
            // btnSituacao
            // 
            this.btnSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSituacao.Location = new System.Drawing.Point(275, 333);
            this.btnSituacao.Name = "btnSituacao";
            this.btnSituacao.Size = new System.Drawing.Size(226, 120);
            this.btnSituacao.TabIndex = 5;
            this.btnSituacao.Text = "Verificar a média final após a nota do Exame Final";
            this.btnSituacao.UseVisualStyleBackColor = true;
            this.btnSituacao.Click += new System.EventHandler(this.btnSituacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSituacao);
            this.Controls.Add(this.btnExameFinal);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnExameFinal;
        private System.Windows.Forms.Button btnSituacao;
    }
}

