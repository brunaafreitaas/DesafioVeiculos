using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_veiculos_2
{
    public class Pedagio
    {
        private string localizacao;
        public string Localizacao
        {
            get => localizacao;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    localizacao = value;
                else
                    throw new Exception("A localização é obrigatória");
            }
        }

        private string idPedagio;
        public string IDPedagio
        {
            get => idPedagio;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    idPedagio = value;
                else
                    throw new Exception("A identificação do pedágio é obrigatória");
            }
        }

        public void Receber(Veiculo v) 
        {

            if (v is Carro)
                TotalRecebido += (v as Carro).ValorPedagio;
            else if (v is Caminhao)
                TotalRecebido += (v as Caminhao).ValorPedagio;
            else if (v is Moto)
                TotalRecebido += (v as Moto).ValorPedagio;
            else if (v is Onibus)
                TotalRecebido += (v as Onibus).ValorPedagio;
        
        
        }

        public double TotalRecebido { get; set; }

        public override string ToString()
        {
            return $"Pedágio - ID: {IDPedagio} - Localização: {Localizacao} - $ Recebido: {TotalRecebido}";
        }
    }
}
