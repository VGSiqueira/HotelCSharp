using HotelCSharp.Interfaces;

namespace HotelCSharp.models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira()
        {
        }

        public Camareira(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public void ArrumarCama()
        {
            System.Console.WriteLine("Sei arrumar a cama.");
            System.Console.WriteLine();
        }

        public void LimparQuarto()
        {
            System.Console.WriteLine("Sei limpar o quarto.");
            System.Console.WriteLine();
        }

        public void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou a camareira " + Nome);
            System.Console.WriteLine();
        }


    }
}