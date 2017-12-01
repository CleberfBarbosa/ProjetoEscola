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
using System.Data.Entity;

namespace EscolaDeFormacaoPUC.Forms
{
    public partial class FormDetalhesCurso : Form
    {
        private Curso curso;
        private EscolaDeFormacaoEntities dbContext;
        public FormDetalhesCurso(Curso curso,  EscolaDeFormacaoEntities dbContext)
        {
            InitializeComponent();
            if (curso != null)
            {
                if (dbContext != null)
                    this.dbContext = dbContext;
                else
                    this.dbContext = new EscolaDeFormacaoEntities();
                this.curso = curso;
                PreencherTela();
            }
            else
            {
                new Exception("Curso inválido");
            }
        }

        private void PreencherTela()
        {
            if(curso.Ativo == "Finalizado")
            {
                btnFinalizarCurso.Enabled = false;
                btnMatricularAlunos.Enabled = false;
            }
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

        private void btnMatricularAlunos_Click(object sender, EventArgs e)
        {
            try
            {
                FormMatricularAlunos form = new FormMatricularAlunos(curso);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir tela de matricula, detalhes: " + ex.Message);
            }
        }

        private void btnVerAlunos_Click(object sender, EventArgs e)
        {
            try
            {
                if (curso != null)
                {
                    List<Aluno> lista = curso.AlunoCurso.Select(n => n.Aluno).ToList();
                    //List<Aluno> lista = dbContext.AlunoCurso.Where(n => n.Curso == curso).Select(n => n.Aluno).ToList();
                    //List<Aluno> lista = (from a in dbContext.Aluno
                    //             join ac in dbContext.AlunoCurso on a.IDAluno equals ac.IDAluno
                    //             where ac.IDCurso == curso.IDCurso select new Aluno { }).ToList();
                    if (lista != null && lista.Count > 0)
                    {
                        FormAlunosMatriculados form = new FormAlunosMatriculados(lista);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Não existem alunos matriculados nesse curso.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir lista de alunos. Detalhes do erro: " + ex.Message);
            }
        }

        private void btnFinalizarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente finalizar o curso?\n" +
                "Essa ação não pode ser desfeita.", "FINALIZAR", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    curso.Ativo = "Finalizado";
                    curso.DataFim = DateTime.Now;
                    dbContext.SaveChanges();
                }
                PreencherTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
