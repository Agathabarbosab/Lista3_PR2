using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
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

            float exercicio, dia, modopagamento, valordacompra, desconto, resto, ano, mes, n1, n2, operaçoes, resultado, cargo, salario, aumento, diferenca, menu;

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
                            ano=float.Parse(Console.ReadLine());

                            resto = ano % 4;

                            if (resto == 0)
                              Console.WriteLine("Fevereiro tem 29 dias");

                            else
                                Console.WriteLine("Fevereiro tem 28 dias");
                            break ;




                        case 3:

                            Console.WriteLine("O numero digitado corresponde a março que contém 31 dias");
                            break;


                        case 4:
                            Console.WriteLine("O numero digitado corresponde a abril que contém 30 dias ");
                            break;

                        case 5:
                            Console.WriteLine("O numero digitado corresponde a maio que comtém 31 dias");
                            break;

                        case 6:
                            Console.WriteLine("O numero digitado corresponde a junho que comtém 30 dias");
                            break;

                        case 7:
                            Console.WriteLine("O numero digitado corresponde a julho que comtém 31 dias");
                            break;

                        case 8:
                            Console.WriteLine("O numero digitado corresponde a agosto que comtém 31 dias");
                            break;

                        case 9:
                            Console.WriteLine("O numero digitado corresponde a setembro que contem 30 dias");
                            break;

                        case 10:
                            Console.WriteLine("O numero digitado corresponde a outubro que comtém 31 dias");
                            break;

                        case 11:
                            Console.WriteLine("O numero digitado corresponde a novembro que contém 30 dias");
                            break;

                        case 12:
                            Console.WriteLine("O numero digitado corresponde a dezembro que contém 31 dias");
                            break;  

                    }
                    break ;

                case 4:

                    //numeros
                    Console.WriteLine("digite o primriro numero:");
                    n1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("digite o segundo numero:");
                    n2 = float.Parse(Console.ReadLine());

                    //Operação
                    Console.WriteLine("Escolha a operação:");
                    Console.WriteLine("1 - adição");
                    Console.WriteLine("2 - subtração");
                    Console.WriteLine("3 - multiplicação");
                    Console.WriteLine("4 - divisão");
                    Console.WriteLine("5 - potencia");
                    operaçoes = float.Parse(Console.ReadLine());

                    switch (operaçoes)
                    {
                        case 1:
                            resultado = n1 + n2;
                            Console.WriteLine("O resultado da sua operação é: " + resultado);

                            break;

                        case 2:

                            resultado = n1 - n2;
                            Console.WriteLine("O resultado da sua operação é:" + resultado);
                            break ;

                        case 3:

                            resultado = n1 * n2;
                            Console.WriteLine("O resultado da sua o peração é:" + resultado);
                            break;

                        case 4:

                            resultado = n1 / n2;
                            Console.WriteLine("O resultado da sua operação é:" + resultado);
                            break;



                    }
                    break;

                case 5:

                    Console.WriteLine("Escolha o cargo do funcionario:");
                    Console.WriteLine("1 - Professor");
                    Console.WriteLine("2 - Secretario");
                    Console.WriteLine("3 - Publicitario");
                    Console.WriteLine("4 - Jornalista");
                    Console.WriteLine("5 - mecanico");
                    Console.WriteLine("6 - Estagiario");
                    Console.WriteLine("7 - Tecnico em TI");

                    cargo = float.Parse(Console.ReadLine());

                    switch (cargo)
                    {
                        case 1:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.075f;
                            Console.WriteLine("O seu salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break;

                        case 2:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.097f;
                            Console.WriteLine("O seu salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break ;

                            case 3:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.117f;
                            Console.WriteLine("O salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break;

                        case 4:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.089f;
                            Console.WriteLine("O seu salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break;

                        case 5:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.1324f;
                            Console.WriteLine("O seu salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break;


                        case 6:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.104f;
                            Console.WriteLine("O seu salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break;

                        case 7:

                            Console.WriteLine("Digite o seu salario:");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + 0.146f;
                            Console.WriteLine("O seu salario sera:" + aumento);
                            diferenca = aumento - salario;

                            break;







                    }
                    break;

                case 6:
                
                    Console.WriteLine("qual o valor da sua renda mensal:");
                    Console.WriteLine("1- ate  1.903,98");
                    Console.WriteLine("2- entre R$ 1.903,99 e R$ 2.826,65");
                    Console.WriteLine("3- entre  R$ 2.826,66 e R$ 3.751,05");
                    Console.WriteLine("4- entre R$ 3.751,06 e R$ 4.664,68");
                    Console.WriteLine("5- acima de R$ 4.664,68");

                    menu = float.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Voce esta insento de imposto de renda ");

                            break;
                        case 2:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            resto = salario - 0.075f;

                            Console.WriteLine("seu salrio liquido é de: " + resto);
                            break;
                        case 3:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            resto = salario - 0.15f;

                            Console.WriteLine("seu salrio liquido é de: " + resto);
                            break;
                        case 4:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            resto = salario - 0.225f;

                            Console.WriteLine("seu salrio liquido é de: " + resto);
                            break;
                        case 5:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            resto = salario - 0.275f;

                            Console.WriteLine("seu salrio liquido é de: " + resto);
                            break;

                        default:
                            Console.WriteLine("opção invalida");
                            break;
















                    }
                    break;

                    Console.ReadKey();  

        }
    }
}
