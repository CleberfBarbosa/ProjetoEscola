namespace EscolaDeFormacaoPUC.Forms
{
    partial class FormCadastroEdicaoCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroEdicaoCurso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDiasSemana = new System.Windows.Forms.CheckedListBox();
            this.etDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.etDtFim = new System.Windows.Forms.MaskedTextBox();
            this.etHorario = new System.Windows.Forms.MaskedTextBox();
            this.etTurma = new System.Windows.Forms.TextBox();
            this.etCurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Início";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Fim";
            // 
            // cbDiasSemana
            // 
            this.cbDiasSemana.FormattingEnabled = true;
            this.cbDiasSemana.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado",
            "Domingo"});
            this.cbDiasSemana.Location = new System.Drawing.Point(410, 10);
            this.cbDiasSemana.Name = "cbDiasSemana";
            this.cbDiasSemana.Size = new System.Drawing.Size(80, 109);
            this.cbDiasSemana.TabIndex = 5;
            // 
            // etDtInicio
            // 
            this.etDtInicio.Location = new System.Drawing.Point(83, 80);
            this.etDtInicio.Mask = "00/00/0000";
            this.etDtInicio.Name = "etDtInicio";
            this.etDtInicio.Size = new System.Drawing.Size(67, 20);
            this.etDtInicio.TabIndex = 6;
            this.etDtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // etDtFim
            // 
            this.etDtFim.Location = new System.Drawing.Point(236, 80);
            this.etDtFim.Mask = "00/00/0000";
            this.etDtFim.Name = "etDtFim";
            this.etDtFim.Size = new System.Drawing.Size(70, 20);
            this.etDtFim.TabIndex = 7;
            this.etDtFim.ValidatingType = typeof(System.DateTime);
            // 
            // etHorario
            // 
            this.etHorario.Location = new System.Drawing.Point(266, 54);
            this.etHorario.Mask = "00:00";
            this.etHorario.Name = "etHorario";
            this.etHorario.Size = new System.Drawing.Size(40, 20);
            this.etHorario.TabIndex = 8;
            this.etHorario.ValidatingType = typeof(System.DateTime);
            // 
            // etTurma
            // 
            this.etTurma.Location = new System.Drawing.Point(83, 54);
            this.etTurma.Name = "etTurma";
            this.etTurma.Size = new System.Drawing.Size(83, 20);
            this.etTurma.TabIndex = 9;
            // 
            // etCurso
            // 
            this.etCurso.Location = new System.Drawing.Point(83, 28);
            this.etCurso.Name = "etCurso";
            this.etCurso.Size = new System.Drawing.Size(223, 20);
            this.etCurso.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dias da semana";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(410, 135);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastroEdicaoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 161);
            this.Controls.Add(this.btnSalvar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadastroEdicaoCurso";
            this.Text = "(Cadastro/Edição) Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox cbDiasSemana;
        private System.Windows.Forms.MaskedTextBox etDtInicio;
        private System.Windows.Forms.MaskedTextBox etDtFim;
        private System.Windows.Forms.MaskedTextBox etHorario;
        private System.Windows.Forms.TextBox etTurma;
        private System.Windows.Forms.TextBox etCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
    }
}