using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;

namespace HotelCSharp.models
{
    public class RH : IRHTerceirizado
    {

        public string Nome {get; set;}
        public Hotel Hotel {get; set;}

        public RH(string nome, Hotel hotel)
        {
            Nome = nome;
            Hotel = hotel;
        }

        public void ContratarCamareira(ICamareira camareira)
        {
            Hotel.Camareiras.Add(camareira);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Hotel.Recepcionistas.Add(recepcionista);
        }

        public void PromoverParaGerente(Camareira camareira)
        {
            if(camareira.CPF != null)
            {
            Hotel.ContratarGerente(new Gerente(){
                Nome = camareira.Nome,
                CPF = camareira.CPF,
                Telefone = camareira.Telefone
            });
            } else 
            {
                throw new DocumentosInvalidosExceptions("Regularize seu CPF para receber a promoção.");
            }
        }

        public void PromoverParaGerente(Recepcionista recepcionista)
        {
            if(recepcionista.CPF != null)
            {
            Hotel.ContratarGerente(new Gerente(){
                Nome = recepcionista.Nome,
                CPF = recepcionista.CPF,
                Telefone = recepcionista.Telefone
            });
            } else 
            {
                throw new DocumentosInvalidosExceptions("Regularize seu CPF para receber a promoção.");
            }
        }
    }
}