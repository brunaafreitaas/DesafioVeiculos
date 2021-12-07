using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Trem : Veiculo, ILimpador, ICapPassageiros
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

        private int vagoes;
        public int QtdVagoes
        {
            get => vagoes;
            set
            {
                if (value < 1)
                    throw new Exception("Todo trem tem no mínimo 1 vagão!");
                else
                    vagoes = value;
            }
        }

        public override string ToString()
        {
            return $"Trem - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Qtd. Vagões: {QtdVagoes} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
