/*Menú de cafetería con salida
Muestre el menú: 1 empanada $2.500, 2 café $1.800, 3 arepa $3.000, 0 pagar y salir.
Repita el menú hasta que elijan 0, acumulando el total de cada pedido. El patrón definitivo de los menús.*/
int menu;
double precio, total=0;
do
{
    Console.WriteLine("\n\nBienvenido a la cafeteria :D\nEl menu de hoy es\n1 empanada $2.500\n2 café $1.800\n3 arepa $3.000\nO presione 0 para salir\n\n\n");
    menu=Convert.ToInt32(Console.ReadLine());
    if (menu>3)
    {
        Console.WriteLine("Opcion invalida");
    }
    if (menu==1)
    {
        precio = 2500;
        total = total + precio;
    }
    if (menu==2)
    {
        precio = 1800;
        total = total + precio;

    }
    if (menu==3)
    {
        precio = 3000;
        total = total + precio;

    }

}
while (menu!=0);
Console.WriteLine($"Su total seria de: {total.ToString("C0")}");