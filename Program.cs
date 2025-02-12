/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

/*
string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage() + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
*//*
string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage() + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}
*/

// Configurar pontos de interrupção condicionais em C# ==================================

// Usar um ponto de interrupção padrão para analisar um aplicativo 
// de processamento de dados:

/*
int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i);

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true) ;

static void LoadProducts(string[,] products, int productCount)
{
    Random rand = new Random();

    for (int i = 0; i < productCount; i++)
    {
        int num1 = rand.Next(1, 10000) + 10000;
        int num2 = rand.Next(1, 101);

        string prodID = num1.ToString();

        if (num2 < 91)
        {
            products[i, 1] = "existing";
        }
        else if (num2 == 91)
        {
            products[i, 1] = "new";
            prodID = prodID + "-n";
        }
        else
        {
            products[i, 1] = "obsolete";
            prodID = prodID + "-0";
        }

        products[i, 0] = prodID;
    }
}

static string Process1(string[,] products, int item)
{
    Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

    return products[item, 1];
}

static string Process2(string[,] products, int item)
{
    Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
    if (products[item, 1] == "new")
        Process3(products, item);

    return "continue";
}

static void Process3(string[,] products, int item)
{
    Console.WriteLine($"Process3 message - processing product information for 'new' product");
}
*/

// Monitorar as variáveis e o fluxo de execução:

// Analisar as seções da exibição Execução e Depuração

/*
string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
*/

// Monitorar as expressões de inspeção

/*
bool exit = false;
var rand = new Random();
int num1, num2;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);
    double div = (double)num1 / num2;

    Console.WriteLine($" A divisão entre {num2} e {num1} é {div}!");

    Console.Write("Deseja sair? (s/n): ");
    exit = Console.ReadLine().Equals("s", StringComparison.CurrentCultureIgnoreCase);

} while (!exit);
*/

// Concluir uma atividade de desafio usando o depurador:

// Desafio de estado de variável

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/

/*
int x = 5;
x = ChangeValue(x);

ChangeValue(x);

Console.WriteLine(x);

int ChangeValue(int value) 
{
    value = 10;
    return value;
}
*/

// Exemplos de código para exceções geradas pelo compilador -------------------

// ArrayTypeMismatchException:

// Uma exceção do tipo ArrayTypeMismatchException é gerada quando há uma 
// tentativa de armazenar um elemento do tipo errado em uma matriz. Ex:

/*
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs
*/

// DivideByZeroException

// Uma exceção do tipo DivideByZeroException ocorre quando há uma tentativa de
// dividir um número inteiro ou decimal por zero. Ex:

/*
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs
*/

// FormatException

// Uma exceção do tipo FormatException ocorre quando o formato de um argumento
// é inválido ou quando uma cadeia de caracteres de formato composto não está
// bem formada. Ex: 

/*
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs
*/

// IndexOutOfRangeException

// A exceção do tipo IndexOutOfRangeException é gerada quando há uma tentativa
// de acessar um elemento de uma matriz ou de uma coleção com um índice que
// está fora dos limites. Ex:

/*
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs
*/

// InvalidCastException

// Uma exceção do tipo InvalidCastException é gerada quando há uma tentativa de
// fazer uma conversão inválida ou explícita. Ex:

/*
object obj = "This is a string";
int num = (int)obj;
*/

// NullReferenceException

// Uma exceção do tipo NullReferenceException é gerada quando há uma tentativa de acessar um membro em um tipo cujo valor é nulo.
// Dois exemplos são mostrados.

/*
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;
*/

// -------------------------

/*
string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());
*/

// OverflowException

// Uma exceção do tipo OverflowException ocorre quando uma operação aritmética
// tenta atribuir um resultado que está fora do intervalo do tipo de dados de 
// destino. Ex: 

/*
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);
*/

// Exercício – Implementar o tratamento de exceção try-catch

// Implementar um try-catch simples

/*
using System.Security.Cryptography;

double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
Console.WriteLine(float1 / float2);
Console.WriteLine(number1 / number2);
}
catch
{
    System.Console.WriteLine("An exception has been caught");
}

Console.WriteLine("Exit program");
*/

// Capturar exceções geradas nos métodos chamados --------------------

/*
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
*/

// Analisar a solução do desafio try-catch

/*
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught in Process1");
    }

}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}
*/

// Acessar as propriedades de um objeto de exceção -----------------------

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}