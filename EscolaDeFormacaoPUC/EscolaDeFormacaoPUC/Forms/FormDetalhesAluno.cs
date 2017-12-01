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
    public partial class FormDetalhesAluno : Form
    {
        private Aluno aluno;
        public FormDetalhesAluno(Aluno aluno)
        {
            InitializeComponent();
            if (aluno != null)
            {
                this.aluno = aluno;
                PreencherTela();
            }
            else
            {
                MessageBox.Show("Erro ao carregar aluno.");
                this.Close();
            }
        }

        private void PreencherTela()
        {
            txtNomeAluno.Text = aluno.Nome;
            txtRGAluno.Text = aluno.RG;
            txtCPFAluno.Text = aluno.CPF;
            txtNascimento.Text = aluno.DataNascimento.ToString("dd/MM/yyyy");
            txtEscolaridade.Text = aluno.Escolaridade;
            txtEnd.Text = aluno.Endereco;
            txtFoneCel.Text = aluno.FoneCelular;
            txtFoneFixo.Text = aluno.FoneCelular;
            txtNomeResp.Text = aluno.Responsavel.Nome;
            txtRGResp.Text = aluno.Responsavel.RG;
            txtCPFResp.Text = aluno.Responsavel.CPF;
            txtParentesco.Text = aluno.Responsavel.Parentesco;
        }

        private void btnCursosMatriculados_Click(object sender, EventArgs e)
        {
            try
            {
                FormCursosAlunoMatriculado form = new FormCursosAlunoMatriculado(aluno);
                form.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao abrir cursos matriculados. Detalhes do erro: " + ex.Message);
            }
        }
    }
}
