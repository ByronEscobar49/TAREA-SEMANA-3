// CALCULAR EL MAYOR DE 3 NÚMEROS
using System;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("El mayor de tres Números");
int num1, num2, num3;
int mayor;
Console.WriteLine("Ingrese tres numeros");
num1 =Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2&& num1 >= num3)
{
    mayor = num1;
}
else if (num2 >= num1 && num2 >= num3)
{
    mayor = num2;
}    
else
{
    mayor = num3;
}
Console.WriteLine("el mayor de los tres numeros es:\t" + mayor+ "\n");
Console.ResetColor();

// INGRESO A UN CLUB
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("VALIDAR EDAD PARA INGRESO AL CLUB:");
Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());
if (edad >= 18)
{
    Console.WriteLine("****¡Bienvenido al club!****\n\n");
}
else
{
    Console.WriteLine("Lo siento, no puedes ingresar al club porque eres menor de edad.\n\n");
}
Console.ResetColor();

// Solicitar el precio original del producto
Console.WriteLine("CALCULAR EL PRECIO FINAL DEL PRODUCTO");
Console.WriteLine("Ingrese el precio original del producto:");
double precioOriginal = double.Parse(Console.ReadLine());

double descuento = 0;
if (precioOriginal > 100)
{
    descuento = precioOriginal * 0.1;
}
double precioFinal = precioOriginal - descuento;
Console.WriteLine("El precio final es: Q{0}", precioFinal+"\n");


// Solicitar al usuario un nombre de usuario y una contraseña
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("VALIDAR USUARIO Y CONTRASEÑA");
Console.WriteLine("Ingrese su nombre de usuario:");
string Usuario = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña:");
string contraseña = Console.ReadLine();

bool accesoPermitido = false;
if (Usuario == "byron" && contraseña == "1234")
{
    accesoPermitido = true;
}

if (accesoPermitido)
{
    Console.WriteLine("***¡Acceso permitido!***\n\n");
}
else
{
    Console.WriteLine("Lo siento, las credenciales no son válidas.\n\n");
}
Console.ResetColor();


// Solicitar un número al usuario
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("DETERMINAR SI UN NUMERO ES PAR O IMPAR:");
Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El número es par.\n\n");
}
else
{
    Console.WriteLine("El número es impar.\n\n");
}
Console.ResetColor();


// Solicitar al usuario el monto del préstamo
Console.WriteLine("MOSTRAR UN MESNSAJE DE APROBACION DE UN PRESTAMO:");
Console.WriteLine("Ingrese el monto del préstamo:");
double montoPrestamo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su edad:");
int edad2 = int.Parse(Console.ReadLine());

bool prestamoAprobado = false;
if (montoPrestamo < 5000 || edad2 > 60)
{
    prestamoAprobado = true;
}

if (prestamoAprobado)
{
    Console.WriteLine("***¡Su préstamo ha sido aprobado!***\n\n");
}
else
{
    Console.WriteLine("Lo siento, su solicitud de préstamo ha sido rechazada.\n\n");
}


// Solicitar al usuario el tipo de figura geométrica
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("CALCULAR EL AREA DE UNA FIGURA GEOMETRICA");
Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
string tipoFigura = Console.ReadLine().ToLower();

double area = 0;
if (tipoFigura == "triángulo")
{
    Console.WriteLine("Ingrese la base del triángulo:");
    double baseTriangulo = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del triángulo:");
    double alturaTriangulo = double.Parse(Console.ReadLine());
    area = (baseTriangulo * alturaTriangulo) / 2;
}
else if (tipoFigura == "cuadrado")
{
    Console.WriteLine("Ingrese el lado del cuadrado:");
    double ladoCuadrado = double.Parse(Console.ReadLine());
    area = ladoCuadrado * ladoCuadrado;
}
else if (tipoFigura == "círculo")
{
    Console.WriteLine("Ingrese el radio del círculo:");
    double radioCirculo = double.Parse(Console.ReadLine());
    area = Math.PI * radioCirculo * radioCirculo;
}
else
{
    Console.WriteLine("El tipo de figura geométrica no es válido.\n");
}
if (area > 0)
{
    Console.WriteLine("El área de la figura es: {0}", area+"\n\n");
}
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("EJERCIICOS USANDO SWITCH");
Console.ResetColor();

