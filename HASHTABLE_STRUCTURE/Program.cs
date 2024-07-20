using System.Collections;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace HASHTABLE_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //HASHTABLE 
            //DECSRIBING 
            // HASHTABLE STATEMENT  is located in the system.Collections class.
            var sehırler =new Hashtable();

            // ADD
            sehırler.Add(50, "nevşehir");
            sehırler.Add(34, "istanbul");
            sehırler.Add(6, "ankara");
            sehırler.Add(35, "izmir");
            sehırler.Add(01, "adana");

            //ROAM OR WANDER AROUND
            foreach (DictionaryEntry item in sehırler)
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"{item.Value,-10}");
            }


            //GETTING THE KEYS
            Console.WriteLine("\nANAHTARLAR - (KEYS)");
            var anahtarlar= sehırler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            //GETTING THE VALUE
            Console.WriteLine("\nDEĞERLER - (VALUES)");
            ICollection DEĞERLER=sehırler.Values;
            foreach (var item in DEĞERLER)
            {
                Console.WriteLine(item);
            }

            //ACCESS ELEMENT
            //ZERO-BADE İNDEXİNG 
            Console.WriteLine("\nELEMANA ERİŞME");
            Console.WriteLine(sehırler[34]);

            // DELETE ELEMENT
            Console.WriteLine("\nELEMANI SİLME");
            sehırler.Remove(34);

            //AGAİN ROAM OR WANDER AROUND
            foreach (DictionaryEntry item in sehırler)
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"{item.Value,-10}");
            }


            //HASHTABLE APPLICATION

            Console.WriteLine("\nlütfen bir başlık giriniz: ");
            string baslık=Console.ReadLine();

            //REDUCTİON

            baslık = baslık.ToLower();


            //HASHTABLE USE

            var KarakterSeti=new Hashtable()
            {
                {'ç','c'},
                {'ö','o'},
                {'ı','i'},
                {'ü','u'},
                {'\'','-'},
                {' ','-'},

            };

            foreach (DictionaryEntry item in KarakterSeti)
            {
                baslık = baslık.Replace((char)item.Key, (char)item.Value);
            }

            //SCREEN WRİTİNG 
            Console.WriteLine(baslık);






            Console.ReadLine();
        }
    }
}
