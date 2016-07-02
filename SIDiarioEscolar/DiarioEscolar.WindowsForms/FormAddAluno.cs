using DiarioEscolar.Aplicacao;
using DiarioEscolar.Dominio.Contratos;
using DiarioEscolar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

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
                TwitterService service = new TwitterService("69d9ZTi1Ur5A8aocRlw6cRRmp", "cLQFsrdmIWJMwodf3ryc1larrROsPWvGbwBuH3KsIZ53LliX9z");

                // Step 1 - Retrieve an OAuth Request Token
                OAuthRequestToken requestToken = service.GetRequestToken();

                // Step 2 - Redirect to the OAuth Authorization URL
                Uri uri = service.GetAuthorizationUri(requestToken);
                Process.Start(uri.ToString());

                // Step 3 - Exchange the Request Token for an Access Token
                string verifier = "7441704"; // <-- This is input into your application by your user
                OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);

                // Step 4 - User authenticates using the Access Token
                service.AuthenticateWith(access.Token, access.TokenSecret);
                //IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions());

                var aluno = new Aluno((Turma)Enum.Parse(typeof(Turma), cbxTurma.Text),
                                        txtNome.Text,
                                        txtSobrenome.Text,
                                        int.Parse(txtIdade.Text),
                                        double.Parse(txtNota.Text),
                                        (Status)Enum.Parse(typeof(Status), cbxStatus.Text)); 
                _alunoAplicacao.Adicionar(aluno);

                //

                Console.WriteLine(service.Response.Response);
                var profile = service.GetUserProfile(new GetUserProfileOptions());


                //foreach (var item in tweets)
                //{
                //    Console.WriteLine("{0} , {1} ", item.Author.ScreenName, item.Text);
                //    Console.WriteLine(tweet);
                //}

                //Console.ReadKey();


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
