using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico
{
    class Carro : Veiculo
    {

        public int NPortas { get; set; }
        public string TipoCaixa { get; set; }

        public Carro()
        {
            Tipo = "Carro";
            Estado = "Disponível";
        }

        public Carro(string marca, string tipo, string cor, string combustivel, int preco, string estado, DateTime dataFinal,string matricula, int nPortas, string tipoCaixa) : base(marca, tipo, cor, combustivel, preco, estado, dataFinal, matricula)
        {
            NPortas = nPortas;
            TipoCaixa = tipoCaixa;
        }
        public Carro(Carro car) : base(car.Marca, car.Tipo, car.Cor, car.Combustivel, car.Preco, car.Estado, car.DataFinal,car.Matricula)
        {
            NPortas = car.NPortas;
            TipoCaixa = car.TipoCaixa;

        }
        public override string ToString()
        {
            return base.ToString()+"\t Nº Portas: "+NPortas+"\t Tipo de Caixa: "+TipoCaixa;
        }
    }
}
