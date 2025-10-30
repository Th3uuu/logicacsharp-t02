//variáveis
char letra = 'a';
string nome = "João";
float temperatura = 36.5f;
double salario = 12345.67;
bool estaChovendo = true;

// Alterando as variáveis
letra = 'b';
nome = "Maria";
temperatura = 37.0f;
salario = 150000.50;
estaChovendo = false;


const char simbolo = '$';
const string saudacao = "Bem-vindo ao C#!";
const float pi = 3.14159f;
const double altura = 1.75;
const bool ehVerdade = false;
const int numero = 14;


//Exibindo os valores originais por interpolação
Console.WriteLine("Valores originais");
Console.WriteLine($"Letra: {letra}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Salário: {salario}");
Console.WriteLine($"Está chovendo? {estaChovendo}");

//Exibindo os valores originais por concatenação
Console.WriteLine("\nConstantes:");
Console.WriteLine("´Símbolo: " + simbolo);
Console.WriteLine("Saudação: " + saudacao);
Console.WriteLine("Valor de pi: " + pi);
Console.WriteLine("Altura: " + altura);
Console.WriteLine("È verdade? " + ehVerdade);
Console.WriteLine("Número: " + numero);

