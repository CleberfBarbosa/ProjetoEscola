using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolaDeFormacaoPUC.Persistencia;

namespace EscolaDeFormacaoPUC.Forms
{
    public partial class FormCadastroEdicaoAluno : Form
    {
        private EscolaDeFormacaoEntities dbContext;
        private FormAlunosInicio form;
        private Aluno aluno;
        public FormCadastroEdicaoAluno(Persistencia.Aluno aluno, FormAlunosInicio form, EscolaDeFormacaoEntities dbContext)
        {
            InitializeComponent();
            if (aluno != null)
            {
                this.aluno = aluno;
                btnLimpar.Enabled = false;
                PreencherTela();
            }
            else
            {
                this.aluno = new Aluno();
                this.aluno.Responsavel = new Responsavel();
            }
            this.form = form;
            this.dbContext = dbContext;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aluno == null)
                    btnLimpar.Enabled = false;
                aluno.Nome = txtNomeAluno.Text.ToString();
                aluno.RG = txtRGAluno.Text.ToString();
                aluno.CPF = txtCPFAluno.Text.ToString();
                aluno.DataNascimento = DateTime.Parse(txtNascimento.Text.ToString());
                aluno.Escolaridade = txtEscolaridade.Text.ToString();
                aluno.Endereco = txtEnd.Text.ToString();
                aluno.FoneCelular = txtFoneCel.Text.ToString();
                aluno.FoneFixo = txtFoneFixo.Text.ToString();
                aluno.Responsavel.Nome = txtNomeResp.Text.ToString();
                aluno.Responsavel.RG = txtRGResp.Text.ToString();
                aluno.Responsavel.CPF = txtCPFResp.Text.ToString();
                aluno.Responsavel.Parentesco = txtParentesco.Text.ToString();
                if (aluno.IDAluno == 0)
                {
                    dbContext.Aluno.Add(aluno);
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.SaveChanges();    
                }
                form.AtualizarGrid();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Text = "";
            txtRGAluno.Text = "";
            txtCPFAluno.Text = "";
            txtNascimento.Text = "";
            txtEscolaridade.Text = "";
            txtEnd.Text = "";
            txtFoneCel.Text = "";
            txtFoneFixo.Text = "";
            txtNomeResp.Text = "";
            txtRGResp.Text = "";
            txtCPFResp.Text = "";
            txtParentesco.Text = "";
        }
    }
}
