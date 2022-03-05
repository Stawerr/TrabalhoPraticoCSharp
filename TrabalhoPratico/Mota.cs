using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico
{
    class Mota: Veiculo
    {
        public int Cilindrada { get; set; }

        public Mota()
        {
            Tipo = "Mota";
            Estado = "Disponível";
        }

        public Mota(string marca, string tipo, string cor, string combustivel, int preco, string estado, DateTime dataFinal,string matricula, int cilindrada) : base(marca, tipo, cor, combustivel, preco, estado, dataFinal,matricula)
        {
            Cilindrada = cilindrada;
        }
        public Mota(Mota m) : base(m.Marca, m.Tipo, m.Cor, m.Combustivel, m.Preco, m.Estado, m.DataFinal,m.Matricula)
        {
            Cilindrada = m.Cilindrada;
            
        }

        public override string ToString()
        {
            return base.ToString()+"\t Cilindrada: "+Cilindrada;
        }
    }
}
