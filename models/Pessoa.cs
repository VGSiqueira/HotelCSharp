using HotelCSharp.Interfaces;

namespace HotelCSharp.models
{
    public abstract class Pessoa : IPessoa
    {

        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}

        protected Pessoa()
        {
        }

        protected Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public virtual void SeApresentar()
        {
            Console.WriteLine("Sou a pessoa " + Nome);
        }
    }
}