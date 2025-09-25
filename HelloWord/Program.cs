namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            /*Data Type*/
            // int myMum = 5;
            // double myDoubleNum = 5.990;
            // char myLetter = 'D';
            // bool myBool = true;
            // string myTest = "hello";
            // var Name = "Jhon Smith";
            // int? mynewvar=null; // declara una variable nula

            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;
            Console.WriteLine("¡Hola Bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/aaaa: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput,out dateConverted);
            if(isDateValid==false)
            Console.WriteLine($"La fecha de nacimiento es inválida, usted nos envió este dato erróneo {birthdayInput}");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre es {person.Name}");
            Console.WriteLine($"Tu fecha de naciemiento es {person.Birthday}");
            Console.WriteLine($"Tu edad es {person.Age}");

            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }

    }
}