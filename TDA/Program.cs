using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA
{
    class Program
    {
        static void Main(string[] args)
        {
            string letras = string.Empty;
            bool salir = false;

            Console.Write("Ingresar una cadena : " + " ");
            letras = Console.ReadLine();

            string[] arreglo = letras.ToUpper().Trim().Split(' ');
            int comparando = 1;
            String A = "A";
            String E_Aceptada = "q0";

            foreach (string sema in arreglo)
            {
                for (int i = 0; i < sema.Length; i++)
                {
                    String Comparacion = sema.Substring(i, 1);
                    switch (comparando)
                    {
                        case 1:
                            {
                                if (Comparacion.Equals(A))
                                {
                                    E_Aceptada = "q0";
                                    comparando = 1;
                                }
                                else
                                {
                                    E_Aceptada = "q1";
                                    comparando = 2;
                                }
                            }
                            break;
                        case 2:
                            {
                                if (Comparacion.Equals(A))
                                {
                                    E_Aceptada = "q0";
                                    comparando = 1;
                                }
                                else
                                {
                                    E_Aceptada = "q2";
                                    comparando = 3;
                                }

                            }
                            break;
                        case 3:
                            {
                                if (Comparacion.Equals(A))
                                {
                                    E_Aceptada = "q0";
                                    comparando = 1;

                                }
                                else
                                {
                                    E_Aceptada = "q3";
                                    comparando = 4;
                                }
                            }
                            break;
                        case 4:
                            {
                                if (Comparacion.Equals(A))
                                {
                                    E_Aceptada = "q3";
                                    comparando = 4;

                                }
                                else
                                {
                                    E_Aceptada = "q3";
                                    comparando = 4;
                                }
                            }
                            break;

                    }
                }
            }


            String CA_FINAL = "q3";
            if (E_Aceptada.Equals(CA_FINAL))
            {
                Console.WriteLine("No se aceptada la cadena");
            }
            else
            {
                Console.WriteLine("Si se aceptada la cadena");
            }
            Console.ReadKey();

        }
    }
    
}
