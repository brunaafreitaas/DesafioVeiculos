using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class AviaoGuerra : Veiculo, ICapPassageiros
    {
        private int capPassag;
        public int CapacidadePassageiros
        {
            get => capPassag;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }
        public string Arremeter() { return $"Avião de Guerra '{ID}' arremeteu!"; }
        public string Decolar() { return $"Avião de Guerra '{ID}' decolou!"; }
        public string Pousar() { return $"Avião de Guerra '{ID}' pousou!"; }
        public string Atacar() { return $"Avião de Guerra '{ID}' atacando!"; }

        public override string ToString()
        {
            return $"Avião de Guerra - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
