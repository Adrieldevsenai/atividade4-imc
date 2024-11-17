using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imc.Tests
{
    public class IMC
    {
        public double peso;
        public double altura;
        public double imc;
        public string? categoria;
        

        public void Calcular_IMC()
        {
            imc = peso / (altura*altura);
            imc = Math.Round(imc, 2);
            
        }

        public void Classificar_IMC()
        {
            if(imc < 18.5)
            {
                categoria = "Abaixo do peso";

            }
            else if( imc< 25)
            {
                categoria = "Peso normal";            
            }
            else if ( imc < 38)
            {
                categoria = "Sobrepeso";
            }
            else if ( imc < 35)
            {
                categoria = "Obesidade de grau I";
            }
            else if ( imc < 40)
            {
                categoria = "Obesidade de grau II";
            }
            else 
            {
                categoria = "Obesidade de grau III";
            }

            }
        }
    }