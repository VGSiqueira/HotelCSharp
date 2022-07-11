namespace HotelCSharp.models
{
    public class Endereco
    {
        public string CEP {get; set;}
        public string Rua {get; set;}
        public int Numero {get; set;}
        public string Complemento {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}

        public Endereco(string cep, string rua, int numero, string complemento, string bairro, string cidade)
        {
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}