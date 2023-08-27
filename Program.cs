// See https://aka.ms/new-console-template for more information
//pedir la cantidad en soles consumida


Console.WriteLine("Ingrese todo su consumo respectivo");
double consumo = double.Parse(Console.ReadLine());
double dscto, total;
if (consumo <= 100)
{
    dscto = consumo * 0.10;
    double igv = 0.18 * dscto;
    total = dscto + igv;
    Console.WriteLine("Total a pagar:" + total + "soles");
}
else if (consumo >= 100)
{

    dscto = consumo * 0.20;
    double igv = 0.18 * dscto;
    total = dscto + igv;
    Console.WriteLine("Total a pagar:" + total + "soles");

}