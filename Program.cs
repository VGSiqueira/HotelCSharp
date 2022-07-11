using System.Linq;
using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;
using HotelCSharp.models;

Console.WriteLine("**************************************************");
Console.WriteLine("****************** Hotel CSharp ******************");
Console.WriteLine("**************************************************");
Console.WriteLine();

ICamareira camareira01 = new Camareira("Arlete Simas", "1234567809", "22999996767");
ICamareira camareira02 = new Camareira("Mariana Simas", "1234567810", "22999994545");

IRecepcionista recepcionista01 = new Recepcionista()
{
    Nome = "Rodrigo Rodrigues",
    CPF = "16156089702",
    Telefone = "2299993434"
};

IRecepcionista recepcionista02 = new Recepcionista()
{
    Nome = "Jéssica Soares",
    CPF = "16156089678",
    Telefone = "2299992233"
};

IGerente gerente01 = new Gerente("Carlos Gomes", "12343234567", "22909099898");
IGerente gerente02 = new Gerente("André Silva", "14343234234", "22909096869");


Hotel hotel = new Hotel("Hotel CSharp", new Endereco("28635-360", "Rua Marcolina da Rosa Pinheiro", 110, "Fundos", "Prado", "Nova Friburgo"));

hotel.ContratarCamareira(camareira01);
hotel.ContratarCamareira(camareira02);

hotel.ContratarRecepcionista(recepcionista01);
hotel.ContratarRecepcionista(recepcionista02);

hotel.ContratarGerente(gerente01);

hotel.ContratarCamareira(gerente02);
hotel.ContratarRecepcionista(gerente02);

hotel.Gerente.SeApresentar();
hotel.Gerente.ArrumarCama();
hotel.Gerente.LimparQuarto();
hotel.Gerente.FalarBasicoIngles();
hotel.Gerente.AtenderTelefone();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
    camareira.ArrumarCama();
    camareira.LimparQuarto();
}

Console.WriteLine("------------------------------");

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
    recepcionista.AtenderTelefone();
    recepcionista.FalarBasicoIngles();
}

Console.WriteLine("------------------------------");

var camareira03 = new Camareira()
{
    Nome = "Eugenia Ferraz"
};

var recepcionista03 = new Recepcionista()
{
    Nome = "Joice Lima",
    CPF = "12332145634",
    Telefone = "2234345676"
};

IRHTerceirizado rh = new RH("RH CSharp", hotel);
rh.ContratarCamareira(camareira03);
rh.ContratarRecepcionista(recepcionista03);

var camareiraASerPromovida = new Camareira()
{
    Nome = "Eugenia Lima"
};

try {
    rh.PromoverParaGerente(camareiraASerPromovida);
}
catch (DocumentosInvalidosExceptions ex) 
{
    Console.WriteLine(ex.Message);
}

var recepcionistaASerPromovida = new Camareira()
{
    Nome = "Amanda Vasconcellos",
    CPF = "19845634590"
};

try {
    rh.PromoverParaGerente(recepcionistaASerPromovida);
}
catch (DocumentosInvalidosExceptions ex) 
{
    Console.WriteLine(ex.Message);
}
