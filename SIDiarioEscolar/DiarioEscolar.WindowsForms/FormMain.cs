using DiarioEscolar.Aplicacao;
using DiarioEscolar.Dominio.Contratos;
using DiarioEscolar.Dominio.Entidade;
using DiarioEscolar.Infraestrutura.Dados.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiarioEscolar.WindowsForms
{
    public partial class FormMain : Form
    {
        private List<Aluno> _alunos;
        private readonly IAlunoAplicacao _servico;
        private IAlunoRepositorio _repositorio = new AlunoRepositorio();

        public FormMain()
        {
            InitializeComponent();
            _servico = new AlunoAplicacao(_repositorio);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                dgvAlunos.DataSource = _alunos;
                dgvAlunos.Refresh();
            }
        }

        private void RefreshView()
        {
            _alunos = _servico.BuscarTodos();
            dgvAlunos.DataSource = null;
            dgvAlunos.DataSource = _alunos;
            dgvAlunos.Refresh();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvAlunos.DataSource = _alunos;
                dgvAlunos.Refresh();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var aluno = (Aluno)dgvAlunos.SelectedRows[0].DataBoundItem;
            _servico.Deletar(aluno);
            RefreshView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormAddAluno formAddAluno = new FormAddAluno(_repositorio, (Aluno)dgvAlunos.SelectedRows[0].DataBoundItem);
            formAddAluno.ShowDialog();
            RefreshView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddAluno formAddAluno = new FormAddAluno(_repositorio);
            formAddAluno.ShowDialog();
            RefreshView();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
