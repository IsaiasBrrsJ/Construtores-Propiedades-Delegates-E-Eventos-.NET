using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Log
    {

        //Esse tipo de construtor private é um padrão singleton pois toda a aplicação vai usar a mesma instancia do construtor;
        private static Log _log;
        public string PropiedadeLog { get; set; }
        private Log()
        {

        }

        public static Log GetInstance()
        {
            if (_log == null)
            {
                _log = new Log();
            }

            return _log;
        }

    }
}