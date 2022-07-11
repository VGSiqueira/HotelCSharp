using HotelCSharp.Interfaces;

namespace HotelCSharp.models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente()
        {
        }

        public Gerente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public void ArrumarCama()
        {
            System.Console.WriteLine("Sou gerente e sei arrumar a cama.");
            System.Console.WriteLine();
        }

        public void AtenderTelefone()
        {
            System.Console.WriteLine("Sou gerente e sei atender o telefone.");
            System.Console.WriteLine();
        }

        public void ConhecerMuitoBemHotel()
        {
            System.Console.WriteLine("Sou gerente e conheço muito bem o hotel.");
            System.Console.WriteLine();
        }

        public void FalarBasicoIngles()
        {
            System.Console.WriteLine("Sou gerente e sei falar o basico de inglês.");
            System.Console.WriteLine();
        }

        public void LimparQuarto()
        {
            System.Console.WriteLine("Sou gerente e sei limpar o quarto.");
            System.Console.WriteLine();
        }

        public void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou o(a) gerente " + Nome);
            System.Console.WriteLine();
        }
    }
}