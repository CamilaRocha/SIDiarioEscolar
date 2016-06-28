using DiarioEscolar.Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioEscolar.Dominio.Entidade
{
    public class Aluno
    {
        public Aluno()
        {

        }
        //
        public Aluno(Turma turma, string nome, string sobrenome, int idade, double nota, Status status)
        {
            if (string.IsNullOrEmpty(nome.Trim()))
            {
                throw new BusinessException("O nome do aluno está vazio!");
            }

            this.Turma = turma;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Nota = nota;
            this.Status = status;
        }

        public int Id { get; set; }

        public Turma Turma { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public double Nota { get; set; }

        public Status Status { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", Turma, Nome, Sobrenome, Idade, Nota, Status);
        }
    }
}
