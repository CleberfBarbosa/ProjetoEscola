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
    public partial class FormMatricularAlunos : Form
    {
        private EscolaDeFormacaoEntities dbContext = new EscolaDeFormacaoEntities();
        private Curso curso;
        private List<Aluno> alunos;
        public FormMatricularAlunos(Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
            PopularGrid();
        }

        public void PopularGrid()
        {
            try
            {
                alunos = dbContext.Aluno.ToList();
                if (alunos != null && alunos.Count > 0)
                {
                    dataGridViewAluno.DataSource = alunos;
                    dataGridViewAluno.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetIndex()
        {
            try
            {
                return dataGridViewAluno.DataSource != null ? dataGridViewAluno.CurrentCell.RowIndex : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetIndex() >= 0 && GetIndex() < alunos.Count)
                {
                    AlunoCurso alunoCurso = new AlunoCurso();
                    alunoCurso.Aluno = alunos[GetIndex()];
                    alunoCurso.IDCurso = curso.IDCurso;
                    alunoCurso.DataMatricula = DateTime.Now;
                    dbContext.AlunoCurso.Add(alunoCurso);
                    dbContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Selecione alguma linha para executar essa ação.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar realizar matricula, detalhes do erro: " + ex.Message);
            }            
        }
    }
}
