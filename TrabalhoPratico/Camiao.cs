using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPratico
{
    class Camiao: Veiculo
    {
        public int PesoMaximo { get; set; }

        public Camiao()
        {
            Tipo = "Camião";
            Estado = "Disponível";
        }

        public Camiao(string marca, string tipo, string cor, string combustivel, int preco, string estado, DateTime dataFinal,string matricula, int pesoMaximo):base(marca,tipo,cor,combustivel,preco,estado,dataFinal,matricula)
        {
            PesoMaximo = pesoMaximo;
        }
        public Camiao(Camiao cam):base(cam.Marca, cam.Tipo, cam.Cor, cam.Combustivel, cam.Preco, cam.Estado, cam.DataFinal,cam.Matricula)
        {
            PesoMaximo=cam.PesoMaximo;

        }
        public override string ToString()
        {
            return base.ToString()+"\t Peso Máximo: "+PesoMaximo;
        }
    }
}
