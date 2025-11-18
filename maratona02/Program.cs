/*Exercícios com if, else e elseif:
1. Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários 
quando for hora de reabastecer um produto. 
Escreva um código que verifique a quantidade de um produto em estoque. Se a 
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor, 
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".
*/

int estoque = 3; // você pode trocar esse valor

if (estoque < 5)
{
    Console.WriteLine("Alerta: Baixo estoque. Por favor, reabasteça este produto.");
}
else
{
    Console.WriteLine("Estoque suficiente.");
}
/*2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte 
de uma promoção de vendas. Escreva um código que determine o valor total da 
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um 
desconto de 10% e exiba: "Desconto de 10% aplicado!". Se o valor total for R$ 
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um 
desconto de 10%.".
*/

double valorTotal = 250.00; // você pode trocar esse valor
if (valorTotal > 200)
{
    double desconto = valorTotal * 0.10;
    double valorFinal = valorTotal - desconto;
    Console.WriteLine("Desconto de 10% aplicado!");
    Console.WriteLine("Valor final: R$ " + valorFinal);
}
else
{
    Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10%.");
}
/*Exercícios com switch:
1. Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana, 
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
"Segunda-feira", etc.).
*/

int dia = 3; // coloque um número de 1 a 7

switch (dia)
{
    case 1:
        Console.WriteLine("Domingo");
        break;

    case 2:
        Console.WriteLine("Segunda-feira");
        break;

    case 3:
        Console.WriteLine("Terça-feira");
        break;

    case 4:
        Console.WriteLine("Quarta-feira");
        break;

    case 5:
        Console.WriteLine("Quinta-feira");
        break;

    case 6:
        Console.WriteLine("Sexta-feira");
        break;

    case 7:
        Console.WriteLine("Sábado");
        break;

    default:
        Console.WriteLine("Número inválido. Digite um valor de 1 a 7.");
        break;
        /*2. Faça um programa que calcule o preço final de um produto com base em um 
        código de desconto
        O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto 
        correspondente ao preço do produto.
        o Código 1: 10% de desconto
        o Código 2: 20% de desconto
        o Código 3: 30% de desconto
        o Se o código for inválido, deve mostrar uma mensagem de erro.
        */

        double preco = 100.00; // preço do produto
        int codigo = 2; // coloque um código de 1 a 3

        switch (codigo)
        {
            case 1:
                preco = preco - (preco * 0.10);
                Console.WriteLine("Desconto de 10% aplicado! Preço final: R$ " + preco);
                break;

            case 2:
                preco = preco - (preco * 0.20);
                Console.WriteLine("Desconto de 20% aplicado! Preço final: R$ " + preco);
                break;

            case 3:
                preco = preco - (preco * 0.30);
                Console.WriteLine("Desconto de 30% aplicado! Preço final: R$ " + preco);
                break;

            default:
                Console.WriteLine("Código inválido. Digite um valor de 1 a 3.");
                break;
                /*Exercícios com for:
                1. Faça um programa de tabuada de multiplicação 
                Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de 
                repetição for.
                O programa deve exibir, para cada número de 7, a multiplicação desse número 
                pelos valores de 1 a 10.
                */

                int numero = 7;

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                }
                /*2. Faça um programa para calcular a média
                Crie um programa que receba 10 números inteiros e calcule a média desses 
                números. Utilize o laço for para ler os números e calcular a média.
                */
               

int[] numeros = { 5, 8, 10, 3, 7, 12, 0, -1, 20, 6 }; // troque esses valores
                int soma = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    soma += numeros[i];
                    Console.WriteLine("Número " + (i + 1) + ": " + numeros[i]);
                }

                double media = soma / (double)numeros.Length;
                Console.WriteLine("A média dos números é: " + media);
        }
}
/*Exercícios com while:
1. Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no 
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar" 
cada visitante até que a capacidade máxima seja atingida. A cada visitante 
adicional, exiba o número total de visitantes até o momento.
*/

int visitantes = 50;
int capacidadeMaxima = 50;
while (visitantes < capacidadeMaxima)
{
    visitantes++;
    Console.WriteLine("Visitantes no museu: " + visitantes);
}
{ 
    Console.WriteLine("Capacidade máxima atingida!");
}
/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo 
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O 
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha 
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de 
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas.".
*/
        string senhaCorreta = "senha123";
string[] tentativasSimuladas = { "senha120", "senha121", "senha123" };
int tentativas = 0;
int limite = 3;
while (tentativas < limite && tentativas < tentativasSimuladas.Length)
{
    string senhaDigitada = tentativasSimuladas[tentativas];
    Console.WriteLine("Tentativa " + (tentativas + 1) + ": " + senhaDigitada);
    if (senhaDigitada == senhaCorreta)
    {
        Console.WriteLine("Login bem-sucedido!");
        return;
    }
    tentativas++;
}
{ 
    Console.WriteLine("Conta bloqueada por excesso de tentativas.");
}
