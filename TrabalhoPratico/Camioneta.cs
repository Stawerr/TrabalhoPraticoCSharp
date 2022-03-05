using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico
{
    class Camioneta :Veiculo
    {
        public int NEixos { get; set; }
        public int NPassageiros { get; set; }

        public Camioneta()
        {
            Tipo = "Camioneta";
            Estado = "Disponível";
        }

        public Camioneta(string marca, string tipo, string cor, string combustivel, int preco, string estado, DateTime dataFinal, string matricula, int nEixos, int nPassageiros) : base(marca, tipo, cor, combustivel, preco, estado, dataFinal, matricula)
        {
            NEixos = nEixos;
            NPassageiros = nPassageiros;
        }
        public Camioneta(Camioneta c) : base(c.Marca, c.Tipo, c.Cor, c.Combustivel, c.Preco, c.Estado, c.DataFinal,c.Matricula)
        {
            NEixos = c.NEixos;
            NPassageiros = c.NPassageiros;

        }
        public override string ToString()
        {
            return base.ToString()+"\t Nº Eixos: "+NEixos+"\t Nº Passageiros: "+NPassageiros;
        }
    }
}
