
using AulaModificadoresRef_Out;

int a = 10; // valor =  10 
Calculator.Triple(ref a);
Console.WriteLine(a); // valor = 30

int b = 10;
int triple;
Calculator.Triple(b, out triple);

Console.WriteLine(triple); // 30
