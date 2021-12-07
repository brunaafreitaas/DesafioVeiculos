using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Navio : Veiculo, ICapPassageiros
    {
        public string Atracar() { return $"Navio '{ID}' atracou!"; }

        private int capPassag;
        public int CapacidadePassageiros
        {
            get => capPassag;
            set
            {
                if (value < 1 || value > 1000)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }

        public override string ToString()
        {
            return $"Navio - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }

    }
}
