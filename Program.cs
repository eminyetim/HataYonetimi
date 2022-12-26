using System;

namespace hataYonetimi
{
    class program
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("bir sayi giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayi :" + sayi);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("ERROR :"+ex.Message.ToString());                
            }
            // finally
            // {
            //     Console.WriteLine("İşlem Başarılı");
            // }
            
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test"); //Harfi sayiya dönderiyor.
                int a = int.Parse("-1122222222222222");

            }
            catch (System.ArgumentNullException ex)
            {   
                Console.WriteLine("Boş deger girdiniz ");
                Console.WriteLine(ex);                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uyun degil");
                Console.WriteLine(ex);       
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }
            
        }
    }
}