using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    public abstract class Veiculo
    {
        private string id;

        public int Velocidade { get; set; }
        public string ID
        {
            get => id;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    id = value;
                else
                    throw new Exception("A identificação do veículo é obrigatória!");
            }
        }
        public Modelo ModeloVeiculo { get; set; }

        public void Acelerar()
        {
            Velocidade += 1;
        }
        public void Desacelerar()
        {
            Velocidade -= 1;
        }

    }
}
