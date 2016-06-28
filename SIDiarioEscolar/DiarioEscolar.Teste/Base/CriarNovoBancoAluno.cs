using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using DiarioEscolar.Infraestrutura.Dados.Contexto;
using DiarioEscolar.Dominio.Entidade;

namespace DiarioEscolar.Teste.Base
{
    public class CriarNovoBancoAluno<T> : DropCreateDatabaseAlways<AlunoContexto>
    {
        //
        protected override void Seed(AlunoContexto context)
        {
            for (int i = 0; i < 10; i++)
            {
                Aluno aluno = new Aluno(Turma.EnsinoSuperior,
                                        "Alice",
                                        "Blábláblá",
                                        22,
                                        8.8,
                                        Status.Aprovado);
                context.Alunos.Add(aluno);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
