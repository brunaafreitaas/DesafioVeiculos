using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_veiculos_2
{
    public partial class Form1 : Form
    {
        List<Veiculo> listaVeiculos = new List<Veiculo>();
        List<Pedagio> listaPedagios = new List<Pedagio>();

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("Veiculos.txt"))
                CarregaArquivo();
            foreach (Pedagio p in listaPedagios)
                cbListaPedagio.Items.Add(p.IDPedagio);
        }
        //carro
        public void CriaCarro()
        {
            Carro car = new Carro();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "VOLKSWAGEN"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Gol",
                Marca = marca
            };

            car.ID = "Car 1";
            car.Velocidade = 50;
            car.CapacidadePassageiros = 4;
            car.QtdPortas = 4;
            car.ModeloVeiculo = modelo;

            listaVeiculos.Add(car);
        }
        //carro
        private void btnCriaCarro_Click_1(object sender, EventArgs e)
        {
            try
            {
                Carro car = new Carro();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaCarro.SelectedIndex,
                    Nome = cbMarcaCarro.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloCarro.SelectedIndex,
                    Nome = cbModeloCarro.Text,
                    Marca = marca
                };

                car.ID = txtIDCarro.Text;
                car.Velocidade = Convert.ToInt32(txtVelocidadeCarro.Text);
                car.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosCarro.Text);
                car.QtdPortas = Convert.ToInt32(cbQtdPorta.Text);
                car.ModeloVeiculo = modelo;

                listaVeiculos.Add(car);
                MessageBox.Show("Carro Cadastrado!");
                LimpaTxts(tabCarro);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //carro
        private void cbMarcaCarros(object sender, EventArgs e)
        {
            txtCodMarcaCarro.Text = cbMarcaCarro.SelectedIndex.ToString();
        }
        //carrro
        private void cbModeloCarros(object sender, EventArgs e)
        {
            txtCodModeloCarro.Text = cbModeloCarro.SelectedIndex.ToString();
        }
        //caminhao
        public void CriaCaminhao()
        {
            Caminhao truck = new Caminhao();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "MERCEDES-BENZ"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Carreta",
                Marca = marca
            };

            truck.ID = "truck 1";
            truck.Velocidade = 32;
            truck.CapacidadePassageiros = 2;
            truck.QtdEixos = 4;
            truck.PesoCarregado = 1000;
            truck.PesoMaximo = 4500;
            truck.ModeloVeiculo = modelo;

            listaVeiculos.Add(truck);
        }
        //caminhao
        private void btnCriaCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                Caminhao truck = new Caminhao();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaCaminhao.SelectedIndex,
                    Nome = cbMarcaCaminhao.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloCaminhao.SelectedIndex,
                    Nome = cbModeloCaminhao.Text,
                    Marca = marca
                };

                truck.ID = txtIDCaminhao.Text;
                truck.Velocidade = Convert.ToInt32(txtVelocidadeCaminhao.Text);
                truck.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosCaminhao.Text);
                truck.QtdEixos = Convert.ToInt32(txtQtdEixosCaminhao.Text);
                truck.PesoCarregado = Convert.ToDouble(txtPesoCarregado.Text);
                truck.PesoMaximo = Convert.ToDouble(txtPesoMax.Text);
                truck.ModeloVeiculo = modelo;

                listaVeiculos.Add(truck);
                MessageBox.Show("Caminhão Cadastrado!");
                LimpaTxts(tabCaminhao);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //caminhao
        private void cbModeloCaminhoes(object sender, EventArgs e)
        {
            txtCodModeloCaminhao.Text = cbModeloCaminhao.SelectedIndex.ToString();
        }
        //caminhao
        private void cbMarcaCaminhoes(object sender, EventArgs e)
        {
            txtCodMarcaCaminhao.Text = cbMarcaCaminhao.SelectedIndex.ToString();
        }
        //onibus
        public void CriaOnibus()
        {
            Onibus bus = new Onibus();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "MERCEDES-BENZ"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Micro",
                Marca = marca
            };

            bus.ID = "Bus 1";
            bus.Velocidade = 40;
            bus.CapacidadePassageiros = 40;
            bus.QtdEixos = 3;
            bus.Leito = false;
            bus.ModeloVeiculo = modelo;

            listaVeiculos.Add(bus);
        }
        //onibus
        private void btnCriaOnibus_Click(object sender, EventArgs e)
        {
            try
            {
                Onibus bus = new Onibus();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaOnibus.SelectedIndex,
                    Nome = cbMarcaOnibus.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloOnibus.SelectedIndex,
                    Nome = cbModeloOnibus.Text,
                    Marca = marca
                };

                bus.ID = txtIDOnibus.Text;
                bus.Velocidade = Convert.ToInt32(txtVelocidadeOnibus.Text);
                bus.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosOnibus.Text);
                bus.QtdEixos = Convert.ToInt32(txtQtdEixosOnibus.Text);
                bus.Leito = Convert.ToBoolean(cbLeitoOnibus.Text);
                bus.ModeloVeiculo = modelo;

                listaVeiculos.Add(bus);
                MessageBox.Show("Ônibus Cadastrado!");
                LimpaTxts(tabOnibus);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //onibus
        private void cbMarcaOnibuss(object sender, EventArgs e)
        {
            txtCodMarcaOnibus.Text = cbMarcaOnibus.SelectedIndex.ToString();

        }
        //onibus
        private void cbModeloOnibuss(object sender, EventArgs e)
        {
            txtCodModeloOnibus.Text = cbModeloOnibus.SelectedIndex.ToString();

        }
        //moto
        public void CriaMoto()
        {
            Moto motoca = new Moto();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "DUCATTI"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Trail",
                Marca = marca
            };

            motoca.ID = "Motoca 1";
            motoca.Velocidade = 100;
            motoca.CapacidadePassageiros = 2;
            motoca.ModeloVeiculo = modelo;

            listaVeiculos.Add(motoca);
        }
        //moto
        private void cbMarcaMotos(object sender, EventArgs e)
        {
            txtCodMarcaMoto.Text = cbMarcaMoto.SelectedIndex.ToString();
        }
        //moto
        private void cbModeloMotos(object sender, EventArgs e)
        {
            txtCodModeloMoto.Text = cbModeloMoto.SelectedIndex.ToString();
        }
        //moto
        private void btnCriaMoto_Click(object sender, EventArgs e)
        {
            try
            {
                Moto motoca = new Moto();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaMoto.SelectedIndex,
                    Nome = cbMarcaMoto.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloMoto.SelectedIndex,
                    Nome = cbModeloMoto.Text,
                    Marca = marca
                };

                motoca.ID = txtIDMoto.Text;
                motoca.Velocidade = Convert.ToInt32(txtVelocidadeMoto.Text);
                motoca.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosMoto.Text);
                motoca.ModeloVeiculo = modelo;

                listaVeiculos.Add(motoca);
                MessageBox.Show("Moto Cadastrada!");
                LimpaTxts(tabMoto);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //aviao
        public void CriaAviao()
        {
            Aviao plane = new Aviao();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "EMBRAER"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Cargueiro",
                Marca = marca
            };

            plane.ID = "Plane 1";
            plane.Velocidade = 400;
            plane.CapacidadePassageiros = 40;
            plane.ModeloVeiculo = modelo;

            listaVeiculos.Add(plane);
        }
        //aviao
        private void cbMarcaAvioes(object sender, EventArgs e)
        {
            txtCodMarcaAviao.Text = cbMarcaAviao.SelectedIndex.ToString();
        }
        //aviao
        private void cbModeloAvioes(object sender, EventArgs e)
        {
            txtCodModeloAviao.Text = cbModeloAviao.SelectedIndex.ToString();
        }
        //aviao
        private void btnCriaAviao_Click(object sender, EventArgs e)
        {
            try
            {
                Aviao plane = new Aviao();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaAviao.SelectedIndex,
                    Nome = cbMarcaAviao.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloAviao.SelectedIndex,
                    Nome = cbModeloAviao.Text,
                    Marca = marca
                };

                plane.ID = txtIDAviao.Text;
                plane.Velocidade = Convert.ToInt32(txtVelocidadeAviao.Text);
                plane.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosAviao.Text);
                plane.ModeloVeiculo = modelo;

                listaVeiculos.Add(plane);
                MessageBox.Show("Avião Cadastrado!");
                LimpaTxts(tabAviao);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //aviao guerra
        public void CriaAviaoGuerra()
        {
            AviaoGuerra fighter = new AviaoGuerra();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "EMBRAER"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Caça",
                Marca = marca
            };

            fighter.ID = "Fighter 1";
            fighter.Velocidade = 1000;
            fighter.CapacidadePassageiros = 2;
            fighter.ModeloVeiculo = modelo;

            listaVeiculos.Add(fighter);
        }
        //aviao guerra
        private void cbMarcaAvioesGuerra(object sender, EventArgs e)
        {
            txtCodMarcaAviaoGuerra.Text = cbMarcaAviaoGuerra.SelectedIndex.ToString();
        }
        //aviao guerra
        private void cbModeloAvioesGuerra(object sender, EventArgs e)
        {
            txtCodModeloAviaoGuerra.Text = cbModeloAviaoGuerra.SelectedIndex.ToString();
        }
        //aviao guerra
        private void btnCriaAviaoGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                AviaoGuerra fighter = new AviaoGuerra();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaAviaoGuerra.SelectedIndex,
                    Nome = cbMarcaAviaoGuerra.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloAviaoGuerra.SelectedIndex,
                    Nome = cbModeloAviaoGuerra.Text,
                    Marca = marca
                };

                fighter.ID = txtIDAviaoGuerra.Text;
                fighter.Velocidade = Convert.ToInt32(txtVelocidadeAviaoGuerra.Text);
                fighter.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosAviaoGuerra.Text);
                fighter.ModeloVeiculo = modelo;

                listaVeiculos.Add(fighter);
                MessageBox.Show("Avião de Guerra Cadastrado!");
                LimpaTxts(tabAviaoGuerra);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //trem
        public void CriaTrem()
        {
            Trem train = new Trem();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "GE TRANSPORTATION"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Cargueiro",
                Marca = marca
            };

            train.ID = "Train 1";
            train.Velocidade = 100;
            train.CapacidadePassageiros = 100;
            train.QtdVagoes = 15;
            train.ModeloVeiculo = modelo;

            listaVeiculos.Add(train);
        }
        //trem
        private void btnCriaTrem_Click(object sender, EventArgs e)
        {
            try
            {
                Trem train = new Trem();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaTrem.SelectedIndex,
                    Nome = cbMarcaTrem.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloTrem.SelectedIndex,
                    Nome = cbModeloTrem.Text,
                    Marca = marca
                };

                train.ID = txtIDTrem.Text;
                train.Velocidade = Convert.ToInt32(txtVelocidadeTrem.Text);
                train.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosTrem.Text);
                train.QtdVagoes = Convert.ToInt32(txtQtdVagoes.Text);
                train.ModeloVeiculo = modelo;

                listaVeiculos.Add(train);
                MessageBox.Show("Trem Cadastrado!");
                LimpaTxts(tabTrem);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //trem
        private void cbMarcaTrens(object sender, EventArgs e)
        {
            txtCodMarcaTrem.Text = cbMarcaTrem.SelectedIndex.ToString();
        }
        //trem
        private void cbModeloTrens(object sender, EventArgs e)
        {
            txtCodModeloTrem.Text = cbModeloTrem.SelectedIndex.ToString();
        }
        //navio
        public void CriaNavio()
        {
            Navio ship = new Navio();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "MSC"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Escuna",
                Marca = marca
            };

            ship.ID = "Ship 1";
            ship.Velocidade = 80;
            ship.CapacidadePassageiros = 120;
            ship.ModeloVeiculo = modelo;

            listaVeiculos.Add(ship);
        }
        //navio
        private void btnCriaNavio_Click(object sender, EventArgs e)
        {
            try
            {
                Navio ship = new Navio();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaNavio.SelectedIndex,
                    Nome = cbMarcaNavio.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloNavio.SelectedIndex,
                    Nome = cbModeloNavio.Text,
                    Marca = marca
                };

                ship.ID = txtIDNavio.Text;
                ship.Velocidade = Convert.ToInt32(txtVelocidadeNavio.Text);
                ship.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosNavio.Text);
                ship.ModeloVeiculo = modelo;

                listaVeiculos.Add(ship);
                MessageBox.Show("Navio Cadastrado!");
                LimpaTxts(tabNavio);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //navio
        private void cbMarcaNavios(object sender, EventArgs e)
        {
            txtCodMarcaNavio.Text = cbMarcaNavio.SelectedIndex.ToString();

        }
        //navio
        private void cbModeloNavios(object sender, EventArgs e)
        {
            txtCodModeloNavio.Text = cbModeloNavio.SelectedIndex.ToString();

        }
        //navio guerra
        public void CriaNavioGuerra()
        {
            NavioGuerra warShip = new NavioGuerra();
            Marca marca = new Marca()
            {
                Codigo = 0,
                Nome = "Marca 1"
            };
            Modelo modelo = new Modelo()
            {
                Codigo = 0,
                Nome = "Contratorpedeiro",
                Marca = marca
            };

            warShip.ID = "War Ship 1";
            warShip.Velocidade = 150;
            warShip.CapacidadePassageiros = 25;
            warShip.ModeloVeiculo = modelo;

            listaVeiculos.Add(warShip);
        }
        //navio guerra
        private void btnCriaNavioGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                NavioGuerra warShip = new NavioGuerra();
                Marca marca = new Marca()
                {
                    Codigo = cbMarcaNavioGuerra.SelectedIndex,
                    Nome = cbMarcaNavioGuerra.Text
                };
                Modelo modelo = new Modelo()
                {
                    Codigo = cbModeloNavioGuerra.SelectedIndex,
                    Nome = cbModeloNavioGuerra.Text,
                    Marca = marca
                };

                warShip.ID = txtIDNavioGuerra.Text;
                warShip.Velocidade = Convert.ToInt32(txtVelocidadeNavioGuerra.Text);
                warShip.CapacidadePassageiros = Convert.ToInt32(txtCapPassageirosNavioGuerra.Text);
                warShip.ModeloVeiculo = modelo;

                listaVeiculos.Add(warShip);
                MessageBox.Show("Navio Cadastrado!");
                LimpaTxts(tabNavioGuerra);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //navio guerra
        private void cbMarcaNaviosGuerra(object sender, EventArgs e)
        {
            txtCodMarcaNavioGuerra.Text = cbMarcaNavioGuerra.SelectedIndex.ToString();

        }
        //navio guerra
        private void cbModeloNaviosGuerra(object sender, EventArgs e)
        {
            txtCodModeloNavioGuerra.Text = cbModeloNavioGuerra.SelectedIndex.ToString();
            
        }
        //pedagio 
        private void btnpedagio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbListaPedagio.SelectedIndex == -1)
                    throw new Exception("Selecione o pedágio que deseja fazer a cobrança!");
                string idPed = cbListaPedagio.SelectedItem.ToString();
                foreach (var item in listaPedagios)
                    if (item.IDPedagio == idPed)
                        EfetuaPagamento(item);

                txtListagem.Clear();
                LimpaTxts(tabControles);
                foreach (Pedagio ped in listaPedagios)
                    txtListagem.Text += ped + Environment.NewLine;
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
           
        }
        public void EfetuaPagamento(Pedagio p)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                    (v as Carro).PagarPedagio();
                else if (v is Caminhao)
                    (v as Caminhao).PagarPedagio();
                else if (v is Moto)
                    (v as Moto).PagarPedagio();
                else if (v is Onibus)
                    (v as Onibus).PagarPedagio();
            }
            foreach (Veiculo v in listaVeiculos)
                p.Receber(v);
        }
        //pedagio
        private void btnCriaPedagio_Click(object sender, EventArgs e)
        {
            try
            {
                Pedagio pedagio = new Pedagio()
                {
                    IDPedagio = txtIDPedagio.Text,
                    Localizacao = txtLocalizacao.Text
                };
                listaPedagios.Add(pedagio);
                MessageBox.Show("Pedágio Cadastrado!");
                cbListaPedagio.Items.Clear();
                foreach (var item in listaPedagios)
                    cbListaPedagio.Items.Add(item.IDPedagio);

                LimpaTxts(tabPedagio);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        //ligar limpador
        private void btnLigaLimpador_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
                if (v is Carro||v is Caminhao|| v is Onibus|| v is Aviao || v is Trem)
                    txtListagem.Text += $"Limpador do veículo '{v.ID}' ligado!" + Environment.NewLine;
        }
        //desligar limpador
        private void btnDesligaLimpadores_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
                if (v is Carro || v is Caminhao || v is Onibus || v is Aviao || v is Trem)
                    txtListagem.Text += $"Limpador do veículo '{v.ID}' desligado!" + Environment.NewLine;
        }
        //atraca navios
        private void btnAtracarNavios_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Navio)
                    txtListagem.Text += (v as Navio).Atracar() + Environment.NewLine;
                else if(v is NavioGuerra)
                    txtListagem.Text += (v as NavioGuerra).Atracar() + Environment.NewLine;
            }
                
        }
        //empinar
        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
                if (v is Moto)
                    txtListagem.Text += (v as Moto).Empinar() + Environment.NewLine;
        }
        //atacar
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioGuerra)
                    txtListagem.Text += (v as NavioGuerra).Atacar() + Environment.NewLine;
                else if(v is AviaoGuerra)
                    txtListagem.Text += (v as AviaoGuerra).Atacar() + Environment.NewLine;
            }
                
        }
        //decolar
        private void btnDecolar_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                    txtListagem.Text += (v as Aviao).Decolar() + Environment.NewLine;
                if (v is AviaoGuerra)
                    txtListagem.Text += (v as AviaoGuerra).Decolar() + Environment.NewLine;
            }
                
        }
        //arremeter
        private void btnArremeter_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                    txtListagem.Text += (v as Aviao).Arremeter() + Environment.NewLine;
                if (v is AviaoGuerra)
                    txtListagem.Text += (v as AviaoGuerra).Arremeter() + Environment.NewLine;
            }

        }
        //pousar
        private void btnPousar_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                    txtListagem.Text += (v as Aviao).Pousar() + Environment.NewLine;
                if (v is AviaoGuerra)
                    txtListagem.Text += (v as AviaoGuerra).Pousar() + Environment.NewLine;
            }
        }
        //lista todos os veiculos
        private void btnListaVeiculos_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                    txtListagem.Text += (v as Carro).ToString() + Environment.NewLine;
                else if(v is Caminhao)
                    txtListagem.Text += (v as Caminhao).ToString() + Environment.NewLine;
                else if (v is Onibus)
                    txtListagem.Text += (v as Onibus).ToString() + Environment.NewLine;
                else if (v is Moto)
                    txtListagem.Text += (v as Moto).ToString() + Environment.NewLine;
                else if (v is Aviao)
                    txtListagem.Text += (v as Aviao).ToString() + Environment.NewLine;
                else if (v is AviaoGuerra)
                    txtListagem.Text += (v as AviaoGuerra).ToString() + Environment.NewLine;
                else if (v is Trem)
                    txtListagem.Text += (v as Trem).ToString() + Environment.NewLine;
                else if (v is Navio)
                    txtListagem.Text += (v as Navio).ToString() + Environment.NewLine;
                else if (v is NavioGuerra)
                    txtListagem.Text += (v as NavioGuerra).ToString() + Environment.NewLine;
            }
                
        }
        //acelerar
        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    if ((v as Caminhao).PesoCarregado > (v as Caminhao).PesoMaximo)
                        MessageBox.Show($"Não é possível acelerar o caminhão '{v.ID}' pois a carga máxima foi ultrapassada!");
                    else
                        v.Acelerar();
                }
                else
                    v.Acelerar();
                        
            }
                

        }
        //desacelerar
        private void btnDesacelerar_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v.Velocidade<0)
                {
                    MessageBox.Show($"O veículo {v.ID} parou!");
                }
                else
                    v.Desacelerar();

            }
        }
        //instancia todos os veiculos
        private void btnCriaTodoVeiculo_Click(object sender, EventArgs e)
        {
            CriaCarro();
            CriaCaminhao();
            CriaOnibus();
            CriaMoto();
            CriaAviao();
            CriaAviaoGuerra();
            CriaTrem();
            CriaNavio();
            CriaNavioGuerra();
            MessageBox.Show("Todos os veiculos foram instanciados!");
        }
        //Carrega arquivo
        public void CarregaArquivo()
        {
            if (File.Exists("Veiculos.txt"))
            {
                string[] linhas = File.ReadAllLines("Veiculos.txt");
                foreach (string dado in linhas)
                {
                    string[] dadosLinha = dado.Split('|');
                    if(dadosLinha[0] == "Carro")
                    {
                        Carro c = new Carro();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[7]),
                            Nome = dadosLinha[8]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[5]),
                            Nome = dadosLinha[6],
                            Marca = marca
                            
                        };
                        c.ID = dadosLinha[1];
                        c.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        c.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        c.QtdPortas = Convert.ToInt32(dadosLinha[4]);
                        c.ModeloVeiculo = modelo;

                        listaVeiculos.Add(c);
                    }
                    else if(dadosLinha[0] == "Caminhao")
                    {
                        Caminhao truck = new Caminhao();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[9]),
                            Nome = dadosLinha[10]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[7]),
                            Nome = dadosLinha[8],
                            Marca = marca

                        };
                        truck.ID = dadosLinha[1];
                        truck.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        truck.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        truck.QtdEixos = Convert.ToInt32(dadosLinha[4]);
                        truck.PesoCarregado = Convert.ToDouble(dadosLinha[5]);
                        truck.PesoMaximo = Convert.ToDouble(dadosLinha[6]);
                        truck.ModeloVeiculo = modelo;

                        listaVeiculos.Add(truck);
                    }
                    else if(dadosLinha[0] == "Onibus")
                    {
                        Onibus o = new Onibus();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[8]),
                            Nome = dadosLinha[9]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[6]),
                            Nome = dadosLinha[7],
                            Marca = marca

                        };
                        o.ID = dadosLinha[1];
                        o.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        o.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        o.QtdEixos = Convert.ToInt32(dadosLinha[4]);
                        o.Leito = Convert.ToBoolean(dadosLinha[5]);
                        o.ModeloVeiculo = modelo;

                        listaVeiculos.Add(o);
                    }
                    else if (dadosLinha[0] == "Moto")
                    {
                        Moto m = new Moto();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[6]),
                            Nome = dadosLinha[7]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[4]),
                            Nome = dadosLinha[5],
                            Marca = marca

                        };
                        m.ID = dadosLinha[1];
                        m.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        m.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        m.ModeloVeiculo = modelo;

                        listaVeiculos.Add(m);
                    }
                    else if(dadosLinha[0] == "Aviao")
                    {
                        Aviao a = new Aviao();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[6]),
                            Nome = dadosLinha[7]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[4]),
                            Nome = dadosLinha[5],
                            Marca = marca

                        };
                        a.ID = dadosLinha[1];
                        a.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        a.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        a.ModeloVeiculo = modelo;

                        listaVeiculos.Add(a);
                    }
                    else if(dadosLinha[0] == "AviaoGuerra")
                    {
                        AviaoGuerra ag = new AviaoGuerra();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[6]),
                            Nome = dadosLinha[7]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[4]),
                            Nome = dadosLinha[5],
                            Marca = marca

                        };
                        ag.ID = dadosLinha[1];
                        ag.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        ag.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        ag.ModeloVeiculo = modelo;

                        listaVeiculos.Add(ag);
                    }
                    else if(dadosLinha[0] == "Trem")
                    {
                        Trem t = new Trem();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[7]),
                            Nome = dadosLinha[8]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[5]),
                            Nome = dadosLinha[6],
                            Marca = marca

                        };
                        t.ID = dadosLinha[1];
                        t.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        t.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        t.QtdVagoes = Convert.ToInt32(dadosLinha[4]);
                        t.ModeloVeiculo = modelo;

                        listaVeiculos.Add(t);
                    }
                    else if(dadosLinha[0] == "Navio")
                    {
                        Navio n = new Navio();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[6]),
                            Nome = dadosLinha[7]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[4]),
                            Nome = dadosLinha[5],
                            Marca = marca

                        };
                        n.ID = dadosLinha[1];
                        n.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        n.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        n.ModeloVeiculo = modelo;

                        listaVeiculos.Add(n);
                    }
                    else if(dadosLinha[0] == "NavioGuerra")
                    {
                        NavioGuerra ng = new NavioGuerra();
                        Marca marca = new Marca()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[6]),
                            Nome = dadosLinha[7]
                        };
                        Modelo modelo = new Modelo()
                        {
                            Codigo = Convert.ToInt32(dadosLinha[4]),
                            Nome = dadosLinha[5],
                            Marca = marca

                        };
                        ng.ID = dadosLinha[1];
                        ng.Velocidade = Convert.ToInt32(dadosLinha[2]);
                        ng.CapacidadePassageiros = Convert.ToInt32(dadosLinha[3]);
                        ng.ModeloVeiculo = modelo;

                        listaVeiculos.Add(ng);
                    }
                    else if(dadosLinha[0] == "Pedagio")
                    {
                        Pedagio p = new Pedagio();
                        p.IDPedagio = dadosLinha[1];
                        p.Localizacao = dadosLinha[2];
                        p.TotalRecebido = Convert.ToDouble(dadosLinha[3]);

                        listaPedagios.Add(p);
                    }
                }
            }
        }
        //Salva arquivo
        public void SalvaArquivo()
        {
            string historico = "";
            foreach(Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                {
                    historico += "Carro" +
                        "|" + (v as Carro).ID +
                        "|" + (v as Carro).Velocidade +
                        "|" + (v as Carro).CapacidadePassageiros +
                        "|" + (v as Carro).QtdPortas +
                        "|" + (v as Carro).ModeloVeiculo.Codigo +
                        "|" + (v as Carro).ModeloVeiculo.Nome +
                        "|" + (v as Carro).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Carro).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is Caminhao)
                {
                    historico += "Caminhao" +
                        "|" + (v as Caminhao).ID +
                        "|" + (v as Caminhao).Velocidade +
                        "|" + (v as Caminhao).CapacidadePassageiros +
                        "|" + (v as Caminhao).QtdEixos +
                        "|" + (v as Caminhao).PesoCarregado +
                        "|" + (v as Caminhao).PesoMaximo +
                        "|" + (v as Caminhao).ModeloVeiculo.Codigo +
                        "|" + (v as Caminhao).ModeloVeiculo.Nome +
                        "|" + (v as Caminhao).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Caminhao).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is Onibus)
                {
                    historico += "Onibus" +
                        "|" + (v as Onibus).ID +
                        "|" + (v as Onibus).Velocidade +
                        "|" + (v as Onibus).CapacidadePassageiros +
                        "|" + (v as Onibus).QtdEixos +
                        "|" + (v as Onibus).Leito +
                        "|" + (v as Onibus).ModeloVeiculo.Codigo +
                        "|" + (v as Onibus).ModeloVeiculo.Nome +
                        "|" + (v as Onibus).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Onibus).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is Moto)
                {
                    historico += "Moto" +
                        "|" + (v as Moto).ID +
                        "|" + (v as Moto).Velocidade +
                        "|" + (v as Moto).CapacidadePassageiros +
                        "|" + (v as Moto).ModeloVeiculo.Codigo +
                        "|" + (v as Moto).ModeloVeiculo.Nome +
                        "|" + (v as Moto).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Moto).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is Aviao)
                {
                    historico += "Aviao" +
                        "|" + (v as Aviao).ID +
                        "|" + (v as Aviao).Velocidade +
                        "|" + (v as Aviao).CapacidadePassageiros +
                        "|" + (v as Aviao).ModeloVeiculo.Codigo +
                        "|" + (v as Aviao).ModeloVeiculo.Nome +
                        "|" + (v as Aviao).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Aviao).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is AviaoGuerra)
                {
                    historico += "AviaoGuerra" +
                        "|" + (v as AviaoGuerra).ID +
                        "|" + (v as AviaoGuerra).Velocidade +
                        "|" + (v as AviaoGuerra).CapacidadePassageiros +
                        "|" + (v as AviaoGuerra).ModeloVeiculo.Codigo +
                        "|" + (v as AviaoGuerra).ModeloVeiculo.Nome +
                        "|" + (v as AviaoGuerra).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as AviaoGuerra).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is Trem)
                {
                    historico += "Trem" +
                        "|" + (v as Trem).ID +
                        "|" + (v as Trem).Velocidade +
                        "|" + (v as Trem).CapacidadePassageiros +
                        "|" + (v as Trem).QtdVagoes +
                        "|" + (v as Trem).ModeloVeiculo.Codigo +
                        "|" + (v as Trem).ModeloVeiculo.Nome +
                        "|" + (v as Trem).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Trem).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else if (v is Navio)
                {
                    historico += "Navio" +
                        "|" + (v as Navio).ID +
                        "|" + (v as Navio).Velocidade +
                        "|" + (v as Navio).CapacidadePassageiros +
                        "|" + (v as Navio).ModeloVeiculo.Codigo +
                        "|" + (v as Navio).ModeloVeiculo.Nome +
                        "|" + (v as Navio).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as Navio).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
                else
                {
                    historico += "NavioGuerra" +
                        "|" + (v as NavioGuerra).ID +
                        "|" + (v as NavioGuerra).Velocidade +
                        "|" + (v as NavioGuerra).CapacidadePassageiros +
                        "|" + (v as NavioGuerra).ModeloVeiculo.Codigo +
                        "|" + (v as NavioGuerra).ModeloVeiculo.Nome +
                        "|" + (v as NavioGuerra).ModeloVeiculo.Marca.Codigo +
                        "|" + (v as NavioGuerra).ModeloVeiculo.Marca.Nome + Environment.NewLine;
                }
            }
            foreach (Pedagio p in listaPedagios)
            {
                historico += "Pedagio" + "|" + p.IDPedagio + "|" + p.Localizacao + "|" + p.TotalRecebido + Environment.NewLine;
            }
            File.WriteAllText("Veiculos.txt", historico);


        }
        //Salva arquivo botao
        private void btnSalvaArquivos_Click(object sender, EventArgs e)
        {
            SalvaArquivo();
            MessageBox.Show("Veículos salvos no arquivo texto!");
        }
        //limpa textbox de listagem
        private void btnLimpeza_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
        }
        //limpa os txts
        public void LimpaTxts(Control c)
        {
            if (c is TextBox)
                (c as TextBox).Clear();
            if (c is ComboBox)
                (c as ComboBox).SelectedIndex = -1;
            else
                foreach (Control controle in c.Controls)
                    LimpaTxts(controle);
        }
        //carrega caminhoes
        private void btnCarregaCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPeso.Text.Trim() == "")
                    throw new Exception("Insira o peso que deseja carregar!");
                foreach (Veiculo v in listaVeiculos)
                    if (v is Caminhao)
                        (v as Caminhao).Carregar(Convert.ToDouble(txtPeso.Text));
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }
        //descarrega caminhoes
        private void btnDescarregaCaminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
                if (v is Caminhao)
                    (v as Caminhao).Descarregar();
        }
        //lista pedagios
        private void btnListaPedagio_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Pedagio p in listaPedagios)
                txtListagem.Text += (p as Pedagio).ToString() + Environment.NewLine;
        }
    }

}
