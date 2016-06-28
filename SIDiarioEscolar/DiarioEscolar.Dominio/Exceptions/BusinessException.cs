using System;
using System.Runtime.Serialization;

namespace DiarioEscolar.Dominio.Exceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        //
        public BusinessException(string msg) : base(msg)
        {
        }
    }
}