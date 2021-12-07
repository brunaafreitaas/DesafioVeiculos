using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Moto : Veiculo, ICapPassageiros
    {
        private int capPassag;
        public int CapacidadePassageiros
        {
            get => capPassag;
            set
            {
                if (value < 1 || value > 2)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }
        public double ValorPedagio { get; set; }
        
        public void PagarPedagio()
        {
            ValorPedagio = 3;
        }

        public string Empinar() 
        {
            return $"Moto '{ID}' empinando! Chama no grau!";
        }

        public override string ToString()
        {
            return $"Moto - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
