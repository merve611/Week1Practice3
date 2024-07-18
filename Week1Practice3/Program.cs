// See https://aka.ms/new-console-template for more information





Console.WriteLine(" Rüya Manavına Hoşgeldiniz !");
Console.WriteLine(" Elma = 2 TL \n Armut = 3 TL \n Çilek = 2 TL \n Muz = 3 TL \n Diğer bütün meyveler = 4 TL");     //defalarca cw yazmamak için \n kullanarak stringleri alt satıra geçirdim

Console.Write(" Hangi meyveyi satın almak istersiniz ? (Elma/Armut/Çilek/Muz/Diğer) : ");


string meyve = Console.ReadLine();
meyve = meyve.ToUpper();

if (meyve != null)
{
    if (meyve == "ELMA")
    {
        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 2 TL");
    }
    else if (meyve == "ARMUT")
    {
        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 3 TL");
    }
    else if (meyve == "ÇİLEK")
    {
        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 2 TL");
    }
    else if (meyve == "MUZ")
    {
        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 3 TL");
    }
    else
    {
        Console.WriteLine("4 TL");
    }
}     //Bu uygulama için bana göre en mantıklı yöntem switch - case dir. Çünkü birçok olası değer var
      //switch (meyve.ToUpper())                                //ToUpper kullanarak girdi de küçükte yazsak duyarsız hale geliyor
      //{
      //    case "ELMA":
      //        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 2 TL");
      //        break;

//    case "ARMUT":
//        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 3 TL");
//        break;

//    case "ÇİLEK":
//        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 2 TL");
//        break;

//    case "MUZ":
//        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 3 TL");
//        break;

//    default:
//        Console.WriteLine(" Seçtiğiniz meyvenin fiyatı : 4 TL");
//        break;
//}










