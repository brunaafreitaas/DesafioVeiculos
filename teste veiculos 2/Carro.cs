using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Carro : Veiculo, ILimpador, ICapPassageiros
    {
        public double ValorPedagio { get; set; }
        public void PagarPedagio()
        {
            ValorPedagio = 7;
        }

        private int capPassag;
        public int CapacidadePassageiros 
        { 
            get => capPassag;
            set 
            {
                if (value < 1 || value > 5)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }

        public int QtdPortas { get; set; }

        void ILimpador.LigaLimpador() { }
        void ILimpador.DesligaLimpador() { }

        public override string ToString()
        {
            return $"Carro - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Qtd. Portas: {QtdPortas} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
