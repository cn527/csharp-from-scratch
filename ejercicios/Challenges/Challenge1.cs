namespace itm.csharp.basic
{
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positivo");
            else if (num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Es cero");
        }
    }

    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma: {num1 + num2}\nResta: {num1 - num2}\nMultiplicación: {num1 * num2}\nDivisión: {num1 / num2}");
        }
    }
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"El cuadrado de {numero} es: {numero * numero}");
        }
    }

    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.PI * radio * radio;
            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
        }
    }

    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;

                default: Console.WriteLine("Número no válido"); break;
            }
        }
    }

    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario mensual:");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 1000 ? 0.1 * salario : 0;
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
        }
    }


    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Número a dividir:");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor:");
                double divisor = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {n / divisor}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar la operación!");
            }
        }
    }


    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de números impares entre 1 y 100 es: {suma}");
        }
    }


    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese numerador de la primera fracción:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la primera fracción:");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numerador de la segunda fracción:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la segunda fracción:");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion suma = fraccion1.Sumar(fraccion2);
                Fraccion resta = fraccion1.Restar(fraccion2);
                Fraccion mult = fraccion1.Multiplicar(fraccion2);
                Fraccion div = fraccion1.Dividir(fraccion2);

                Console.WriteLine($"La suma de {fraccion1} y {fraccion2} es: {suma}");
                Console.WriteLine($"La resta de {fraccion1} y {fraccion2} es: {resta}");
                Console.WriteLine($"La multiplicación de {fraccion1} y {fraccion2} es: {mult}");
                Console.WriteLine($"La división de {fraccion1} y {fraccion2} es: {div}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }



    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador + otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public Fraccion Restar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public Fraccion Multiplicar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Numerador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public Fraccion Dividir(Fraccion otra)
        {
            if (otra.Numerador == 0)
                throw new DivideByZeroException("No se puede dividir entre una fracción con numerador 0.");

            int nuevoNumerador = Numerador * otra.Denominador;
            int nuevoDenominador = Denominador * otra.Numerador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }


    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            string invertida = new string(palabra.Reverse().ToArray());
            Console.WriteLine($"La palabra invertida es: {invertida}");
        }
    }


    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Introduce el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine($"El promedio de los tres números es: {promedio}");
        }
    }


    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce el número {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"El número más grande de la lista es: {numeros.Max()}");
        }
    }


    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();

            if (palabra == new string(palabra.Reverse().ToArray()))
            {
                Console.WriteLine($"La palabra {palabra} es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"La palabra {palabra} no es un palíndromo.");
            }
        }
    }


    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }

    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                Console.WriteLine($"El número {numero} está en el rango de 0 a 10.");
            }
            else
            {
                Console.WriteLine($"El número {numero} está fuera del rango de 0 a 10.");
            }
        }
    }




}
