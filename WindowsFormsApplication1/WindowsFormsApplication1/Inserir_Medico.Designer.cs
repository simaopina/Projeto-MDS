namespace WindowsFormsApplication1
{
    partial class Inserir_Medico
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxNIF = new System.Windows.Forms.TextBox();
            this.btnGerir = new System.Windows.Forms.Button();
            this.cbxEspecialidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridMedico = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimeInicio = new System.Windows.Forms.DateTimePicker();
            this.datetimeFim = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Especialidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de Indentificação Fiscal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Horário:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(176, 94);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(286, 20);
            this.tbxNome.TabIndex = 6;
            // 
            // tbxNIF
            // 
            this.tbxNIF.Location = new System.Drawing.Point(176, 151);
            this.tbxNIF.Name = "tbxNIF";
            this.tbxNIF.Size = new System.Drawing.Size(286, 20);
            this.tbxNIF.TabIndex = 8;
            // 
            // btnGerir
            // 
            this.btnGerir.Location = new System.Drawing.Point(403, 122);
            this.btnGerir.Name = "btnGerir";
            this.btnGerir.Size = new System.Drawing.Size(59, 21);
            this.btnGerir.TabIndex = 10;
            this.btnGerir.Text = "Gerir";
            this.btnGerir.UseVisualStyleBackColor = true;
            // 
            // cbxEspecialidade
            // 
            this.cbxEspecialidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Pediatria",
            "Cardiologia",
            "Dentista"});
            this.cbxEspecialidade.FormattingEnabled = true;
            this.cbxEspecialidade.Location = new System.Drawing.Point(176, 122);
            this.cbxEspecialidade.Name = "cbxEspecialidade";
            this.cbxEspecialidade.Size = new System.Drawing.Size(221, 21);
            this.cbxEspecialidade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Inserir dados:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(388, 200);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 16;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(467, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridMedico
            // 
            this.dataGridMedico.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedico.Location = new System.Drawing.Point(12, 229);
            this.dataGridMedico.Name = "dataGridMedico";
            this.dataGridMedico.Size = new System.Drawing.Size(530, 106);
            this.dataGridMedico.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Lista de médicos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 29);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "<-";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voltar ao menu";
            // 
            // datetimeInicio
            // 
            this.datetimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimeInicio.Location = new System.Drawing.Point(206, 177);
            this.datetimeInicio.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.datetimeInicio.Name = "datetimeInicio";
            this.datetimeInicio.Size = new System.Drawing.Size(106, 20);
            this.datetimeInicio.TabIndex = 32;
            // 
            // datetimeFim
            // 
            this.datetimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimeFim.Location = new System.Drawing.Point(337, 177);
            this.datetimeFim.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.datetimeFim.Name = "datetimeFim";
            this.datetimeFim.Size = new System.Drawing.Size(125, 20);
            this.datetimeFim.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Clinica Cidadão";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(475, -5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 73);
            this.label11.TabIndex = 51;
            this.label11.Text = "CC";
            // 
            // Inserir_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 347);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.datetimeFim);
            this.Controls.Add(this.datetimeInicio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridMedico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEspecialidade);
            this.Controls.Add(this.btnGerir);
            this.Controls.Add(this.tbxNIF);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Inserir_Medico";
            this.Text = "Inserir Médico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxNIF;
        private System.Windows.Forms.Button btnGerir;
        private System.Windows.Forms.ComboBox cbxEspecialidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridMedico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetimeInicio;
        private System.Windows.Forms.DateTimePicker datetimeFim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}