using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;
        public int GetMes()
        {
            return mes;
        }

        public void SetMes(int mes)
        {
            if (mes < 0 && mes > 12)
            {
                this.mes = mes;
                mesValido = true;
            }

        }
        public int Mes
        {
            get => mes;
            set
            {
                if (value > 0 && value < 13)
                {
                    mes = value;
                    mesValido = true;
                }
            }
        }
        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                Console.WriteLine(this.mes);
            }
            else
            {
                Console.WriteLine("Mês inválido");
            }
        }
    }
}