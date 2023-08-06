using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMercado
{
    public class Cliente
    {
        public int Id;
        public string Name, cpf;
        public Endereco? end;
        public double[] valorproduto;
        public string[] nomeproduto;
        public Cliente? prox, ant;
        

    }
}
