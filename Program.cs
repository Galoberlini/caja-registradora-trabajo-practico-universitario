Console.WriteLine("==== KIOSCO ====");
Console.Write("Nombre del cajero: ");

string name =  Console.ReadLine();

Console.WriteLine($"Bienvenido {name}, Caja abierta");

int productQty = 0;
decimal productSum = 0;
int numOption;

do
{

    Console.WriteLine("Qué desea hacer?" +
        "1 - Carga un producto" +
        "2 - Cerrar la ventana ");

    numOption = int.Parse(Console.ReadLine());

    if (numOption == 1)
    {
        Console.WriteLine("Agregue un Producto");
        Console.Write("Nombre del producto: ");

        string productName = Console.ReadLine();
        
        Console.Write("Precio del producto: ");
        
        decimal productPrice = decimal.Parse(Console.ReadLine());
        productSum += productPrice;
        productQty++;

        Console.WriteLine($"=== Producto creado exitosamente ===");
        Console.WriteLine($"Producto: {productName} , Precio: {productPrice} ");
    }

    else if (numOption != 2)
    {
        Console.WriteLine("Input invalido, intente nuevamente");
    }

}

while (numOption != 2);
    Console.WriteLine($"Cantidad total de productos: {productQty}");
    Console.WriteLine($"Suma total de los precios: {productSum}");
