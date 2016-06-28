using DiarioEscolar.Aplicacao;
using DiarioEscolar.Dominio.Contratos;
using DiarioEscolar.Dominio.Entidade;
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
    public partial class FormAddAluno : Form
    {
        private readonly IAlunoAplicacao _alunoAplicacao;
        private Aluno _aluno;
        private bool editMode;

        public FormAddAluno(IAlunoRepositorio repositorio)
        {
            editMode = false;
            InitializeComponent();
            _alunoAplicacao = new AlunoAplicacao(repositorio);

            RefreshTurma();
            RefreshStatus();
        }
        public FormAddAluno(IAlunoRepositorio repositorio, Aluno aluno) : this(repositorio)
        {
            editMode = true;
            _aluno = aluno;
            cbxTurma.Text = _aluno.Turma.ToString();
            txtNome.Text = _aluno.Nome;
            txtSobrenome.Text = _aluno.Sobrenome;
            txtIdade.Text = _aluno.Idade.ToString();
            txtIdade.Text = _aluno.Nota.ToString();
            cbxTurma.Text = _aluno.Status.ToString();
        }

        private void RefreshTurma()
        {
            cbxTurma.DataSource = Enum.GetNames(typeof(Turma));
        }

        private void RefreshStatus()
        {
            cbxStatus.DataSource = Enum.GetNames(typeof(Status));
        }

        public FormAddAluno()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                var aluno = new Aluno((Turma)Enum.Parse(typeof(Turma), cbxTurma.Text),
                                        txtNome.Text,
                                        txtSobrenome.Text,
                                        int.Parse(txtIdade.Text),
                                        double.Parse(txtNota.Text),
                                        (Status)Enum.Parse(typeof(Status), cbxStatus.Text));                                      ;
                _alunoAplicacao.Adicionar(aluno);
            }

            else
            {
                var aluno = _alunoAplicacao.Buscar(_aluno.Id);
                aluno.Turma = (Turma)Enum.Parse(typeof(Turma), cbxTurma.Text);
                aluno.Nome = txtNome.Text;
                aluno.Sobrenome = txtSobrenome.Text;
                aluno.Idade = int.Parse(txtIdade.Text);
                aluno.Nota = double.Parse(txtNota.Text);
                aluno.Status = (Status)Enum.Parse(typeof(Status), cbxStatus.Text);
                _alunoAplicacao.Atualizar(aluno);
            }
            Close();
        }
    }
}
