//Condicional IF
string nome = "Ana";

if (nome == "Ana") 
{
    Console.WriteLine("Olá, Ana!");
}

string texto = "";
if (string.IsNullOrEmpty(texto))
{
    Console.WriteLine("A string está vazia.");
}

//Condicional IF/ELSE
int idade = 16;

if (idade >= 18) //se
{
    Console.WriteLine("Você é maior de idade");
}
else //se não
{
    Console.WriteLine("Você é menor de idade");
}

int numero = 7;

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}

double nota = 10;
if (nota >= 9.0)
{
    Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
}
else if (nota >= 7.0)
{
    Console.WriteLine("Você está aprovado.");
}
else if (nota >= 5.0)
{
    Console.WriteLine("Você está em recuperação.");
}
else if (nota >= 3.0)
{
    Console.WriteLine("Você está em risco de reprovação.");
}
else
{
    Console.WriteLine("Você esrá reprovado.");
}

//Condicional Switch
double pontuacao = 8.5;
//Arredondando a nota para o inteiro mais próximo - Floor arredonda para baixo. - Round() arredonda para cima se for 8.6
int faixaNota = (int)Math.Floor(pontuacao);
switch (faixaNota)
{
    case 10:
        Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
        break;
    case 9:
    case 8:
        Console.WriteLine("Você está aprovado.");
        break;
    case 7:
    case 6:
        Console.WriteLine("Você está em recuperação.");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("Voc~e está com risco de reprovação.");
        break;
    default:
        Console.WriteLine("Você foi reprovado.");
        break;
}
       