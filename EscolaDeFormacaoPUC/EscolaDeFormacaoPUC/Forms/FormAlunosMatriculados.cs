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
    public partial class FormAlunosMatriculados : Form
    {
        private List<Aluno> alunos;
        public FormAlunosMatriculados(List<Aluno> alunos)
        {
            InitializeComponent();
            this.alunos = alunos;
            if (alunos != null && alunos.Count > 0)
                PopularGrid();
            else
                Close();
        }

        public void PopularGrid()
        {
            dataGridViewAlunosMatriculados.DataSource = alunos;
            dataGridViewAlunosMatriculados.Refresh();
        }
    }
}
