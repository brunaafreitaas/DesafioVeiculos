using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    class Caminhao : Veiculo, ILimpador, ICapPassageiros
    {
        private int capPassag;
        public int CapacidadePassageiros
        { 
            get => capPassag;
            set 
            {
                if (value < 1 || value > 3)
                    throw new Exception("Capacidade de passageiros inválida!");
                else
                    capPassag = value;
            }
        }
        

        void ILimpador.LigaLimpador() { }
        void ILimpador.DesligaLimpador() { }
        public void PagarPedagio()
        {
            ValorPedagio = 8.5 * QtdEixos;
        }

        public double ValorPedagio { get; set; }

        private double pesoCarregado;
        public double PesoCarregado
        {
            get => pesoCarregado;
            set
            {
                if (value < 0)
                    throw new Exception("O peso não pode ser negativo!");
                else
                    pesoCarregado = value;
            }
        }

        private int eixos;
        public int QtdEixos
        {
            get => eixos;
            set
            {
                if (value < 2)
                    throw new Exception("Todo caminhão tem no mínimo 2 eixos");
                else
                    eixos = value;
            }
        }

        private double pesoMaximo;
        public double PesoMaximo
        {
            get => pesoMaximo;
            set
            {
                if (value < 0)
                    throw new Exception("A carga máxima não pode ser menor que zero!");
                else
                    pesoMaximo = value;
            }
        }

        public void Descarregar()
        {
            pesoCarregado = 0;
        }

        public void Carregar(double peso)
        {
            pesoCarregado += peso;
        }

        public override string ToString()
        {
            return $"Caminhão - ID: {ID} - Velocidade: {Velocidade} - Cap. Passageiros: {CapacidadePassageiros} - Qtd. Eixos: {QtdEixos} - Peso Carregado: {PesoCarregado} - Peso Máximo: {PesoMaximo} - Marca: {ModeloVeiculo.Marca.Nome} - Modelo: {ModeloVeiculo.Nome}";
        }
    }
}
