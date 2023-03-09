namespace ejercicio_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool continuar = true;

            while (continuar)
            {
                //Ingreso de opción
                bool opcionCorrecta = false;
                while (!opcionCorrecta)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Supervisado - Iboy Andrea - 1076623");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("MENÚ");
                    Console.WriteLine("1. Meses del año");
                    Console.WriteLine("2. Encontrar el número mayor");
                    Console.WriteLine("3. Signos del zodiaco");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Ingrese una opción del menú: ");


                    try
                    {
                        opcion = int.Parse(Console.ReadLine());

                        if (opcion > 0 && opcion <= 4)
                        {
                            opcionCorrecta = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debe ingresar un número...");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
                // Fin ingreso opción 

                // Ejecución de ejercicio según la opción 
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1. Meses del año");
                        Console.WriteLine("Ingrese el número del mes que desee: ");
                        int numero = int.Parse(Console.ReadLine());
                        if (numero < 1 || numero > 12)
                        {
                            Console.WriteLine("Dato invalido, Ingrese numeros del 1 al 12");
                        }
                        else
                        {
                            switch (numero)
                            {
                                case 1:
                                    Console.WriteLine("Enero");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Febrero");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("Marzo");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("Abril");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine("Mayo");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    Console.WriteLine("Junio");
                                    Console.ReadKey();
                                    break;
                                case 7:
                                    Console.WriteLine("Julio");
                                    Console.ReadKey();
                                    break;
                                case 8:
                                    Console.WriteLine("Agosto");
                                    Console.ReadKey();
                                    break;
                                case 9:
                                    Console.WriteLine("Septiembre");
                                    Console.ReadKey();
                                    break;
                                case 10:
                                    Console.WriteLine("Octubre");
                                    Console.ReadKey();
                                    break;
                                case 11:
                                    Console.WriteLine("Noviembre");
                                    Console.ReadKey();
                                    break;
                                case 12:
                                    Console.WriteLine("Diciembre");
                                    Console.ReadKey();
                                    break;

                            }
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Encontrar el número mayor:");
                        int numero1, numero2, numero3, numero4;
                        Console.WriteLine("Ingresa el número 1");
                        if (!int.TryParse(Console.ReadLine(), out numero1) || numero1 <= 0)
                        {
                            Console.WriteLine("Número invalido, Intentalo de nuevo");
                            return;
                        }
                        Console.WriteLine("Ingresa el número 2");
                        if (!int.TryParse(Console.ReadLine(), out numero2) || numero2 <= 0)
                        {
                            Console.WriteLine("Número invalido, Intentalo de nuevo");
                            return;
                        }
                        Console.WriteLine("Ingresa el número 3");
                        if (!int.TryParse(Console.ReadLine(), out numero3) || numero3 <= 0)
                        {
                            Console.WriteLine("Número invalido, Intentalo de nuevo");
                            return;
                        }
                        Console.WriteLine("Ingresa el número 4");
                        if (!int.TryParse(Console.ReadLine(), out numero4) || numero4 <= 0)
                        {
                            Console.WriteLine("Número invalido, Intentalo de nuevo");
                            return;
                        }
                        int mayor = numero1;
                        if (numero2 > mayor)
                        {
                            mayor = numero2;
                        }
                        if (numero3 > mayor)
                        {
                            mayor = numero3;
                        }
                        if (numero4 > mayor)
                        {
                            mayor = numero4;
                        }
                        Console.WriteLine("El numero mayor es: " + mayor);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Signos del zodiaco");
                        Console.WriteLine("Ingresa el año de nacimiento: ");
                        int año = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa el mes de nacimiento: ");
                        string mes = Console.ReadLine().ToLower();

                        Console.WriteLine("Ingresa el dia de nacimiento: ");
                        int dia = int.Parse(Console.ReadLine());
                        mes = mes.Substring(0, 3);

                        string signozodiaco = "";


                        switch (mes)
                        {
                            case "ene":
                                if (dia <= 20)
                                {
                                    signozodiaco = "Capricornio";
                                }
                                else
                                {
                                    signozodiaco = "Acuario";
                                }
                                break;
                            case "feb":
                                if (dia <= 19)
                                {
                                    signozodiaco = "Acuario";
                                }
                                else
                                {
                                    signozodiaco = "Piscis";
                                }
                                break;
                            case "mar":
                                if (dia <= 20)
                                {
                                    signozodiaco = "Piscis";
                                }
                                else
                                {
                                    signozodiaco = "Aries";
                                }
                                break;
                            case "abr":
                                if (dia <= 20)
                                {
                                    signozodiaco = "Aries";
                                }
                                else
                                {
                                    signozodiaco = "Tauro";
                                }
                                break;
                            case "may":
                                if (dia <= 21)
                                {
                                    signozodiaco = "Tauro";
                                }
                                else
                                {
                                    signozodiaco = "Géminis";
                                }
                                break;
                            case "jun":
                                if (dia <= 21)
                                {
                                    signozodiaco = "Géminis";
                                }
                                else
                                {
                                    signozodiaco = "Cáncer";
                                }
                                break;
                            case "jul":
                                if (dia <= 22)
                                {
                                    signozodiaco = "Cáncer";
                                }
                                else
                                {
                                    signozodiaco = "Leo";
                                }
                                break;
                            case "ago":
                                if (dia <= 23)
                                {
                                    signozodiaco = "Leo";
                                }
                                else
                                {
                                    signozodiaco = "Virgo";
                                }
                                break;
                            case "sep":
                                if (dia <= 23)
                                {
                                    signozodiaco = "Virgo";
                                }
                                else
                                {
                                    signozodiaco = "Libra";
                                }
                                break;
                            case "oct":
                                if (dia <= 23)
                                {
                                    signozodiaco = "Libra";
                                }
                                else
                                {
                                    signozodiaco = "Escorpio";
                                }
                                break;
                            case "nov":
                                if (dia <= 22)
                                {
                                    signozodiaco = "Escorpio";
                                }
                                else
                                {
                                    signozodiaco = "Sagitario";
                                }
                                break;
                            case "dic":
                                if (dia <= 21)
                                {
                                    signozodiaco = "Sagitario";
                                }
                                else
                                {
                                    signozodiaco = "Capricornio";
                                }
                                break;
                        }

                        Console.WriteLine("El signo zodiaco es: " + signozodiaco);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Programa finalizado");
                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Dato invalido");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }while (opcion != 4);



            }
        }
    }
