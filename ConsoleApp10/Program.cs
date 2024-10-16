
//While döngüsü
Console.WriteLine("Bir sayı giriniz:");
int limit=int.Parse(Console.ReadLine());
int sayac = 0;

while (sayac<=limit)
{
    Console.WriteLine(sayac +"  Ben bir Patika'lıyım");
    sayac++;
}
Console.WriteLine("teşekkürler");

//Do while döngüsü
Console.WriteLine("Bir sayı giriniz:");
int limit2=int.Parse(Console.ReadLine());
int sayac2=0;
do
{
    Console.WriteLine(sayac2 + "Ben bir patikalıyım");
    sayac2++;
} 
while (sayac2<=limit2);
Console.WriteLine("Teşekkürler");

//ÇIKARILAN SONUÇ
//Do while döngüsü koşul yanlış bile olsa en az bir kez çalışır
//do while döngüsü koşulu en son ister ama while başta ister
