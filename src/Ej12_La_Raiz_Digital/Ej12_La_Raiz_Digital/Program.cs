/*La raíz digital
Lea un número entero positivo. Sume sus dígitos; si el resultado tiene más de una cifra,
vuelva a sumar sus dígitos… repita hasta quedar con un solo dígito. 
Ejemplo: 4725 → 4+7+2+5 = 18 → 1+8 = 9. Adentro va un Mientras; afuera, un Repetir.*/
int numero,sumaDigitos=0;
Console.WriteLine("Manito, escribe un numero");
numero = Convert.ToInt32(Console.ReadLine());

do
{
    sumaDigitos = 0;
    while (numero!=0)
    {
        sumaDigitos=sumaDigitos+numero%10;
        numero = numero / 10;

       // Console.WriteLine(numero);
        //Console.WriteLine(sumaDigitos);

    }
    numero = sumaDigitos;
}
while (sumaDigitos>9);
Console.WriteLine($"La suma de los digitos del numero es {sumaDigitos}");