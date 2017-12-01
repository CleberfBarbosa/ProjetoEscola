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
    public partial class FormCursosAlunoMatriculado : Form
    {
        private EscolaDeFormacaoEntities dbContext = new EscolaDeFormacaoEntities();
        private Aluno aluno;
        private List<Curso> cursos;
        public FormCursosAlunoMatriculado(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
            PreencherGrid();
        }

        public void PreencherGrid()
        {
            try
            {
                cursos = aluno.AlunoCurso.Select(n => n.Curso).ToList();
                if (cursos != null && cursos.Count > 0)
                {
                    dataGridViewCursos.DataSource = cursos;
                    dataGridViewCursos.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetIndex()
        {
            return dataGridViewCursos.DataSource != null ? dataGridViewCursos.CurrentCell.RowIndex : -1;
        }

        private void btnDesmatricular_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = cursos[GetIndex()];
                if (curso != null && curso.Ativo != "Finalizado")
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja realmente cancelar a matrícula?", "SIM", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var aux = aluno.AlunoCurso.Where(n => n.IDCurso == curso.IDCurso).FirstOrDefault();
                        dbContext.AlunoCurso.Remove(aux);
                        dbContext.SaveChanges();
                        PreencherGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Curso já foi finalizado, não é possível cancelar matricula.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
