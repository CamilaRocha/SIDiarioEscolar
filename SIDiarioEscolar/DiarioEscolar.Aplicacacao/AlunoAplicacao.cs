using DiarioEscolar.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiarioEscolar.Dominio.Entidade;

namespace DiarioEscolar.Aplicacao
{
    public class AlunoAplicacao : IAlunoAplicacao
    {
        private IAlunoRepositorio _repositorio;

        public AlunoAplicacao(IAlunoRepositorio repositorio)
        { 
            _repositorio = repositorio;
        }

        public Aluno Adicionar(Aluno aluno)
        {
            Aluno novoAluno = _repositorio.Adicionar(aluno);

            return novoAluno;
        }

        public Aluno Buscar(int id)
        {
            return _repositorio.Buscar(id);
        }

        public List<Aluno> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public Aluno Atualizar(Aluno aluno)
        {
            Aluno atualizarAluno = _repositorio.Atualizar(aluno);

            return atualizarAluno;
        }

        public void Deletar(Aluno aluno)
        {
            _repositorio.Deletar(aluno);
        }
    }
}
