using HotelCSharp.Interfaces;

namespace HotelCSharp.models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public void AtenderTelefone()
        {
            System.Console.WriteLine("Sei atender o telefone.");
            System.Console.WriteLine();
        }

        public void FalarBasicoIngles()
        {
            System.Console.WriteLine("Sei falar o basico de ingles.");
            System.Console.WriteLine();
        }

        public void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou o(a) recepcionista " + Nome);
            System.Console.WriteLine();
        }
    }
}