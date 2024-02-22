//ESTRUCTURAS CONDICIONALES

while (true)     //1. CALCULAR EL MAYOR DE TRES NÚMEROS
{ //Se utiliza un bucle while para volver a pedir los datos si se produce un error al ingresar un letra.
    try  
    {   
        Console.WriteLine("\t.:Calcular el mayor de tres numeros:.");
        Console.Write("Ingrese el primer numero: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        float num2 = float.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        float num3 = float.Parse(Console.ReadLine());

        //Calcular el número mayor 
        float mayor = Math.Max(Math.Max(num1, num2), num3);

        Console.WriteLine($"El numero mayor es: {mayor}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("¡El valor introducido no es un número!");
        Console.ReadKey();
        Console.Clear();
    }
}
Console.ReadKey();
Console.Clear();

while (true)     //2.VALIDAR EDAD PARA INGRESAR A UN CLUB
{
    try  
    {   
        Console.WriteLine("\t.:Validar edad para ingresar a un club:.");
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());
        if (edad >= 18)
        {
            Console.Write("¡Tienes permitido ingresar al club!");
        }
        else
        {
            Console.Write("¡No tiene la edad requerida para ingresar al club!");
        }
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("¡El valor introducido no es un número!");
        Console.ReadKey();
        Console.Clear();
    }
}
Console.ReadKey();
Console.Clear();

while (true)     //3.CALCULAR EL PRECIO FINAL DE UN PRODUCTO
{
    try
    {   
        Console.WriteLine("\t.:Calcular precio final de un producto:.");
        Console.Write("\nIngrese el precio original del producto ");
        Console.Write("\nSe aplicara un descuento del 10% si es nayor de Q.100.00: ");
        double precioOriginal = double.Parse(Console.ReadLine());
        double descuento = 0;
        if (precioOriginal > 100)
        {
            descuento = precioOriginal * 0.1;
        }
        double precioFinal = precioOriginal - descuento;
        Console.WriteLine($"El precio final del producto es: {precioFinal:C2}");//C2: muestra el valor con dos decimales
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("¡El valor introducido no es un número!");
        Console.ReadKey();
        Console.Clear();
    }
}
Console.ReadKey();
Console.Clear();


//4.VALIDAR USUARIO Y CONTRASEÑA
string usuarioC = "usuario";
string contraseñaC = "contraseña";

Console.WriteLine("\t.:Validar Usuario y Contraseña:.");
Console.Write("Ingrese el nombre de usuario: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese la contraseña: ");
string contraseña = Console.ReadLine();

//Validar las credenciales
bool accesoPermitido = (nombre == usuarioC) && (contraseña == contraseñaC);

//Mostrar el mensaje de acceso
if (accesoPermitido)
{
    Console.WriteLine("Acceso permitido.");
}
else
{
    Console.WriteLine("Credenciales incorrectas. Acceso denegado");
}
Console.ReadKey();
Console.Clear();


while (true)      //5.DETERMINAR SI UN NÚMERO ES PAR O IMPAR
{
    try
    {   
        Console.WriteLine("\t.:Determinar número par o impar:.");
        Console.Write("Ingrese un número: ");
        int num1 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("¡El valor introducido no es un número!");
        Console.ReadKey();
        Console.Clear();
    }
}
Console.ReadKey();
Console.Clear();


//6.APROBACIÓN O RECHAZO DE PRESTAMO
Console.WriteLine("\t.:Aprobación o rechazo de prestamo:.");
Console.Write("Ingrese el monto del prestamo: ");
double monto = double.Parse(Console.ReadLine());
Console.Write("Ingrese su edad: ");
int edad2 = int.Parse(Console.ReadLine());
if (monto < 5000 || edad2 > 60)
{
    Console.WriteLine("Prestamo Aprobado");
}
else
{
    Console.WriteLine("Prestamo Rechazado. No cumple requisitos ");
}
Console.ReadKey();
Console.Clear();


//7. CALCULAR EL ÁREA DE UNA FIGURA GEOMÉTRICA
int opcion;
do
{
    Console.WriteLine("\t.:Calcular área de una figura geométrica:.");
    Console.Write("\n1. Triángulo ");
    Console.Write("\n2. Cuadrado ");
    Console.Write("\n3. Círculo ");
    Console.Write("\n4. Salir ");
    Console.Write("\nElija la opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("\tCalcular área de un triangulo");
            Console.Write("Ingrese la base del triangulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine($"El área del triángulo es: {areaTriangulo:F2}");
            break;
        case 2:
            Console.WriteLine("\tCalcular área de un cuadrado");
            Console.Write("Ingrese la longitud del lado del cuadrado: ");
            double ladoCuadrado = double.Parse(Console.ReadLine());

            double areaCuadrado = ladoCuadrado * ladoCuadrado;

            Console.WriteLine($"El área del cuadrado es: {areaCuadrado:F2}");
            break;
        case 3:
            Console.WriteLine("\tCalcular el área de un circulo");
            Console.Write("Ingrese el radio del círculo: ");
            double radioCirculo = double.Parse(Console.ReadLine());

            double areaCirculo = Math.PI * radioCirculo * radioCirculo;

            Console.WriteLine($"El área del círculo es: {areaCirculo:F2}");
            break;

    }
    Console.ReadKey();
    Console.Clear();
} while (opcion != 4);
Console.Clear();



//EJERCICIOS USANDO SWITCH


//1.CONVERTIR UN NÚMERO DE LETRA A NÚMERO
int numeroDigito;
Console.WriteLine("\t.:Convertir un número de letra a digito:.");
Console.Write("Ingrese un número del 1 al 5 en letra: ");
string numeroLetra = Console.ReadLine();
numeroDigito = 0;

switch (numeroLetra)
 {
   case "uno":
        numeroDigito = 1;
        break;
   case "dos":
        numeroDigito = 2;
        break;
   case "tres":
        numeroDigito = 3;
        break;
   case "cuatro":
        numeroDigito = 4;
        break;
   case "cinco":
        numeroDigito = 5;
        break;
   default:
        Console.WriteLine("El número ingresado no es válido.");
        return;
}
Console.WriteLine($"El número en dígito es: {numeroDigito}");
Console.ReadKey();
Console.Clear();


//2.MOSTRAR EL DIA DE LA SEMANA A PARTIR DE UN NÚMERO
Console.WriteLine("\t.:Mostrar el dia de la semana a partir de un número:.");
Console.Write("Ingrese un número del 1 al 7: ");
int numero = int.Parse(Console.ReadLine());
string dia;

switch (numero)
{
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Lunes";
        break;
    case 3:
        dia = "Martes";
        break;
    case 4:
        dia = "Miercoles";
        break;
    case 5:
        dia = "Jueves";
        break;
    case 6:
        dia = "Viernes";
        break;
     case 7:
        dia = "Sabado";
        break;
    default:
        Console.WriteLine("El número ingresado no es válido.");
        return;
}
Console.WriteLine($"El día que le corresponde al número es: {dia}");
Console.ReadKey();
Console.Clear();


//3.CALCULAR EL IMPORTE A PAGAR POR UN SERVICIO
int opcion2;
double pagolavado = 0;
double pagoaceite = 0;
double pagorevision = 0;
do
{
    Console.WriteLine("\t.:Calcular el importe a pagar por un servicio:.");
    Console.WriteLine("¿Que servicio desea?");
    Console.Write("\n1. Lavado de auto ");
    Console.Write("\n2. Cambio de aceite ");
    Console.Write("\n3. Revisión Mecánica");
    Console.Write("\n4  Mostrar importe a pagar ");
    Console.Write("\n5. Cancelar servicio ");
    Console.Write("\n6. Salir");
    Console.Write("\nElija la opción: ");
    opcion2 = int.Parse(Console.ReadLine());


    switch (opcion2)
    {
        case 1:
            Console.WriteLine("\t.:Lavado de auto:.");
            Console.Write("\nEl importe de tal servicio es de Q.495.00 ");
            Console.Write("\nDesea agregar el servicio (S/N): ");
            string continuar = Console.ReadLine().ToUpper();
            if (continuar != "N")
            {
                Console.WriteLine("\nImporte Agregado");
                pagolavado = 495.00;
            }
            break;
        case 2:
            Console.WriteLine("\t.:Cambio de aceite:.");
            Console.Write("\nEl importe de tal servicio es de Q.199.00 ");
            Console.WriteLine("\nDesea agregar el servicio (S/N): ");
            string continuar2 = Console.ReadLine().ToUpper();
            if (continuar2 != "N")
            {
                Console.WriteLine("\nImporte Agregado");
                pagoaceite = 199.00;
            }
            break;
        case 3:
            Console.WriteLine("\t.:Revisión Mecánica:.");
            Console.Write("\nEl importe de tal servicio es de Q.399.00 ");
            Console.WriteLine("\nDesea agregar el servicio (S/N): ");
            string continuar3 = Console.ReadLine().ToUpper();
            if (continuar3 != "N")
            {
                Console.WriteLine("\nImporte Agregado");
                pagorevision = 399.00;
            }
            break;
        case 4:
            Console.WriteLine("\nCalculando importe...");
            double importePagar = pagolavado + pagoaceite + pagorevision;
            Console.WriteLine($"El importe a pagar es: Q{importePagar:F2}");
            break;
        case 5:
            Console.WriteLine("¿Que servicio desea cancelar?");
            Console.Write("\n1. Lavado de auto ");
            Console.Write("\n2. Cambio de aceite ");
            Console.Write("\n3. Revisión Mecánica");
            Console.WriteLine("\nIngrese la opción: ");
            int opcioncancelar = int.Parse(Console.ReadLine());

            switch (opcioncancelar)
            {
                case 1:
                    if(pagolavado > 0)
                    {
                        Console.WriteLine("\nServicio Cancelado");
                        pagolavado -= 495.00;
                    }
                    else
                    {
                        Console.WriteLine("\nTal servicio no lo ha aceptado ");
                    }
                    break;
                case 2:
                    if (pagoaceite > 0)
                    {
                        Console.WriteLine("\nServicio Cancelado");
                        pagoaceite -= 199.00;
                    }
                    else
                    {
                        Console.WriteLine("\nTal servicio no lo ha aceptado ");
                    }
                    break;
                case 3:
                    if (pagorevision > 0)
                    {
                        Console.WriteLine("\nServicio Cancelado");
                        pagorevision -= 399.00;
                    }
                    else
                    {
                        Console.WriteLine("\nTal servicio no lo ha aceptado ");
                    }
                    break;
            }
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (opcion2 != 6);
Console.Clear();


//4.MOSTRAR UN MENSAJE DE BIENVENIDA EN DIFERENTES IDIOMAS
int opcion3;
do
{
    Console.WriteLine("\t.:Seleccionar Idioma:.");
    Console.WriteLine("\n¿Que idioma desea seleccionar?");
    Console.Write("\n1. Español");
    Console.Write("\n2. Inglés ");
    Console.Write("\n3. Francés");
    Console.Write("\n4. Salir ");
    Console.Write("\nElija la opción: ");
    opcion3 = int.Parse(Console.ReadLine());

    switch (opcion3)
    {
        case 1:
            Console.WriteLine("\t.:Bienvenid@:.");
            Console.Write("\n¡Que alegria saber que esta aqui! ");
            Console.ReadKey();
            Console.WriteLine("\nDesea volver a seleccionar el idioma (S/N): ");
            string continuar = Console.ReadLine().ToUpper();
            if (continuar != "N")
            {
                Console.WriteLine("Volviendo al menú");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nCambiaria el idioma del menu pero no se como ");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            break;
        case 2:
            Console.WriteLine("\t.:Welcome:.");
            Console.Write("\n¡What a joy to know that you are here! ");
            Console.ReadKey();
            Console.WriteLine("\nYou want to reselect the language (S/N): ");
            string continuar2 = Console.ReadLine().ToUpper();
            if (continuar2 != "N")
            {
                Console.WriteLine("Returning to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nI would change the language of the menu but I don't know how ");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            break;
        case 3:
            Console.WriteLine("\t.:Accueillir:.");
            Console.Write("\n¡Quelle joie de savoir que tu es là! ");
            Console.ReadKey();
            Console.WriteLine("\nVous souhaitez resélectionner la langue (S/N): ");
            string continuar3 = Console.ReadLine().ToUpper();
            if (continuar3 != "N")
            {
                Console.WriteLine("Retour au menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nJe changerais la langue du menu mais je ne sais pas comment ");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            break;
    }
} while (opcion3 != 4);
Console.Clear();


//5.Evaluar la califación de un examen
string continuarnota;
do {
    Console.WriteLine("\t.:Evaluar al usuario por su califación");
    Console.Write("Ingrese su nota (60 - 100): ");
    float nota = float.Parse(Console.ReadLine());

    string calificacion = "";

    switch (nota)
    {
        case >= 90 and <= 100:
            calificacion = "¡SOBRESALIENTE!";
            break;
        case >= 80 and <= 89:
            calificacion = "¡Notable!";
            break;
        case >= 70 and <= 79:
            calificacion = "¡Aprobatoria!";
            break;
        case >= 60 and <= 69:
            calificacion = "¡NO APROBATORIA!";
            break;
        default:
            Console.WriteLine("¡La calificación no es válida!");
            break;
    }
    Console.WriteLine(calificacion);
    Console.ReadKey();
    Console.Clear();

    // Preguntar al usuario si desea agregar otra nota
    Console.WriteLine("\n¿Desea agregar otra nota? (S/N): ");
    continuarnota = Console.ReadLine().ToUpper();

    if (continuarnota != "S" && continuarnota != "N")
    {
        Console.WriteLine("¡Respuesta no válida!");
        continue;//se utiliza para omitir el resto del cuerpo del bucle do-while y continuar con la siguiente iteración.
    }
} while (continuarnota != "N");
Console.ReadKey();