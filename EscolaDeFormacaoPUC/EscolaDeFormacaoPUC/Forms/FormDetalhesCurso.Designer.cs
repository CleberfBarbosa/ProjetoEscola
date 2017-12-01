namespace EscolaDeFormacaoPUC.Forms
{
    partial class FormDetalhesCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalhesCurso));
            this.label6 = new System.Windows.Forms.Label();
            this.etCurso = new System.Windows.Forms.TextBox();
            this.etTurma = new System.Windows.Forms.TextBox();
            this.etHorario = new System.Windows.Forms.MaskedTextBox();
            this.etDtFim = new System.Windows.Forms.MaskedTextBox();
            this.etDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.cbDiasSemana = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatricularAlunos = new System.Windows.Forms.Button();
            this.btnVerAlunos = new System.Windows.Forms.Button();
            this.btnFinalizarCurso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dias da semana";
            // 
            // etCurso
            // 
            this.etCurso.Enabled = false;
            this.etCurso.Location = new System.Drawing.Point(76, 27);
            this.etCurso.Name = "etCurso";
            this.etCurso.Size = new System.Drawing.Size(223, 20);
            this.etCurso.TabIndex = 22;
            // 
            // etTurma
            // 
            this.etTurma.Enabled = false;
            this.etTurma.Location = new System.Drawing.Point(76, 53);
            this.etTurma.Name = "etTurma";
            this.etTurma.Size = new System.Drawing.Size(83, 20);
            this.etTurma.TabIndex = 21;
            // 
            // etHorario
            // 
            this.etHorario.Enabled = false;
            this.etHorario.Location = new System.Drawing.Point(259, 53);
            this.etHorario.Mask = "00:00";
            this.etHorario.Name = "etHorario";
            this.etHorario.Size = new System.Drawing.Size(40, 20);
            this.etHorario.TabIndex = 20;
            this.etHorario.ValidatingType = typeof(System.DateTime);
            // 
            // etDtFim
            // 
            this.etDtFim.Enabled = false;
            this.etDtFim.Location = new System.Drawing.Point(229, 79);
            this.etDtFim.Mask = "00/00/0000";
            this.etDtFim.Name = "etDtFim";
            this.etDtFim.Size = new System.Drawing.Size(70, 20);
            this.etDtFim.TabIndex = 19;
            this.etDtFim.ValidatingType = typeof(System.DateTime);
            // 
            // etDtInicio
            // 
            this.etDtInicio.Enabled = false;
            this.etDtInicio.Location = new System.Drawing.Point(76, 79);
            this.etDtInicio.Mask = "00/00/0000";
            this.etDtInicio.Name = "etDtInicio";
            this.etDtInicio.Size = new System.Drawing.Size(67, 20);
            this.etDtInicio.TabIndex = 18;
            this.etDtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // cbDiasSemana
            // 
            this.cbDiasSemana.Enabled = false;
            this.cbDiasSemana.FormattingEnabled = true;
            this.cbDiasSemana.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado",
            "Domingo"});
            this.cbDiasSemana.Location = new System.Drawing.Point(403, 9);
            this.cbDiasSemana.Name = "cbDiasSemana";
            this.cbDiasSemana.Size = new System.Drawing.Size(80, 109);
            this.cbDiasSemana.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Turma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Curso";
            // 
            // btnMatricularAlunos
            // 
            this.btnMatricularAlunos.Location = new System.Drawing.Point(6, 21);
            this.btnMatricularAlunos.Name = "btnMatricularAlunos";
            this.btnMatricularAlunos.Size = new System.Drawing.Size(116, 28);
            this.btnMatricularAlunos.TabIndex = 24;
            this.btnMatricularAlunos.Text = "Matricular Alunos";
            this.btnMatricularAlunos.UseVisualStyleBackColor = true;
            this.btnMatricularAlunos.Click += new System.EventHandler(this.btnMatricularAlunos_Click);
            // 
            // btnVerAlunos
            // 
            this.btnVerAlunos.Location = new System.Drawing.Point(6, 55);
            this.btnVerAlunos.Name = "btnVerAlunos";
            this.btnVerAlunos.Size = new System.Drawing.Size(116, 23);
            this.btnVerAlunos.TabIndex = 25;
            this.btnVerAlunos.Text = "Ver Alunos";
            this.btnVerAlunos.UseVisualStyleBackColor = true;
            this.btnVerAlunos.Click += new System.EventHandler(this.btnVerAlunos_Click);
            // 
            // btnFinalizarCurso
            // 
            this.btnFinalizarCurso.Location = new System.Drawing.Point(6, 84);
            this.btnFinalizarCurso.Name = "btnFinalizarCurso";
            this.btnFinalizarCurso.Size = new System.Drawing.Size(116, 23);
            this.btnFinalizarCurso.TabIndex = 26;
            this.btnFinalizarCurso.Text = "Finalizar Curso";
            this.btnFinalizarCurso.UseVisualStyleBackColor = true;
            this.btnFinalizarCurso.Click += new System.EventHandler(this.btnFinalizarCurso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMatricularAlunos);
            this.groupBox1.Controls.Add(this.btnFinalizarCurso);
            this.groupBox1.Controls.Add(this.btnVerAlunos);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 113);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // FormDetalhesCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 137);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.etCurso);
            this.Controls.Add(this.etTurma);
            this.Controls.Add(this.etHorario);
            this.Controls.Add(this.etDtFim);
            this.Controls.Add(this.etDtInicio);
            this.Controls.Add(this.cbDiasSemana);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDetalhesCurso";
            this.Text = "Detalhes do curso";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox etCurso;
        private System.Windows.Forms.TextBox etTurma;
        private System.Windows.Forms.MaskedTextBox etHorario;
        private System.Windows.Forms.MaskedTextBox etDtFim;
        private System.Windows.Forms.MaskedTextBox etDtInicio;
        private System.Windows.Forms.CheckedListBox cbDiasSemana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatricularAlunos;
        private System.Windows.Forms.Button btnVerAlunos;
        private System.Windows.Forms.Button btnFinalizarCurso;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}