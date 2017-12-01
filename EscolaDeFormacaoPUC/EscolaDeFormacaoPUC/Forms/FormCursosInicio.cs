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
    public partial class FormCursosInicio : Form
    {
        private List<Curso> cursos;
        private EscolaDeFormacaoEntities dbContext = new EscolaDeFormacaoEntities();

        public FormCursosInicio()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            try
            {
                cursos = dbContext.Curso.ToList();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCadastroEdicaoCurso form = new FormCadastroEdicaoCurso(null, this, dbContext);
            form.ShowDialog();
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cursos[GetIndex()] != null)
                {
                    if(cursos[GetIndex()].Ativo != "Finalizado")
                    {
                        FormCadastroEdicaoCurso form = new FormCadastroEdicaoCurso(cursos[GetIndex()], this, dbContext);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Curso já foi finalizado, não é possível edita-lo.");
                    }
                }
                else
                {
                    MessageBox.Show("Valor nulo, atualize a lista!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = cursos[GetIndex()];
                if (curso != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o Curso?\n" +
                    "Todas as matrículas desse curso serão perdidas." +
                    "Essa ação não pode ser desfeita.", "EXCLUIR", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dbContext.AlunoCurso.RemoveRange(curso.AlunoCurso);
                        dbContext.Curso.Remove(curso);
                        dbContext.SaveChanges();
                        AtualizarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            try
            {
                FormDetalhesCurso form = new FormDetalhesCurso(cursos[GetIndex()], dbContext);
                form.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
