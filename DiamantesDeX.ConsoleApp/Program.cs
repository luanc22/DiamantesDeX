using System;

namespace DiamantesDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declarao de variaveis. [OK]
            string inputDiamante;
            char[] verificarInput = new char[400];
            bool checarDigito;
            bool somenteLetra = true;

            int numDeX;
            int checarImpar;

            int i = 0;
            int j = 1;

            bool opcaoValida = false;
            string fecharBotao;
            bool fecharApp = false;
            #endregion
            while (fecharApp == false)
            {
                #region Input de valores. [OK]
                Console.WriteLine("===== Diamante em X =====");
                Console.WriteLine("");
                Console.WriteLine("Utilize esse programa para gerar a arte ASCII de um diamante formado por X.");
                Console.WriteLine("");
                Console.WriteLine("===================================");
                Console.WriteLine("");

                Console.Write("Digite um numero impar para gerar o diamante: ");
                inputDiamante = Console.ReadLine();
                inputDiamante = inputDiamante.Replace(" ", "");
                verificarInput = inputDiamante.ToCharArray();
                #endregion

                #region Checar se tem letras no input. [OK]
                for (i = 0; i < verificarInput.Length; i++)
                {
                    checarDigito = char.IsDigit(verificarInput[i]);

                    if (checarDigito == false)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERRO!\nLetra identificada, por favor, digite apenas numeros!");
                        Console.WriteLine("");
                        Console.ResetColor();
                        Console.Write("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        Console.Clear();
                        somenteLetra = false;
                    }
                }

                if (somenteLetra == false)
                {
                    continue;
                }
                #endregion

                #region Checar por erros no input de numeros. [OK]
                numDeX = int.Parse(inputDiamante);
                checarImpar = numDeX % 2;

                if (checarImpar == 0)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO!\nNumero par identificado, por favor, inserir somente numeros impares.");
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.Write("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (numDeX <= 2)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO!\n O numero minimo de colunas sao 3, por favor, insira 3 ou mais colunas.");
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.Write("Aperte ENTER para prosseguir.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                #endregion;

                #region Output do diamante. [OK]
                Console.ForegroundColor = ConsoleColor.Blue;

                #region Parte superior. [OK]
                for (i = 0; i <= numDeX / 2; i++)
                {
                    for (j = 1; j <= numDeX - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("x");
                    }

                    Console.WriteLine("");
                }
                #endregion

                #region Linha central. [OK]
                for (j = 0; j < numDeX / 2; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j < numDeX + 1; j++)
                {
                    Console.Write("x");
                }

                Console.WriteLine("");
                #endregion

                #region Parte inferior. [OK]
                for (i = numDeX / 2; i >= 1; i--)
                {
                    for (j = 1; j <= numDeX - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("x");
                    }

                    Console.WriteLine("");
                }
                #endregion

                Console.ResetColor();
                #endregion

                Console.WriteLine("");

                #region Menu 
                opcaoValida = false;
                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar rodar o programa novamente e inserir novos comandos, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                    #endregion
                }
            }
        }
    }
}
