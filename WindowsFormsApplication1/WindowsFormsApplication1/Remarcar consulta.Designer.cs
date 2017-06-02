namespace WindowsFormsApplication1
{
    partial class Remarcar_consulta
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEspecialidade = new System.Windows.Forms.ComboBox();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTHora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTiDia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxNomepaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listVRemarcar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Lista de consultas marcadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Especialidade:";
            // 
            // cbxEspecialidade
            // 
            this.cbxEspecialidade.FormattingEnabled = true;
            this.cbxEspecialidade.Items.AddRange(new object[] {
            "Cardiologia",
            "Oftalmologia",
            "Psiquiatria"});
            this.cbxEspecialidade.Location = new System.Drawing.Point(158, 157);
            this.cbxEspecialidade.Name = "cbxEspecialidade";
            this.cbxEspecialidade.Size = new System.Drawing.Size(143, 21);
            this.cbxEspecialidade.TabIndex = 43;
            // 
            // cbxMedico
            // 
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Location = new System.Drawing.Point(350, 157);
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.Size = new System.Drawing.Size(162, 21);
            this.cbxMedico.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Médico:";
            // 
            // dateTHora
            // 
            this.dateTHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTHora.Location = new System.Drawing.Point(350, 130);
            this.dateTHora.Name = "dateTHora";
            this.dateTHora.Size = new System.Drawing.Size(162, 20);
            this.dateTHora.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hora:";
            // 
            // dateTiDia
            // 
            this.dateTiDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTiDia.Location = new System.Drawing.Point(158, 130);
            this.dateTiDia.Name = "dateTiDia";
            this.dateTiDia.Size = new System.Drawing.Size(143, 20);
            this.dateTiDia.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Dia:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(467, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(386, 197);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Inserir";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxNomepaciente
            // 
            this.tbxNomepaciente.Location = new System.Drawing.Point(158, 100);
            this.tbxNomepaciente.Name = "tbxNomepaciente";
            this.tbxNomepaciente.Size = new System.Drawing.Size(354, 20);
            this.tbxNomepaciente.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome do paciente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Alterar dados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Voltar ao menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 46;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, -5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 73);
            this.label10.TabIndex = 49;
            this.label10.Text = "CC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Clinica Cidadão";
            // 
            // listVRemarcar
            // 
            this.listVRemarcar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listVRemarcar.Location = new System.Drawing.Point(13, 224);
            this.listVRemarcar.Name = "listVRemarcar";
            this.listVRemarcar.Size = new System.Drawing.Size(529, 111);
            this.listVRemarcar.TabIndex = 51;
            this.listVRemarcar.UseCompatibleStateImageBehavior = false;
            this.listVRemarcar.View = System.Windows.Forms.View.Details;
            this.listVRemarcar.SelectedIndexChanged += new System.EventHandler(this.listVRemarcar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dia";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Especialidade";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Medico";
            // 
            // Remarcar_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 347);
            this.Controls.Add(this.listVRemarcar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxEspecialidade);
            this.Controls.Add(this.cbxMedico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTiDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxNomepaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "Remarcar_consulta";
            this.Text = "Remarcar_consulta";
            this.Load += new System.EventHandler(this.Remarcar_consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEspecialidade;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTiDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxNomepaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listVRemarcar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}