// Solicitar al usuario un número del 1 al 5 en letra
Console.WriteLine("CONVERTIR UN NUMERO DE LETRAS A NUMERO:");
Console.WriteLine("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco):");
string numeroEnLetra = Console.ReadLine().ToLower();

int numeroEnDigito = 0;
switch (numeroEnLetra)
{
    case "uno":
        numeroEnDigito = 1;
        break;
    case "dos":
        numeroEnDigito = 2;
        break;
    case "tres":
        numeroEnDigito = 3;
        break;
    case "cuatro":
        numeroEnDigito = 4;
        break;
    case "cinco":
        numeroEnDigito = 5;
        break;
    default:
        Console.WriteLine("El número en letra no es válido.\n");
        break;
}
if (numeroEnDigito > 0)
{
    Console.WriteLine("El número en dígito es: {0}", numeroEnDigito +"\n\n");
}


// Solicitar al usuario un número del 1 al 7
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("MOSTRAR EL DIA DE LA SEMANA A TRAVES DE UN NUMERO:");
Console.WriteLine("Ingrese un número del 1 al 7:");
int numero3 = int.Parse(Console.ReadLine());

string diaSemana = "";
switch (numero3)
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
        Console.WriteLine("El número no es válido.\n\n");
        break;
}

if (diaSemana != "")
{
    Console.WriteLine("El día de la semana correspondiente es: {0}", diaSemana + "\n\n");
}
Console.ResetColor();


// Solicitar al usuario el tipo de servicio
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("CALCULAR EL IMPORTE A PAGAR DE UN SERVICIO:");
Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
string tipoServicio = Console.ReadLine().ToLower();

double importe = 0;
switch (tipoServicio)
{
    case "lavado de auto":
        importe = 20;
        break;
    case "cambio de aceite":
        importe = 50;
        break;
    case "revisión mecánica":
        importe = 100;
        break;
    default:
        Console.WriteLine("El tipo de servicio no es válido.\n\n");
        break;
}

if (importe > 0)
{
    Console.WriteLine("El importe a pagar es: {0}", importe +"\n\n");
}
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
// Solicitar al usuario el idioma de su preferencia
Console.WriteLine("MOSTRAR UN MENSAJE DE BIENVENIDA EN DIFERENTES IDIOMAS:");
Console.WriteLine("Ingrese el idioma de su preferencia (español, inglés, francés):");
string idioma = Console.ReadLine().ToLower();

string mensajeBienvenida = "";
switch (idioma)
{
    case "español":
        mensajeBienvenida = "Bienvenido!";
        break;
    case "inglés":
        mensajeBienvenida = "Welcome!";
        break;
    case "francés":
        mensajeBienvenida = "Bienvenue!";
        break;
    default:
        Console.WriteLine("El idioma no es válido.\n");
        break;
}
if (mensajeBienvenida != "")
{
    Console.WriteLine(mensajeBienvenida+"\n\n");
}
Console.ResetColor();


// Solicitar al usuario la calificación del examen
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("EVALUAR LA CALIFICACION DE UN EXAMEN:");
Console.WriteLine("Ingrese la calificación del examen:");
int calificacion = int.Parse(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkMagenta;
string mensajeDesempeno = "";
switch (calificacion)
{
    case >= 90:
        mensajeDesempeno = "Excelente";
        break;
    case 80:
    case 81:
    case 82:
    case 83:
    case 84:
    case 85:
    case 86:
    case 87:
    case 88:
    case 89:
        mensajeDesempeno = "Notable";
        break;
    case 70:
    case 71:
    case 72:
    case 73:
    case 74:
    case 75:
    case 76:
    case 77:
    case 78:
    case 79:
        mensajeDesempeno = "Buena";
        break;
    case 61:
    case 62:
    case 63:
    case 64:
    case 65:
    case 66:
    case 67:
    case 68:
    case 69:
        mensajeDesempeno = "Suficiente";
        break;
    case <=60:
        mensajeDesempeno = "No aprobatoria";
        break;
    default:
        Console.WriteLine("La calificación no es válida. Debe ser un número entero entre 0 y 100.");
        break;
}

if (mensajeDesempeno != "")
{
    Console.WriteLine("Su desempeño en el examen es: {0}", mensajeDesempeno);
}
Console.ResetColor();
