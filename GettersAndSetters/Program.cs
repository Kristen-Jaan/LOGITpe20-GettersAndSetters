using System;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            string gender;
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idCode;

            }
            public string Name
            {
                get { return name; }
            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value == "Male" || value == "Female")
                    {
                        gender = value;
                    }else
                    {
                        gender = "Underfined thing";

                    }
                }
            }

            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }else
                    {
                        idCode = "underfined (yours truly Mr. Krabs)";
                    }
                }
            }

            public void ChangeName(string newName)
            {
                name = newName;
            }
            public void ChnageIdCode(string newCode)
            {
                IdCode = newCode;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Help Me!");
            Person newPerson = new Person("Spongebob", "Male", 21, "4536271");
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);

            newPerson.ChangeName("Doodlebob");
            newPerson.ChnageIdCode("2264");
           Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.IdCode);
            //Console.WriteLine(newPerson.age);
            //newPerson.Name = "Crash Bandicoot";
            //newPerson.gender = "Bandicoot";
            //newPerson.age = 24;
            
            //Console.WriteLine(newPerson.age);
            //Console.WriteLine(newPerson.Gender);
        }
    }
}
