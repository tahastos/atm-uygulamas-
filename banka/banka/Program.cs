namespace banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int şifre = 6161;
            int bakiye = 100;
            int nakit = 1000;
            Console.WriteLine("Bankaya Hoşgeldiniz");

            Console.WriteLine(" ");




            Console.WriteLine("Hoşgeldiniz, Taha Çalık");
            Console.WriteLine("Şifreyi giriniz: ");

            while (true)
            {

                int inputSifre = Convert.ToInt32(Console.ReadLine());
                if (inputSifre != şifre)
                {
                    Console.WriteLine("hatalı şifre. tekrar giriniz");
                    continue;

                }
                else
                {
                    Console.WriteLine("Giriş başarılı");
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Menü");
                Console.WriteLine(" ");
                Console.WriteLine("1- Bakiye görüntüle");
                Console.WriteLine("2- nakit parayı göster");
                Console.WriteLine("3- para yatır");
                Console.WriteLine("4- para çek");
                Console.WriteLine("5- Kart iade");
                Console.WriteLine(" ");
                Console.WriteLine("İşlem numarasını giriniz");
                Console.WriteLine(" ");
                int islem = Convert.ToInt32(Console.ReadLine());


                if (islem == 1)
                {
                    Console.WriteLine("Bakiyeniz = " + bakiye + " TL");
                    continue;    
                }
                if (islem == 2)
                {
                    Console.WriteLine("Nakit Paranız = " + nakit + " TL");
                    continue;
                }
                
                if (islem == 3)
                {
                    
                    if (nakit == 0)
                    {

                        Console.WriteLine("Nakit paranız kalmamıştır.");
                        Console.WriteLine("Ana menüye döndürülüyorsunuz...");
                        continue;
                    }
                    Console.WriteLine("Yatırılıcak tutarı giriniz");
                    int yatırılacakTutar = Convert.ToInt32(Console.ReadLine());
                    if (yatırılacakTutar > nakit)
                    {
                        Console.WriteLine("Nakit bakiyeniz yetersiz. Mevcuttaki tüm nakit paranızı yatırmak ister misiniz?");
                        Console.WriteLine("1-Evet");
                        Console.WriteLine("2-Hayır");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("Mevcut tüm nakit bakiyeniz hesabınıza yatırılmıştır");
                            bakiye = bakiye + nakit;
                            nakit = 0;
                            Console.WriteLine(" ");
                            Console.WriteLine("Yeni bakiyeniz = " + (bakiye) + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Ana menüye döndürülüyorsunuz...");
                        }
                    }
                    
                    else 
                    {
                        bakiye = bakiye + yatırılacakTutar;
                        nakit = nakit - yatırılacakTutar;
                        Console.WriteLine(" ");
                        Console.WriteLine("Yeni bakiyeniz= " + (bakiye) + " TL");

                    }
   
                }
                if (islem == 4)
                {
                    Console.WriteLine("Çekilecek tutarı giriniz");
                    while (true)
                    {
                        int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                        if (bakiye == 0)
                        {
                            Console.WriteLine("bakiyeniz yetersiz ana menüye yönlendiriliyosunuz");
                            continue;
                        }
                        else if (cekilecekTutar > bakiye)
                        {
                            Console.WriteLine("Yetersiz Bakiye.Lütfen yeniden deneyin.");
                            continue;
                        }
                        else
                        {
                            bakiye = bakiye - cekilecekTutar;
                            nakit = nakit + cekilecekTutar;
                            Console.WriteLine("Para çekme işlemi başarılı");
                            Console.WriteLine("Yeni bakiyeniz= " + (bakiye));

                            break;
                        }            
                    }
                    continue;
                } 
                else if (islem == 5)
                {
                    Console.WriteLine("Kart iade ediliyor. Teşekkür ederiz");
                    return;
                }
            }
        }
    }
}

    



