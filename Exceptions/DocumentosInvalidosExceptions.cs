using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelCSharp.Exceptions
{
    public class DocumentosInvalidosExceptions : Exception
    {
        public DocumentosInvalidosExceptions() : base("Documentos inválidos, verifique!")
        {
        }

        public DocumentosInvalidosExceptions(string mensagem) : base(mensagem)
        {
        }
    }
}