using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Matrices
    {
        private string cadena;
        private int[,] _Matriz;
        //public int [,] Matriz
        //{
        //    get { return _Matriz; }
        //}
        public int _conteo;
        private int  _tamañoMatriz;
        //En este constructor se va a crear la matriz
        public Matrices(int num)
        {
            //int _Matriz[, ];
            //int _tamañoMatriz;
            //_tamañoMatriz represta el tamaño que tendrá la matriz y num va a determinar el tamaño/numero
            _tamañoMatriz = num;
            //Aquí ya se representan ambos datos de una matriz en [num,num]
            _Matriz = new int[num, num];

        }
        //Como su nombre lo indica, se va a llenar la Matriz ya creada
        public void  llenarMatriz()
        {
            _conteo = 1;
            //De acuerdo al tamaño de la matriz se va a ir llenando cada espacio, pero como es bidimensional, se hacen dos for
            for (int i = 0; i < _tamañoMatriz; i++)
            {
                for (int j = 0; j < _tamañoMatriz; j++)
                {

                    _Matriz[i, j] = _conteo++;
                }
            }
           
        }
        //Se va a mostrar la matriz ya llenada
        public override string ToString()
        {
            //Se vuelve a realizar el ciclo, pero esta vez ya va a aparecer 
            String texto = "";
            for (int i = 0; i < _tamañoMatriz; i++)
            {
                for (int j = 0; j < _tamañoMatriz; j++)
                {
                    texto += +_Matriz[i, j]+" ";
                }
                texto += Environment.NewLine;
            }
            texto += "\n\n";
            return texto;
                  
                }
        public void llenarColumnas()
        {
            _conteo = 1;
            //De acuerdo al tamaño de la matriz se va a ir llenando cada espacio, pero como es bidimensional, se hacen dos for
            for (int i = 0; i < _tamañoMatriz; i++)
            {
                for (int j = 0; j < _tamañoMatriz; j++)
                {
                    _Matriz[j,i] = _conteo++;
                }
            }
        }
        public void renglonInverso()
        {
            _conteo = _tamañoMatriz*_tamañoMatriz;
            //De acuerdo al tamaño de la matriz se va a ir llenando cada espacio, pero como es bidimensional, se hacen dos for

            for (int i = 0; i < _tamañoMatriz; i++)
            {
                for (int j = 0; j < _tamañoMatriz; j++)
                {
                    _Matriz[i, j] = _conteo--;
                }
            }

        }
        public string diagonalPp()
        {
            cadena = "";
            //De acuerdo al tamaño de la matriz se va a ir llenando cada espacio, pero como es bidimensional, se hacen dos for

            int i = 0;
            {
                for (int j = 0; j < _tamañoMatriz;)
                {
                    cadena += _Matriz[i,j].ToString();
                    i++;
                    j++;
                      
                }return cadena;
            }
           
        }
        public string diagonalSs()
        {
            cadena = "";
            //De acuerdo al tamaño de la matriz se va a ir llenando cada espacio, pero como es bidimensional, se hacen dos for

            int i= 3;
            {
                for (int j = 0; j < _tamañoMatriz;)
                {
                    cadena += _Matriz[i,j].ToString();
                    j++;
                    i--;

                }
                return cadena;
            }
        }
        public string arribaPpd()
        {
            cadena = "";
            int i = 1;
            {
                for (int j=3; j < _tamañoMatriz;)
                {
                    cadena +=  _Matriz[j,i]+" ".ToString();
                    i++;
                    j++;

                }
                return cadena;
            }

        }
        public void  abajoPp()
        {
            
           for(int i=0; i<_tamañoMatriz; i++)
            {
                for (int j = 0; j < _tamañoMatriz;)
                {
                    cadena += _Matriz[i,j] + " ".ToString();
                    
                }
                
            }
        }
        public void invertirDiagonalPP()
        {

            cadena = "";
            int aux;

            for (int i = 1; i < _tamañoMatriz; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    aux = _Matriz[i, j];
                    _Matriz[i, j] = _Matriz[j, i];
                    _Matriz[j, i] = aux;
                }
            }
        }
    }


}
