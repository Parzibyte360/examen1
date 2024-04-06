/*Crea un programa en C# que presente un menú con las siguientes opciones:
    1. Determinar si un número ingresado por el usuario es positivo, negativo o cero. 
        Esta funcionalidad debe implementarse como una función.
    2. Imprimir un mensaje según el día de la semana ingresado por el usuario.
        Este proceso debe implementarse como un procedimiento.
    3. Calcular la suma de los primeros 100 números naturales. Este cálculo debe implementarse como una función.
    4. Imprimir todos los números desde 1 hasta el número ingresado por el usuario. 
        Este proceso debe implementarse como un procedimiento.
    5. Calcular el área de un círculo utilizando el radio ingresado por el usuario.
        Este cálculo debe implementarse como una función.
    6. Mostrar los elementos de un arreglo unidimensional predefinido.
        Este proceso debe implementarse como un procedimiento.
    7. Mostrar nombres de personas almacenados en una lista predefinida. 
        Este proceso debe implementarse como un procedimiento.
    8. Salir
El programa debe permitir al usuario seleccionar una opción del menú. Cada opción debe llamar a la función o procedimiento correspondiente y mostrar el resultado en la consola.
Cuando terminas de ejecutar una de las opciones, nuevamente te debe salir el Menú.
El programa solo debe terminar cuando le das la opción 8 de Salir
*/


void Ejercicio1 ()
{
    Console.WriteLine("Ingrese un numero:");
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());

    if (numeroIngresado == 0)
        Console.WriteLine("El numero ingresado fue 0");
    if (numeroIngresado > 0)
        Console.WriteLine("El numero ingresado es positivo");
    if (numeroIngresado < 0)
        Console.WriteLine("El numero ingresado es negativo");
}

void Ejercicio2 ()
{
    string diaSemana = "";
    Console.WriteLine("Ingrese el día de la semana");
    int numeroDia = Convert.ToInt32(Console.ReadLine());

    switch (numeroDia)
    {
        case 1:
            diaSemana = "Lunes";
            break;
        case 2:
            diaSemana = "Martes";
            break;
        case 3:
            diaSemana = "Miércoles";
            break;
        case 4:
            diaSemana = "Jueves";
            break;
        case 5:
            diaSemana = "Viernes";
            break;
        case 6:
            diaSemana = "Sábado";
            break;
        case 7:
            diaSemana = "Domingo";
            break;
        default:
            diaSemana = "Número incorrecto";
            break;
    }
    Console.WriteLine("El día de la semana que ingreso es");
    Console.WriteLine(diaSemana);
}

int Ejercicio3()
{
    int resultado = 0;
    for (int i = 1; i <= 100; i++)
    {
        resultado += i;
    }
    return resultado;
}

void Ejercicio4()
{
    Console.WriteLine("Ingrese un numero");
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Números del 1 al " + numeroIngresado + ":");

    for (int i = 1; i <= numeroIngresado; i++)
    {
        Console.WriteLine(i);
    }
}

double Ejercicio5()
{
    Console.Write("Ingrese el radio del circulo: ");
    double radio = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}

void Ejercicio6()
{
    Console.WriteLine("Contenido de un arreglo unidimensional de las 7 mejores escuderias de F1:");
    string[] escuderias = new string[7];
    escuderias[0] = "RedBull";
    escuderias[1] = "Ferrari";
    escuderias[2] = "Mercedes";
    escuderias[3] = "Aston Martin";
    escuderias[4] = "Mclaren";
    escuderias[5] = "Haas";
    escuderias[6] = "Williams";
    foreach (string s in escuderias)
    {
        Console.WriteLine(s);
    }
}

void Ejercicio7()
{
    List<string> personas = new List<string> { "Donatello", "Leo", "Bruno", "Kathia", "Paolo" };

    Console.WriteLine("Nombres de personas:");
    foreach (string nombre in personas)
    {
        Console.WriteLine(nombre);
    }
}

bool exit = false;
do
{
    Console.WriteLine("================* Menú *===============");
    Console.WriteLine("== 1.Número postivo o negativo       ==");
    Console.WriteLine("== 2.Dia de la semana                ==");
    Console.WriteLine("== 3.Sumar 100 primeros numeros      ==");
    Console.WriteLine("== 4.Imprimir numeros del 1 a x      ==");
    Console.WriteLine("== 5.Calcular area de circulo        ==");
    Console.WriteLine("== 6.Mostrar elementos de un arreglo ==");
    Console.WriteLine("== 7.Mostrar personas de una lista   ==");
    Console.WriteLine("== 8.Salir                           ==");
    Console.WriteLine("=======================================");
    Console.WriteLine("Ingrese el numero de la opcion que desea:");
    int respuesta = Convert.ToInt32(Console.ReadLine());

    switch (respuesta)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Console.WriteLine("La suma de los primeros 100 números naturales: " + Ejercicio3());
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Console.WriteLine("El area del circulo es: " + Ejercicio5());
            break;
        case 6:
            Ejercicio6();
            break;
        case 7:
            Ejercicio7();
            break;
        case 8:
            exit = true;
            break;
        default:
            Console.WriteLine("Opcion incorrecta, vuelva a intentarlo");
            break;
    }
} while (!exit);