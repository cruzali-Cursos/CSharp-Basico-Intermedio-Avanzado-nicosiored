﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces02
{
    class Resta:IOperaciones
    {
        double res;
        public void Calcular(double a, double b)
        {
            res = a - b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la resta es: " + res);
        }
    }
}
