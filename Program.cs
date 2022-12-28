// See https://aka.ms/new-console-template for more information
double fahrenayt_derecesi,cantigrad;
Console.WriteLine("Fahrenayt derecesini giriniz : ");
fahrenayt_derecesi = Convert.ToDouble(Console.ReadLine());
cantigrad = (((fahrenayt_derecesi-32)*5)/9);
Console.WriteLine("Cantigrad derecesi : " + cantigrad);