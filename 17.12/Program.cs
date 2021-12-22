using System;
using System.Collections;

namespace KullanicidanVeriAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Değişken Tanımlaması:
            int veri;
            string ayrac = new string('-', 25);
            ArrayList list = new ArrayList();

            // Oluşturmuş Olduğumuz ArrayList Atamlarını Yapıyoruz:
            for (int v = 0; v < 16; v++)
            {
                if (v == 0 || v == 4 || v == 8 || v == 12)
                {
                    veri = random.Next(65, 90) + 1;
                    if (list.Contains(veri) == true || list.Contains(Convert.ToChar(veri)) == true)
                    {
                        veri = random.Next(75, 85);
                        list.Add(Convert.ToChar(veri));
                    }
                    else
                        list.Add(Convert.ToChar(veri));
                }
                else
                {
                    veri = random.Next(15);
                    if (veri > 9)
                    {
                        veri = random.Next(65, 90) + 1;
                        if (list.Contains(veri) == true || list.Contains(Convert.ToChar(veri)) == true)
                        {
                            veri = random.Next(71, 87);
                            list.Add(Convert.ToChar(veri));
                        }
                        else
                            list.Add(Convert.ToChar(veri));
                    }
                    else
                    {
                        if (list.Contains(veri) == true || list.Contains(Convert.ToChar(veri)) == true)
                        {
                            veri = random.Next(3, 10) - 1;
                            list.Add(veri);
                        }
                        else
                            list.Add(veri);
                    }
                }
            }
            Console.Write("{0}\n< Random Lisans Anahtarı >\n{1}\n-> Oluşturulan Anahtar: ", ayrac, ayrac);
            // Oluşturmuş Olduğumuz Lisans Anahtarını Ekrana Yazdırıyoruz:
            int r = 0;
            foreach (var n in list)
            {
                Console.Write(n);
                if (r == 3 || r == 7 || r == 11)
                {
                    Console.Write(" - ");
                }
                r++;
            }
            Console.WriteLine("\n" + ayrac);
        }
    }
}
    
