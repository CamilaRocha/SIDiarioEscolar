using DiarioEscolar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioEscolar.Aplicacao
{
    public interface IAlunoAplicacao
    {
        //
        Aluno Adicionar(Aluno aluno);

        Aluno Buscar(int id);

        List<Aluno> BuscarTodos();

        Aluno Atualizar(Aluno aluno);

        void Deletar(Aluno aluno);
    }
}
