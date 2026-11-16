/*¿Convertir otra vez? (S/N)
Convierta una temperatura de °C a °F y al final pregunte: "¿Convertir otra? (S/N)".
Repita todo el proceso mientras respondan S. El ciclo envuelve la operación completa.*/
double temperatura;
string confirmacion;
do
{
    Console.WriteLine("Ingresa la temperatura en C° que quieras convertir a F°");
    temperatura=Convert.ToDouble(Console.ReadLine());
    if (temperatura>25)
    {
        temperatura = (temperatura * 1.8) + 32;
        Console.WriteLine($"Tu temperatura actual en F° es de {temperatura}°\nEsta haciendo calorcito");
    }
    else
    {
        temperatura = (temperatura * 1.8) + 32;
        Console.WriteLine($"Tu temperatura actual en F° es de {temperatura}°\nEsta haciendo friito");

    }
    Console.WriteLine("¿Convertir otra vez ? (S / N)");
    confirmacion = Console.ReadLine().ToUpper();
}
while (confirmacion=="S");