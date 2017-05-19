namespace WindowsFormsApplication1
{
    partial class Home
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
            this.btnRemarcarConsultas = new System.Windows.Forms.Button();
            this.btnMarcarConsulta = new System.Windows.Forms.Button();
            this.btnInserirMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Stormfaze", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinica Cidadão";
            // 
            // btnRemarcarConsultas
            // 
            this.btnRemarcarConsultas.Location = new System.Drawing.Point(379, 122);
            this.btnRemarcarConsultas.Name = "btnRemarcarConsultas";
            this.btnRemarcarConsultas.Size = new System.Drawing.Size(137, 133);
            this.btnRemarcarConsultas.TabIndex = 2;
            this.btnRemarcarConsultas.Text = "Remarcar consulta";
            this.btnRemarcarConsultas.UseVisualStyleBackColor = true;
            // 
            // btnMarcarConsulta
            // 
            this.btnMarcarConsulta.Location = new System.Drawing.Point(203, 122);
            this.btnMarcarConsulta.Name = "btnMarcarConsulta";
            this.btnMarcarConsulta.Size = new System.Drawing.Size(137, 133);
            this.btnMarcarConsulta.TabIndex = 3;
            this.btnMarcarConsulta.Text = "Marcar Consulta";
            this.btnMarcarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnInserirMedico
            // 
            this.btnInserirMedico.Location = new System.Drawing.Point(25, 122);
            this.btnInserirMedico.Name = "btnInserirMedico";
            this.btnInserirMedico.Size = new System.Drawing.Size(137, 133);
            this.btnInserirMedico.TabIndex = 4;
            this.btnInserirMedico.Text = "Inserir Médico";
            this.btnInserirMedico.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(554, 347);
            this.Controls.Add(this.btnInserirMedico);
            this.Controls.Add(this.btnMarcarConsulta);
            this.Controls.Add(this.btnRemarcarConsultas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemarcarConsultas;
        private System.Windows.Forms.Button btnMarcarConsulta;
        private System.Windows.Forms.Button btnInserirMedico;
    }
}

