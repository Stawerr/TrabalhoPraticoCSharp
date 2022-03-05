using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public int Preco { get; set; }
        public string Estado { get; set; }
        public DateTime DataFinal { get; set; }
        public string Matricula { get; set; }

        public Veiculo()
        {
            
        }

        public Veiculo(string marca, string tipo, string cor, string combustivel, int preco, string estado, DateTime dataFinal,string matricula)
        {
            Marca = marca;
            Tipo = tipo;
            Cor = cor;
            Combustivel = combustivel;
            Preco = preco;
            Estado = estado;
            DataFinal = dataFinal;
            Matricula = matricula;
        }

        public Veiculo(Veiculo v)
        {
            Marca = v.Marca;
            Tipo = v.Tipo;
            Cor = v.Cor;
            Combustivel = v.Combustivel;
            Preco = v.Preco;
            Estado = v.Estado;
            DataFinal = v.DataFinal;
            Matricula = v.Matricula;
        }

        public override string ToString()
        {
            return "Marca: "+Marca+ "\t Tipo: "+Tipo+"\t Cor: "+Cor+"\t Combustivel: "+Combustivel+"\t Preço: "+Preco+"\t Estado: "+Estado+"\t Matricula: "+Matricula;
        }
    }
}
