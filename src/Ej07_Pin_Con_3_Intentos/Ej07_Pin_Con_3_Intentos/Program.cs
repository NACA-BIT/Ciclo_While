/*while(true) · PIN con 3 intentos
El PIN correcto es 1234. Dentro de un Mientras VERDADERO, lea intentos y avise "PIN incorrecto, le quedan X". 
Hay dos puertas de salida con Break: acierto → "Acceso concedido"; tres fallos → "Cuenta bloqueada".*/
int contrasena,intentos=4; 
Console.WriteLine("Porfavor ingrese su PIN");

while (true)
{
    contrasena=Convert.ToInt32(Console.ReadLine());
    if (contrasena!=1234)
    {
        intentos--;

        if (intentos != 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"   PIN incorrecto   \n    Le quedan {intentos}     \nIntentelo nuevamente");
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor= ConsoleColor.Red;
            Console.WriteLine("  Ha alcanzado el limite de intentos permitidos  \nSu cuenta sera bloqueada por medida preventiva...");
            Console.ResetColor();
            break;
        }
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Acceso concedido");
        Console.ResetColor();
        break;
    }

}
//Console.WriteLine("ME FUI D:");
