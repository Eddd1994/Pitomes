using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Pitomes
{
    public class Pitomes
    {

        public static string Viem  { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public double Weight { get; set; }

        public void Bark()
        {
            Console.WriteLine("Гав-гав");
        }
        public void Bark1()
        {
            Console.WriteLine("Мощный Гааааааав!!!");
        }
        public void Bark2()
        {
            Console.WriteLine("Мяу-мяу!!!");
        }

        public void pit()
        {
            var pit = new Pitomes();
            Pitomes.Viem = "Собака";
            pit.Age = 2;
            pit.Name = "ЖУЧКА";
            pit.Weight = 5.4;
            pit.Breed = "ДВОРНЯГА";
            pit.Bark();
            Console.WriteLine("Возраст" + pit.Age + " ," + pit.Name + " ," +Viem + " ,вес " + pit.Weight + " ," + pit.Breed);
        }
        public static void pit1()
        {
            var pit1 = new Pitomes();
            Pitomes.Viem = "Собака";
            pit1.Age = 10;
            pit1.Name = "ЗЕВС";
            pit1.Weight = 15.9;
            pit1.Breed = "ДОБЕРМАН";
            pit1.Bark1();
            Console.WriteLine("Возраст" + pit1.Age + " ," + pit1.Name + " ," + Viem + " ,вес " + pit1.Weight + " ," + pit1.Breed); ;
       
        }
        public void pit2()
        {
            var pit2 = new Pitomes();
            Pitomes.Viem = "Кошка";
            pit2.Age = 1;
            pit2.Name = "Ася";
            pit2.Weight = 0.9;
            pit2.Breed = "Перс";
            pit2.Bark2();
            Console.WriteLine("Возраст" + pit2.Age + " ," + pit2.Name + " ," + Viem + " ,вес " + pit2.Weight + " ," + pit2.Breed); ;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите кого вы хотите взять из приюта,кошка или собака?");
            string cat0 = Console.ReadLine();
            string cat = "кошка";
            if (cat == cat0)
            {
                var pit = new Pitomes();
                pit.pit2();
            }
           
            else
            {
                Console.WriteLine("Выберите собаку!");
               
                var pim = new Pitomes();
                pim.pit();

                Pitomes.pit1();
            }
            
            

            

        }

    }

}