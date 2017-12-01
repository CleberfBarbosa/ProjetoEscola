using EscolaDeFormacaoPUC.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaDeFormacaoPUC.Forms
{
    public partial class FormCadastroEdicaoCurso : Form
    {
        private Curso curso;
        private FormCursosInicio form;
        private EscolaDeFormacaoEntities dbContext;

        public FormCadastroEdicaoCurso(Curso curso, FormCursosInicio form, EscolaDeFormacaoEntities dbContext)
        {
            InitializeComponent();
            if (curso != null)
            {
                this.curso = curso;
                PreencherTela();
            }
            else
            {
                this.curso = new Curso();
            }
            this.form = form;
            this.dbContext = dbContext;
        }

        private void PreencherTela()
        {
            etCurso.Text = curso.Curso1;
            etTurma.Text = curso.Turma;
            etDtInicio.Text = curso.DataInicio.ToString("dd/MM/yyyy");
            etDtFim.Text = curso.DataFim.ToString("dd/MM/yyyy");
            etHorario.Text = curso.Horario.Hours.ToString() + ":" + curso.Horario.Minutes.ToString();
            var aux = curso.DiasSemana.Split(';');

            for (int i = 0; i < cbDiasSemana.Items.Count; i++)
            {
                if (aux.Contains(cbDiasSemana.Items[i].ToString()))
                {
                    cbDiasSemana.SetItemChecked(i, true);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                curso.Curso1 = etCurso.Text;
                curso.Turma = etTurma.Text;
                curso.Horario = DateTime.Parse(etHorario.Text.ToString()).TimeOfDay;
                curso.DataInicio = DateTime.Parse(etDtInicio.Text.ToString());
                curso.DataFim = DateTime.Parse(etDtFim.Text.ToString());
                string dias = "";
                foreach (string dia in cbDiasSemana.CheckedItems)
                {
                    dias += ";" + dia;
                }
                curso.DiasSemana = dias.Substring(1);
                if (curso.IDCurso > 0)
                {
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.Curso.Add(curso);
                    dbContext.SaveChanges();
                }
                if (form != null)
                    form.AtualizarGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
