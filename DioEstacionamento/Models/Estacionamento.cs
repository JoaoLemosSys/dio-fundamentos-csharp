using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Estacionamento.Models
{
    public class Estacionamento
    {
        private float ValorInicial = 0;
        private float ValorPorHora = 0;

        List<String> Veiculos = new List<string>();

        public Estacionamento(float valorInicial, float valorPorHora)
        {
            this.ValorInicial = valorInicial;
            this.ValorPorHora = valorPorHora;

        }

        public void Incluir(String placa)
        {
            Veiculos.Add(placa);

        }

        public void Remover(String placa)
        {
            this.Veiculos.Remove(placa);
        }

        public void Listar()
        {

            if (Veiculos.Count > 0)
            {
                foreach (var item in Veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Nenhum veiculo estacionado.");
            }
        }

        public double Calcular(float horasEstacionadas)
        {
            return this.ValorInicial + (horasEstacionadas * this.ValorPorHora);
        }

    }
}