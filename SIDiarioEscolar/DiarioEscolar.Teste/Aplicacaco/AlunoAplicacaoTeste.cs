using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiarioEscolar.Dominio.Entidade;
using Moq;
using DiarioEscolar.Dominio.Contratos;
using DiarioEscolar.Aplicacao;

namespace DiarioEscolar.Teste.Aplicacaco
{
    [TestClass]
    public class AlunoAplicacaoTeste
    {
        //
        [TestMethod]
        public void CriarAlunoAplicacaoTeste()
        {
            Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                    "João",
                                    "hehehe",
                                    19,
                                    7,
                                    Status.Aprovado);

            var repositorioFake = new Mock<IAlunoRepositorio>();
            repositorioFake.Setup(x => x.Adicionar(aluno)).Returns(new Aluno());

            IAlunoAplicacao servico = new AlunoAplicacao(repositorioFake.Object);
            Aluno novoAluno = servico.Adicionar(aluno);

            repositorioFake.Verify(x => x.Adicionar(aluno));
        }

        [TestMethod]
        public void AtualizarAlunoAplicacaoTeste()
        {
            Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                    "João",
                                    "hehehe",
                                    19,
                                    7,
                                    Status.Aprovado);

            var repositorioFake = new Mock<IAlunoRepositorio>();
            repositorioFake.Setup(x => x.Atualizar(aluno)).Returns(new Aluno());

            IAlunoAplicacao servico = new AlunoAplicacao(repositorioFake.Object);
            Aluno atualizaAluno = servico.Atualizar(aluno);

            repositorioFake.Verify(x => x.Atualizar(aluno));
        }

        [TestMethod]
        public void DeletarAlunoAplicacaoTeste()
        {
            Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                    "João",
                                    "hehehe",
                                    19,
                                    7,
                                    Status.Aprovado);

            var repositorioFake = new Mock<IAlunoRepositorio>();
            repositorioFake.Setup(x => x.Deletar(aluno));

            IAlunoAplicacao servico = new AlunoAplicacao(repositorioFake.Object);
            servico.Deletar(aluno);

            repositorioFake.Verify(x => x.Deletar(aluno));

        }

        [TestMethod]
        public void BuscarAlunoAplicacaoTeste()
        {
            Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                    "João",
                                    "hehehe",
                                    19,
                                    7,
                                    Status.Aprovado);

            var repositorioFake = new Mock<IAlunoRepositorio>();
            repositorioFake.Setup(x => x.Buscar(aluno.Id));

            IAlunoAplicacao servico = new AlunoAplicacao(repositorioFake.Object);
            Aluno buscarAluno = servico.Buscar(aluno.Id);

            repositorioFake.Verify(x => x.Buscar(aluno.Id));
        }

        [TestMethod]
        public void BuscarTodosOsAlunosAplicacaoTeste()
        {
            Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                    "João",
                                    "hehehe",
                                    19,
                                    7,
                                    Status.Aprovado);

            var repositorioFake = new Mock<IAlunoRepositorio>();
            repositorioFake.Setup(x => x.BuscarTodos());

            IAlunoAplicacao servico = new AlunoAplicacao(repositorioFake.Object);
            servico.BuscarTodos();

            repositorioFake.Verify(x => x.BuscarTodos());
        }
    }
}
