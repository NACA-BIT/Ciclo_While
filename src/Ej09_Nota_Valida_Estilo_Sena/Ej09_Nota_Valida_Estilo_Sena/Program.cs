/*Nota válida estilo SENA
Lea la nota definitiva de un aprendiz. Solo se acepta el rango 1.0 a 5.0; 
cualquier otro valor se vuelve a pedir. El patrón de validación que usará toda su vida.*/
double nota;
do
{
    Console.WriteLine("Porfavor digite su nota definitiva");
    nota=Convert.ToDouble(Console.ReadLine());
    if (nota<1.0||nota>5.0)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valor no valido");
        Console.ResetColor();
    }
}
while (nota<1.0||nota>5.0);
if (nota>3.0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Pasaste :D");
    Console.ResetColor ();
}
else
{
    Console.ForegroundColor= ConsoleColor.DarkRed;
    Console.WriteLine("Perdiste :c");
    Console.ResetColor () ;
}