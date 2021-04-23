using System;
namespace EXERCICIO_06___ESTRUTURA_FOR
{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Exercício 04 - estrutura repetitiva FOR - Lista de exercícios.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            int n = int.Parse(Console.ReadLine()); //----> Números de casos           
            for ( int i = 1; i <= n; i++) {
                if(n % i == 0) {
                    Console.WriteLine(+i);
                }
            }
            
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }   
}
