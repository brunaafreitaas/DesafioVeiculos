using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Aviao : Veiculo, ILimpador, ICapPassageiros
    {
        private int capPassag;
        public int CapacidadePassageiros
        {
            get => capPassag;
            set
            {
                if (value < 1 || value > 200)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }
        void ILimpador.LigaLimpador() { }
        void ILimpador.DesligaLimpador() { }
        public string Arremeter() { return $"Avião '{ID}' arremeteu!"; }
        public string Decolar() { return $"Avião '{ID}' decolou!"; }
        public string Pousar() { return $"Avião '{ID}' pousou!"; }

        public override string ToString()
        {
            return $"Avião - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
