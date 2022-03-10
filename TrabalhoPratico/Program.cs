using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico
{
    class Program
    {
        static List<Veiculo> veiculos;
        static void Main(string[] args)
        {
            #region InserirTabelaVeiculos;
            veiculos = new List<Veiculo>();
            veiculos.Add(new Carro("Audi A1   ", "Carro", "Cinza", "Gasóleo", 20, "disponível", new DateTime(2022, 04, 05),"XY-67-52", 5, "Manual"));
            veiculos.Add(new Carro("Audi A1   ", "Carro", "Preto", "Gasóleo", 20, "disponível", new DateTime(2022, 04, 05), "AY-22-31", 5, "Manual"));
            veiculos.Add(new Carro("Audi A1   ", "Carro", "Branco", "Gasóleo", 20, "alugado", new DateTime(2022, 04, 05), "XB-22-52", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie 1", "Carro", "Cinza", "Gasolina", 22, "disponível", new DateTime(2022, 04, 05), "XY-22-52", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie 1", "Carro", "Preto", "Gasolina", 22, "disponível", new DateTime(2022, 04, 05), "XG-01-DC", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie 2", "Carro", "Cinza", "Gasolina", 24, "reservado", new DateTime(2022, 04, 05), "FY-76-52", 5, "Manual"));
            veiculos.Add(new Carro("BMW Serie 2", "Carro", "Preto", "Gasolina", 24, "disponível", new DateTime(2022, 04, 05), "RE-34-52", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3", "Carro", "Vermelho", "Gasóleo", 18, "disponível", new DateTime(2022, 04, 05), "12-FD-52", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3", "Carro", "Vermelho", "Gasóleo", 18, "em manutenção", new DateTime(2022, 04, 05), "NH-22-78", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3", "Carro", "Azul", "Gasóleo", 18, "disponível", new DateTime(2022, 04, 05), "JE-17-89", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-3", "Carro", "Azul", "Gasóleo", 18, "disponível", new DateTime(2022, 04, 05), "KU-29-11", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-5", "Carro", "Vermelho", "Gasóleo", 20, "disponível", new DateTime(2022, 04, 05), "IU-20-91", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-5", "Carro", "Vermelho", "Gasóleo", 20, "alugado", new DateTime(2022, 04, 05), "83-FV-58", 5, "Manual"));
            veiculos.Add(new Carro("Mazda CX-5", "Carro", "Azul", "Gasóleo", 20, "disponível", new DateTime(2022, 04, 05), "65-MY-13", 5, "Manual"));
            veiculos.Add(new Carro("Porsche 911", "Carro", "Cinza", "Gasolina", 40, "alugado", new DateTime(2022, 04, 05), "73-BV-01", 3, "Automática"));
            veiculos.Add(new Carro("Renault Clio", "Carro", "Branco", "Gasóleo", 12, "disponível", new DateTime(2022, 04, 05), "MU-65-15", 3, "Manual"));
            veiculos.Add(new Carro("Renault Clio", "Carro", "Branco", "Gasóleo", 12, "disponível", new DateTime(2022, 04, 05), "RD-10-99", 3, "Manual"));
            veiculos.Add(new Carro("Renault Clio", "Carro", "Preto", "Gasolina", 10, "em manutenção", new DateTime(2022, 04, 05), "NJ-99-98", 5, "Manual"));
            veiculos.Add(new Carro("Renault Clio", "Carro", "Preto", "Gasolina", 10, "disponível", new DateTime(2022, 04, 05), "MF-11-27", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane", "Carro", "Vermelho", "Gasóleo", 16, "alugado", new DateTime(2022, 04, 05), "56-LT-57", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane", "Carro", "Azul", "Gasóleo", 16, "alugado", new DateTime(2022, 04, 05), "68-HU-45", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane", "Carro", "Preto", "Gasóleo", 16, "disponível", new DateTime(2022, 04, 05), "IO-25-52", 5, "Manual"));
            veiculos.Add(new Carro("Renault Megane", "Carro", "Cinza", "Gasóleo", 16, "disponível", new DateTime(2022, 04, 05), "PF-26-48", 5, "Manual"));
            veiculos.Add(new Carro("Renault Zoe", "Carro", "Branco", "Elétrico", 25, "disponível", new DateTime(2022, 04, 05), "35-FL-95", 3, "Automática"));
            veiculos.Add(new Carro("Renault Zoe", "Carro", "Branco", "Elétrico", 25, "disponível", new DateTime(2022, 04, 05), "26-GI-61", 3, "Automática"));
            veiculos.Add(new Carro("Renault Zoe", "Carro", "Branco", "Elétrico", 25, "alugado", new DateTime(2022, 04, 05), "FI-72-02", 3, "Automática"));
            veiculos.Add(new Carro("Toyota CH-R", "Carro", "Preto", "Híbrido", 27, "em manutenção", new DateTime(2022, 04, 05), "BO-85-00", 5, "Automática"));
            veiculos.Add(new Carro("Toyota CH-R", "Carro", "Cinza", "Híbrido", 27, "disponível", new DateTime(2022, 04, 05), "PO-59-52", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Prius", "Carro", "Vermelho", "Híbrido", 25, "disponível", new DateTime(2022, 04, 05), "58-LO-75", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Prius", "Carro", "Vermelho", "Híbrido", 25, "disponível", new DateTime(2022, 04, 05), "KI-26-92", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Prius", "Carro", "Azul", "Híbrido", 25, "alugado", new DateTime(2022, 04, 05), "XD-16-52", 5, "Automática"));
            veiculos.Add(new Carro("Toyota Corolla", "Carro", "Preto", "Gasolina", 15, "disponível", new DateTime(2022, 04, 05), "NU-68-11", 5, "Manual"));
            veiculos.Add(new Carro("Seat Leon", "Carro", "Preto", "Gasóleo", 17, "disponível", new DateTime(2022, 04, 05), "FU-02-78", 3, "Manual"));
            veiculos.Add(new Carro("Seat Leon", "Carro", "Preto", "Gasóleo", 17, "disponível", new DateTime(2022, 04, 05), "CV-10-32", 3, "Manual"));
            veiculos.Add(new Mota("Honda CBR", "Mota", "Amarelo", "Gasolina", 10, "alugado", new DateTime(2022, 04, 05), "67-FG-06", 125));
            veiculos.Add(new Mota("Honda CBR", "Mota", "Amarelo", "Gasolina", 10, "disponível", new DateTime(2022, 04, 05), "95-FU-48", 125));
            veiculos.Add(new Mota("Kawasaki ZRX", "Mota", "Amarelo", "Gasolina", 10, "disponível", new DateTime(2022, 04, 05), "KP-65-60", 125));
            veiculos.Add(new Mota("Kawazaki ZRX", "Mota", "Vermelho", "Gasolina", 10, "em manutenção", new DateTime(2022, 04, 05), "KD-82-50", 300));
            veiculos.Add(new Camioneta("Irizar PB", "Camioneta", "Preto", "Gasóleo", 100, "disponível", new DateTime(2022, 04, 05), "FP-20-10", 3, 150));
            veiculos.Add(new Camiao("MAN", "Camião", "Preto", "Gasóleo", 120, "disponível", new DateTime(2022, 04, 05), "XO-30-00", 2000));
            veiculos.Add(new Camiao("Mercedes", "Camião", "Preto", "Gasóleo", 180, "alugado", new DateTime(2022, 04, 05), "VO-50-60", 2500));
            veiculos.Add(new Camiao("Scania", "Camião", "Preto", "Gasóleo", 160, "disponível", new DateTime(2022, 04, 05), "KF-16-08", 1700));
            #endregion;
           

            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("1-Inserir Novo Veículo");
                Console.WriteLine("2-Estado do Veículo");
                Console.WriteLine("3-Veículos disponíveis para Aluguer");
                Console.WriteLine("4-Veículos em Manutenção");
                Console.WriteLine("5-Calcular Reserva");
                Console.WriteLine("6-Exportar HTML");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0: 
                        break;
                    case 1: InserirVeiculo(); 
                        break;
                    case 2: EstadoVeiculo(); 
                        break;
                    case 3: VeiculosDisponiveis(); 
                        break;
                    case 4: VeiculosManutencao(); 
                        break;
                    case 5: CalcularReserva(); 
                        break;
                    case 6: exportarHTML();
                        break;
                    default: Console.WriteLine("Opção inválida"); 
                        Console.ReadKey(); 
                        break;
                }
            }
        }

        private static void InserirVeiculo()
        {
            Console.Clear();

            Console.WriteLine("Pretende inserir um \n1-Carro\n2-Mota\n3-Camioneta\n4-Camiao");
            int op = int.Parse(Console.ReadLine());

            if (op < 1 || op > 4)
            {
                Console.WriteLine("Opção inválida");
                Console.ReadKey();
                return;
            }
                Console.WriteLine("Insira a marca e modelo do veiculo");
                string marca = Console.ReadLine();
                Console.WriteLine("Insira a cor do veiculo");
                string cor = Console.ReadLine();
                Console.WriteLine("Insira o combustível do veiculo");
                string combustivel = Console.ReadLine();
                Console.WriteLine("Insira o preço do veiculo à hora");
                int preco = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a matricula do veiculo (XX-XX-XX)");
                string matricula = Console.ReadLine();
            if (op == 1) {
                    Console.WriteLine("Insira o numero de portas do carro");
                    int nPortas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o tipo de caixa do carro");
                    string tipoCaixa = Console.ReadLine();
                    veiculos.Add(new Carro(marca, "Carro", cor, combustivel, preco, "Disponível", new DateTime(2022, 04, 05),matricula, nPortas, tipoCaixa));
                    Console.WriteLine("Carro adicionado com sucesso");
                }
                else if (op == 2)
                {
                    Console.WriteLine("Insira a cilindrada da mota");
                    int cilindrada = int.Parse(Console.ReadLine());
                    veiculos.Add(new Mota(marca, "Mota", cor, combustivel, preco, "Disponível", new DateTime(2022, 04, 05), matricula, cilindrada));
                    Console.WriteLine("Mota adicionada com sucesso");
                } else if (op == 3)
                {
                    Console.WriteLine("Insira o Nº de Eixos da camioneta");
                    int eixo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o numero de passageiros da camioneta");
                    int passageiros = int.Parse(Console.ReadLine());
                    veiculos.Add(new Camioneta(marca, "Camioneta", cor, combustivel, preco, "Disponível", new DateTime(2022, 04, 05), matricula, eixo,passageiros));
                    Console.WriteLine("Camioneta adicionada com sucesso");
                }else if (op == 4)
                {
                    Console.WriteLine("Insira o peso máximo do camião");
                    int peso = int.Parse(Console.ReadLine());
                    veiculos.Add(new Camiao(marca, "Camião", cor, combustivel, preco, "Disponível", new DateTime(2022, 04, 05), matricula, peso));
                    Console.WriteLine("Camião adicionado com sucesso");
                }
            
            Console.ReadKey();
        }

        private static void EstadoVeiculo()
        {
            Console.Clear();
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine("Marca: "+veiculos[i].Marca.ToString()+"\tMatricula: "+veiculos[i].Matricula.ToString()+"\tEstado: "+ veiculos[i].Estado.ToString());
            }
            Console.WriteLine("\nIntroduza a matricula do veículo a alterar o estado");
            string pesq = Console.ReadLine();

            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].Matricula == pesq)
                {
                    Console.WriteLine("Indique o novo estado do veículo");
                    string newEstado=Console.ReadLine();
                    veiculos[i].Estado = newEstado;
                    if(veiculos[i].Estado == "alugado"|| veiculos[i].Estado == "em manutenção")
                    {
                        Console.WriteLine("Indique até quando o veiculo vai estar em "+ veiculos[i].Estado+" YYYY/MM/DD");
                        DateTime newData = DateTime.Parse(Console.ReadLine());
                        veiculos[i].DataFinal = newData;
                    }
                    Console.WriteLine("Estado alterado com sucesso");
                }
            }
            Console.ReadKey();
        }

        private static void VeiculosDisponiveis()
        {
            Console.Clear();

            Console.WriteLine("Pretende listar que tipo de viatura dispnível \n1-Carro\n2-Mota\n3-Camioneta\n4-Camiao");
            int op = int.Parse(Console.ReadLine());

            Console.Clear();

            if (op < 1 || op > 4)
            {
                Console.WriteLine("Opção inválida");
                Console.ReadKey();
                return;
            }
            if (op == 1)
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (typeof(Carro) == veiculos[i].GetType())
                    {
                        if (veiculos[i].Estado == "disponível")
                        {
                            Console.WriteLine(veiculos[i].ToString());
                        }
                    } 
                }
            }
            if (op == 2)
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (typeof(Mota) == veiculos[i].GetType())
                    {
                        if (veiculos[i].Estado == "disponível")
                        {
                            Console.WriteLine(veiculos[i].ToString());
                        }
                    }
                }
            }
            if (op == 3)
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (typeof(Camioneta) == veiculos[i].GetType())
                    {
                        if (veiculos[i].Estado == "disponível")
                        {
                            Console.WriteLine(veiculos[i].ToString());
                        }
                    }
                }
            }
            if (op == 4)
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (typeof(Camiao) == veiculos[i].GetType())
                    {
                        if (veiculos[i].Estado == "disponível")
                        {
                            Console.WriteLine(veiculos[i].ToString());
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        private static void VeiculosManutencao()
        {
            Console.Clear();
            for (int i = 0; i < veiculos.Count; i++)
            {
                {
                    if (veiculos[i].Estado == "em manutenção")
                    {
                        Console.WriteLine(veiculos[i].ToString());
                    }
                }
            }
            Console.ReadKey();
        }

        private static void CalcularReserva()
        {
            Console.Clear();
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine("Marca: " + veiculos[i].Marca.ToString() + "\tMatricula: " + veiculos[i].Matricula.ToString() + "\tPreço: " + veiculos[i].Preco.ToString());
            }
            Console.WriteLine("\nIntroduza a matricula do veículo que pretende calcular a reserva");
            string pesq = Console.ReadLine();

            Console.WriteLine("\nIntroduza quantos dias pretende reservar");
            int diasReserva = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i < veiculos.Count; i++)
            {
                if (veiculos[i].Matricula == pesq)
                {
                    soma = veiculos[i].Preco * diasReserva;
                }
            }
            if (soma >0)
            {
                Console.WriteLine("O custo de " + diasReserva + " dias é de " + soma + " euros.");
            }
            else
            {
                Console.WriteLine("Veiculo não encontrado na nossa base de dados");
            }
            
            Console.ReadKey();
        }

        private static void exportarHTML()
        {
            
        }
    }
}
