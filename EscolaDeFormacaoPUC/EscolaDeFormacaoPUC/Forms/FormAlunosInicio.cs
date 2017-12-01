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
    public partial class FormAlunosInicio : Form
    {
        private List<Aluno> alunos;
        private EscolaDeFormacaoEntities dbContext = new EscolaDeFormacaoEntities();
        public FormAlunosInicio()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        public void AtualizarGrid()
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCadastroEdicaoAluno form = new FormCadastroEdicaoAluno(null, this, dbContext);
            form.ShowDialog();
        }

        private int getIndex()
        {
            try
            {
                return dataGridViewAluno.DataSource != null ? dataGridViewAluno.CurrentCell.RowIndex : -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if(getIndex() >= 0 && getIndex() < alunos.Count)
            {
                FormCadastroEdicaoAluno form = new FormCadastroEdicaoAluno(alunos[getIndex()], this, dbContext);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione alguma linha para executar essa ação.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (getIndex() >= 0 && getIndex() < alunos.Count)
            {
                Aluno aluno = alunos[getIndex()];
                DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o aluno?\n" +
                "Essa ação não pode ser desfeita.", "EXCLUIR", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dbContext.AlunoCurso.RemoveRange(aluno.AlunoCurso);
                    dbContext.Responsavel.Remove(aluno.Responsavel);
                    dbContext.Aluno.Remove(aluno);
                    dbContext.SaveChanges();
                    AtualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione alguma linha para executar essa ação.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (getIndex() >= 0 && getIndex() < alunos.Count)
            {
                FormDetalhesAluno form = new FormDetalhesAluno(alunos[getIndex()]);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione alguma linha para executar essa ação.");
            }
        }
    }
}
