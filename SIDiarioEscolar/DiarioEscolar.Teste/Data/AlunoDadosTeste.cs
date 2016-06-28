using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiarioEscolar.Infraestrutura.Dados.Contexto;
using DiarioEscolar.Dominio.Contratos;
using System.Data.Entity;
using DiarioEscolar.Teste.Base;
using DiarioEscolar.Infraestrutura.Dados.Repositorios;
using DiarioEscolar.Dominio.Entidade;
using System.Collections.Generic;

namespace DiarioEscolar.Teste.Data
{
    //
    [TestClass]
    public class AlunoDadosTeste
    {
        private AlunoContexto _contexto;

        private IAlunoRepositorio _repositorio;

        [TestInitialize]

        public void Initialize()
        {
            Database.SetInitializer(new CriarNovoBancoAluno<AlunoContexto>());

            _contexto = new AlunoContexto();
            _repositorio = new AlunoRepositorio();

            _contexto.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        [TestMethod]
        public void CriarAlunoRepositorioTeste()
        {
            Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                    "Maria",
                                    "Blablabla",
                                    20,
                                    6,
                                    Status.Reprovado);

            _contexto.Alunos.Add(aluno);

            _repositorio.Adicionar(aluno);

            Aluno novoAluno = _contexto.Alunos.Find(aluno.Id);

            Assert.IsTrue(novoAluno.Id > 0);
        }

        [TestMethod]
        public void BuscarAlunoRepositorioTeste()
        {
            Aluno aluno = _repositorio.Buscar(1);

            Assert.IsNotNull(aluno);
        }

        [TestMethod]
        public void BuscarTodosOsAlunosRepositorioTeste()
        {
            List<Aluno> alunos = _repositorio.BuscarTodos();

            Assert.AreEqual(10, alunos.Count);
        }

        [TestMethod]
        public void AtualizarAlunoRepositorioTeste()
        {
            Aluno aluno = _contexto.Alunos.Find(1);

            aluno.Nota = 6.5;
            aluno.Status = Status.Reprovado;

            Aluno alunoAtualizado = _contexto.Alunos.Find(1);
            Assert.AreEqual(6.5, alunoAtualizado.Nota);
            Assert.AreEqual(Status.Reprovado, alunoAtualizado.Status);
        }

        [TestMethod]
        public void RemoverAlunoRepositorioTeste()
        {
            Aluno aluno = _repositorio.Buscar(1);

            _repositorio.Deletar(aluno);

            Aluno alunoDeletado = _contexto.Alunos.Find(1);

            Assert.IsNull(alunoDeletado);
        }
    }
}
