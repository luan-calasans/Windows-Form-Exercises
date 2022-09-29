using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj37461_Completo
{
    internal class ClassForms
    {
        public static double peso { get; set; }
        public static double altura { get; set; }
        public static double imc { get; set; }
        public static string exibir { get; set; }
        public static void CalcularIMC()
        {
            imc = (peso / (altura * altura));

            switch (imc)
            {
                case var _ when imc < 20:
                    exibir = ($"IMC de {Math.Round(imc, 2)} - Abaixo do peso");
                    break;
                case var _ when imc >= 20 && imc <= 25:
                    exibir = ($"IMC de {Math.Round(imc,2)} - Peso normal");
                    break;
                case var _ when imc > 25:
                    exibir = ($"IMC de {Math.Round(imc, 2)} - A cima do Peso");
                    break;
            }
        }
    }
}
