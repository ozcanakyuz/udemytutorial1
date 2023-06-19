using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace udemytutorial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Sayı-1: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("Sayı-2: ");
            //int sayi2 = int.Parse(Console.ReadLine());






            //string _email = "customer@gmail.com";
            //string _pass = "0123456";

            //Console.Write("E-mail: ");
            //string email = Console.ReadLine();

            //Console.Write("Password: ");
            //string pass = Console.ReadLine();


            //if (_email == email && _pass == pass)
            //{
            //    Console.WriteLine("Başarılı.");

            //}
            //else
            //{
            //    Console.WriteLine("E-mail veya Parola Hatalı!");
            //}

            //var result = (_email == email && _pass == pass);

            //Console.WriteLine(result);
            //Console.Write("Sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) {

            //    Console.WriteLine("Vermiş olduğunuz sayı çift pozitif sayıdır.");

            //}
            //else { 

            //    Console.WriteLine("Çift pozitif sayı değildir !!!!"); 

            //}

            //Console.Write("1.Sayı: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayı: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("3.Sayı: ");
            //int c = int.Parse(Console.ReadLine());

            //if (a > b && a > c)
            //{
            //    Console.WriteLine("En büyük sayı: " + a);
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine("En büyük sayı: " + b);
            //}

            //else if (c > a && c > b)
            //{
            //    Console.WriteLine("En büyük sayı: " + c);
            //}

            //Console.Write("Vize1 Notunuz: ");
            //int vize1 = int.Parse(Console.ReadLine());

            //Console.Write("Vize2 Notunuz: ");
            //int vize2 = int.Parse(Console.ReadLine());

            //Console.Write("Final Notunuz: ");
            //int final = int.Parse(Console.ReadLine());

            //var result = ((((vize1 + vize2)/2) * 0.4) + (final * 0.6));

            //if (result >= 50) 
            //{
            //    Console.WriteLine("Başarılı: " + result);
            //}
            //else 
            //{
            //    Console.WriteLine(result + " İLE KALDINIZ.");
            //}

            //Console.WriteLine("Boyunuz:");
            //float boy = float.Parse(Console.ReadLine());

            //Console.WriteLine("Kilonuz:");
            //float kilo = float.Parse(Console.ReadLine());

            //float result = kilo / (boy * boy);

            //Console.WriteLine(result);



            //int day = 4;

            //switch (day)
            //{
            //    case 1 :
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2 :
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3 :
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4 :
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5 :
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6 :
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7 :
            //        Console.WriteLine("Sunday");
            //        break;
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i++);
            //}


            //for (int i = 50 ; i < 61; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] sayilar = {1, 3, 5, 6, 7, 23, 67, 90};

            //for (int i = 0; i <= sayilar.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //string name = "OZCANAKYUZ";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == 'A')
            //        continue;
            //    Console.WriteLine(name[i]);
            //}

            //var random = new Random();
            //Console.WriteLine(random.Next(1, 100));


            do
            {
                int tutulan = (new Random()).Next(1,5);
                int hak = 5;
                int tur = 0;
                int sayi;

                double sorupuani = 100 / hak;

                while (hak > 0)
                {
                    tur++;
                    Console.Write($"{tur}.Tahmininiz: ");
                    sayi = int.Parse(Console.ReadLine());

                    if (sayi == tutulan)
                    {
                        double point = 120 - (sorupuani * tur);
                        Console.WriteLine($"Tebrikler {tur}. tahmininizde bildiniz.");
                        Console.WriteLine($"Toplam Puanınız: {point}");
                        break;
                    }
                    else 
                    {
                        if (hak == 0)
                            break;
                        if (tutulan > sayi)
                            Console.WriteLine("Yukarı");
                        else
                            Console.WriteLine("Aşağı");
                    }
                    hak--;
                }

                Console.WriteLine("Oyun Bitti");
                Console.Write("Devam etmek istiyor musunuz? (y/n)");
                string result = Console.ReadLine();

                if (result == "n" || result == "no")
                    break;
            } while (true);

        }
    }
}
