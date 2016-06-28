using DiarioEscolar.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiarioEscolar.Dominio.Entidade;
using DiarioEscolar.Infraestrutura.Dados.Contexto;

namespace DiarioEscolar.Infraestrutura.Dados.Repositorios
{
    //
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private AlunoContexto _contexto;

        public AlunoRepositorio()
        {
            _contexto = new AlunoContexto();
        }

        public Aluno Adicionar(Aluno aluno)
        {
            var resultado = _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();
            return resultado;
        }

        public Aluno Atualizar(Aluno aluno)
        {
            var entry = _contexto.Entry<Aluno>(aluno);
            entry.State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();

            return aluno; 
        }

        public Aluno Buscar(int id)
        {
            return _contexto.Alunos.Find(id);
        }

        public List<Aluno> BuscarTodos()
        {
            return _contexto.Alunos.ToList();
        }

        public void Deletar(Aluno aluno)
        {
            var entry = _contexto.Entry<Aluno>(aluno);
            entry.State = System.Data.Entity.EntityState.Deleted;
            _contexto.SaveChanges();
        }
    }
}
