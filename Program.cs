 //1.- Print all of the integers from 1 to 255.

static void PrintNumbers(){
    int i = 1;
    while (i < 256) {
        Console.WriteLine(i);
        i++;
}
}
PrintNumbers();

Console.WriteLine("--------------------FIN 1-----------------");

// 2.-Imprimir numeros impares entre el 1 y el 255

    static void PrintOdds(){
        for (int x = 1; x <= 255; x++){
            if(x % 2 != 0){
                Console.WriteLine(x);
            }
        }   
    }
    PrintOdds();

Console.WriteLine("----------------FIN 2----------------");

//3.- imprime Suma 

static void PrintSum(){
    int sum = 0;
    for (int z = 0; z < 256; z++){
        sum += z;
        Console.WriteLine($"Numero: {z}, suma: {sum}");
    }
}
PrintSum();
Console.WriteLine("----------------FIN 3----------------");

// 4.-Iterar a través de una matriz​

static void LoopArray(int[] numeros){
    foreach (int number in numeros){
        Console.WriteLine(number);
    }
    int[] Array = { 8, 9, 10, 11, 12, 13, 14, 15 };
LoopArray(Array);
}

Console.WriteLine("--------------------FIN 4--------------");

//5.-Encuentra el valor máximo

static int FindMax(int[] numbers){
    return numbers.Max();
}

int[] Array2 = { 13, -20, -7, 30, 32, -6 };

int maxValue = FindMax(Array2);
Console.WriteLine("Value Max is: " + maxValue);

Console.WriteLine("-------------------FIN 5-------------");

// 6.- Obtén el promedio

static void GetAverage(int[] numero)
{
    int suma = 0;
    for (int n = 0; n < numero.Length; n++)
    {
        suma += numero[n];
    }

    double average = (double)suma / numero.Length; 

    Console.WriteLine("El promedio de los valores en la matriz es: " + average);
}
int[] numero = { 2, 10, 3 };
GetAverage(numero);

Console.WriteLine("---------------------FIN 6-------------");

//7.-  Lista con números impares​
static List<int> OddList()
{
    List<int> OddLista = new List<int>();
    int i = 1;

    while (i <= 255)
    {
        if (i % 2 != 0)
        {
            OddLista.Add(i);
        }
        i++;
    }

    int j = 0;
    while (j < OddLista.Count)
    {
        Console.WriteLine(OddLista[j]);
        j++;
    }

    return OddLista;
}

OddList();

OddList();






















