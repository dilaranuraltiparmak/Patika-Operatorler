// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//atama
int x = 2;
int y = 3;
y = y + 2;
Console.WriteLine(y);
y += 2;
y /= 1;
Console.WriteLine(y);
x *= 3;
Console.WriteLine(x);
//mantıksal operatörler
//|| && !
bool isSucces = true;
bool isCompleted = false;
if (isSucces && isCompleted)
{
    Console.WriteLine("Perfect");
}
if (isSucces||isCompleted)
{
    Console.WriteLine("Great");
}
if (isSucces &&  !isCompleted)
{
    Console.WriteLine("Fine");
}
//ilişkisel operatörler
//<,>,<=,>=,==,=!
int a = 3;
int b = 4;
bool sonuc= a < b;
Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc);
sonuc = a == b;
Console.WriteLine(sonuc);
sonuc= a != b;
Console.WriteLine(sonuc);
sonuc = a <= b;
Console.WriteLine(sonuc);
sonuc=a>= b;
Console.WriteLine(sonuc);
//aritmetik operatörler
int sayi1 = 10;
int sayi2 = 5;
int snc1 = sayi1 / sayi2;
Console.WriteLine(snc1);
int snc2 = sayi1 * sayi2;
Console.WriteLine(snc2);
int snc3 = sayi1 - sayi2;
Console.WriteLine(snc3);
int snc4 = sayi1 + sayi2;
Console.WriteLine(snc4);
//%:mod alır:
int snuc2 =20%3;
Console.WriteLine(snuc2);

