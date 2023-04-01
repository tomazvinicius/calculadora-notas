namespace AtividadeAvaliativa1.Formularios
{
    partial class FormCalcularExameFinal
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
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExameFinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(311, 114);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(149, 22);
            this.txtMedia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Média";
            // 
            // lbExameFinal
            // 
            this.lbExameFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExameFinal.Location = new System.Drawing.Point(12, 9);
            this.lbExameFinal.Name = "lbExameFinal";
            this.lbExameFinal.Size = new System.Drawing.Size(766, 24);
            this.lbExameFinal.TabIndex = 2;
            this.lbExameFinal.Text = "Exame Final";
            this.lbExameFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(140, 218);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(202, 61);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular exame final";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(140, 159);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(567, 25);
            this.lbResultado.TabIndex = 4;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(451, 218);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(202, 61);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo calculo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormCalcularExameFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbExameFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedia);
            this.Name = "FormCalcularExameFinal";
            this.Text = "FormCalcularExameFinal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExameFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnNovo;
    }
}