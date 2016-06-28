using DiarioEscolar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioEscolar.Dominio.Contratos
{
    public interface IAlunoRepositorio
    {
        //
        Aluno Adicionar(Aluno aluno);

        Aluno Buscar(int id);

        List<Aluno> BuscarTodos();

        Aluno Atualizar(Aluno aluno);

        void Deletar(Aluno aluno);
    }
}
