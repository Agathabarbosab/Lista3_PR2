using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu

            float exercicio, dia, modopagamento, valordacompra, desconto, mes;

            Console.WriteLine("======Menu======");
            Console.WriteLine("exercicio 1 - Digite1");
            Console.WriteLine("exercicio 2 - Digite2");
            Console.WriteLine("exercicio 3 - Digite3");
            Console.WriteLine("exercicio 4 - Digite4");
            Console.WriteLine("exercicio 5 _ Digite5");
            Console.WriteLine("exercicio 6 - Digite6");

            exercicio =float.Parse(Console.ReadLine());  

            switch(exercicio)
            { 

            case 1: 
                Console.WriteLine("Exercicio dias da semana");
                Console.WriteLine("Digite um numero de 1 a 7 correspondente a um dia da semana:");
                dia = float.Parse(Console.ReadLine());


                switch (dia)
                {
                    case 1:
                        Console.WriteLine("O número digitado corresponde a domingo");
                        break;

                    case 2:
                        Console.WriteLine("O número digitado corresponde a segunda-feira");
                        break;

                    case 3:
                        Console.WriteLine("O número digitado corresponde a terça-feira");
                        break;

                    case 4:
                        Console.WriteLine("O número digitado corresponde a quarta-feira");
                        break;

                    case 5:
                        Console.WriteLine("O número digitado corresponde a quinta-feira");
                        break;

                    case 6:
                        Console.WriteLine("O número digitado corresponde a sexta-feira");
                        break;

                    case 7:
                        Console.WriteLine("O número digitado corresponde a sabado");
                        break;

                    default:
                        Console.WriteLine("Opção não valida");
                        break;
                }
                
break;



                    case 2 :
                    Console.WriteLine("Exercicio forma de pagamento");

                    Console.WriteLine("Digite o valor a ser pago:");
                    valordacompra = float.Parse(Console.ReadLine());

                    Console.WriteLine("=====Menu modo de pagamento======");
                    Console.WriteLine("1- dinheiro a vista");
                    Console.WriteLine("2- pix a vista");
                    Console.WriteLine("3- débito");
                    Console.WriteLine("4- credito");
                    modopagamento = float.Parse(Console.ReadLine());


                    switch (modopagamento)
                    {
                        case 1:

                            desconto = valordacompra - 0.15f;
                            Console.WriteLine("O valor a ser pago é:" +desconto);

                            break;


                        case 2:

                            desconto = valordacompra - 0.1f;
                            Console.WriteLine("O valor a ser pago é:" + desconto);

                            break ;


                       case 3:

                            desconto = valordacompra + 0.5f;
                            Console.WriteLine ("O valor a ser pago é:" + desconto);

                            break;


                        case 4:

                            desconto = valordacompra + 0.1f;
                            Console.WriteLine("O valor a ser pago é:" + desconto);

                            break;

                    }

 break;


                case 3:

                    Console.WriteLine("Exercicio meses ");

                    Console.WriteLine("Digite um numero de 1 a 12 que corresponda a algum mês:");
                    mes=float.Parse(Console.ReadLine());


                    switch (mes)
                    {
                        case 1:

                            Console.WriteLine("O numero digitado corresponde a janeiro que contém 31 dias");
                            break;


                        case 2:
                            Console.WriteLine(" digite o ano para saber o numero de dias correspondentes:");

                            if
                    }





            }
            Console.ReadKey();  

        }
    }
}
