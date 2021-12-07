using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Onibus : Veiculo, ILimpador, ICapPassageiros
    {
        private int capPassag;
        public int CapacidadePassageiros
        {
            get => capPassag;
            set
            {
                if (value < 1 || value > 60)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }
        void ILimpador.LigaLimpador() { }
        void ILimpador.DesligaLimpador() { }

        public bool Leito { get; set; }

        private int eixos;
        public int QtdEixos
        {
            get => eixos;
            set
            {
                if (value < 2)
                    throw new Exception("Todo ônibus tem no mínimo 2 eixos");
                else
                    eixos = value;
            }
        }
        public double ValorPedagio { get; set; }
        public void PagarPedagio()
        {
            ValorPedagio = QtdEixos*8.5;
        }

        public override string ToString()
        {
            return $"Ônibus - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Qtd. Eixos: {QtdEixos} - Leito: {Leito} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
