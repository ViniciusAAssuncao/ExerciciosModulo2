using System;


namespace ModuleWeek {
    class Program {
        static void Main(string[] args) {
            string nome;
            int anoNascimento;
            double salario;
            double reajuste;

            Console.WriteLine("Digite o nome do funcionário: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o ano de nascimento do funcionário: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de reajuste: ");
            reajuste = double.Parse(Console.ReadLine());

            int idade = 2022 - anoNascimento;
            double salarioReajustado = salario + (salario * (reajuste / 100));

            Console.WriteLine($"O funcionário {nome} tem {idade} anos e ganha R$ {salarioReajustado}");

            int[] notas = new int[6];
            int contador = 0;
            int soma = 0;
            int media = 0;

            for (int i = 0; i < notas.Length; i++) {
                Console.WriteLine("Digite a nota do aluno: ");
                notas[i] = int.Parse(Console.ReadLine());
                if (notas[i] > 7) {
                    contador++;
                }
                if (notas[i] < 0) {
                    contador++;
                }
                if (notas[i] == 0) {
                    contador++;
                }
                soma = soma + notas[i];
            }
            media = soma / notas.Length;

            Console.WriteLine($"A média da nota da prova é {media}");
            Console.WriteLine($"Foram {contador} alunos com nota maior que 7");

            int num1, num2;
            string operacao;
            double resultado;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            operacao = Console.ReadLine();

            if (operacao == "+") {
                resultado = num1 + num2;
            }
            else if (operacao == "-") {
                resultado = num1 - num2;
            }
            else if (operacao == "*") {
                resultado = num1 * num2;
            }
            else if (operacao == "/") {
                resultado = num1 / num2;
            }
            else {
                Console.WriteLine("Operação inválida");
            }

            Console.WriteLine($"O resultado é {resultado}");

            Console.WriteLine("Digite 1 para sair ou qualquer outro número para continuar: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                Console.WriteLine("Saindo...");
            }
            else {
                Console.WriteLine("Digite o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação: ");
                operacao = Console.ReadLine();

                if (operacao == "+") {
                    resultado = num1 + num2;
                }
                else if (operacao == "-") {
                    resultado = num1 - num2;
                }
                else if (operacao == "*") {
                    resultado = num1 * num2;
                }
                else if (operacao == "/") {
                    resultado = num1 / num2;
                }
                else {
                    Console.WriteLine("Operação inválida");
                }

                Console.WriteLine($"O resultado é {resultado}");
            }

            int opcao2;
            string operacao2;
            double resultado2;

            Console.WriteLine("Digite 1 para adição, 2 para subtração, 3 para multiplicação, 4 para divisão ou 5 para sair: ");
            opcao2 = int.Parse(Console.ReadLine());

            if (opcao2 == 1) {
                operacao2 = "+";
            }
            else if (opcao2 == 2) {
                operacao2 = "-";
            }
            else if (opcao2 == 3) {
                operacao2 = "*";
            }
            else if (opcao2 == 4) {
                operacao2 = "/";
            }
            else if (opcao2 == 5) {
                Console.WriteLine("Saindo...");
            }
            else {
                Console.WriteLine("Opção inválida");
            }

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (operacao2 == "+") {
                resultado2 = num1 + num2;
            }
            else if (operacao2 == "-") {
                resultado2 = num1 - num2;
            }
            else if (operacao2 == "*") {
                resultado2 = num1 * num2;
            }
            else if (operacao2 == "/") {
                resultado2 = num1 / num2;
            }
            else {
                Console.WriteLine("Operação inválida");
            }

            Console.WriteLine($"O resultado é {resultado2}");

            int opcao3;
            double saldo = 0;
            double valor;

            Console.WriteLine("Digite 1 para consultar saldo ou 2 para depositar ou 3 para sacar ou 4 para sair: ");
            opcao3 = int.Parse(Console.ReadLine());

            if (opcao3 == 1) {
                Console.WriteLine($"O seu saldo é {saldo}");
            }
            else if (opcao3 == 2) {
                Console.WriteLine("Digite o valor do depósito: ");
                valor = double.Parse(Console.ReadLine());
                saldo = saldo + valor;
                Console.WriteLine($"O seu saldo é {saldo}");
            }
            else if (opcao3 == 3) {
                Console.WriteLine("Digite o valor do saque: ");
                valor = double.Parse(Console.ReadLine());
                saldo = saldo - valor;
                Console.WriteLine($"O seu saldo é {saldo}");
            }
            else if (opcao3 == 4) {
                Console.WriteLine("Saindo...");
            }
            else {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}