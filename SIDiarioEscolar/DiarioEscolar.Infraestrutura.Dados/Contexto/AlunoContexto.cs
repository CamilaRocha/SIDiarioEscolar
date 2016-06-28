using DiarioEscolar.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioEscolar.Infraestrutura.Dados.Contexto
{
    public class AlunoContexto : DbContext
    {
        //
        public AlunoContexto() : base("AlunoDb")
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
