Console.WriteLine("==== KIOSCO ====");
Console.Write("Nombre del cajero: ");

string name =  Console.ReadLine();

Console.WriteLine($"Bienvenido {name}, Caja abierta");

int productQty = 0;
decimal productSum = 0;
int numOption;

decimal maxDiscount = 0.10m;
decimal minDiscount = 0.05m;

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


 if (productSum <= 20000) 
        {
            Console.WriteLine($"Suma total de los precios: {productSum}");
        }
    else if ( productSum < 50000) 
        {
        decimal discount = productSum * minDiscount;
        Console.WriteLine($"Subtotal de los precios: {productSum}");
        Console.WriteLine($"Descuento aplicado: {discount} (5%)");
        Console.WriteLine($"Total de los precios: {productSum - discount}");
    }
    else if (productSum >= 50000)
    {
        decimal discount = productSum * maxDiscount;
        Console.WriteLine($"Subtotal de los precios: {productSum}");
        Console.WriteLine($"Descuento aplicado: {discount} (10%)");
        Console.WriteLine($"Total de los precios: {productSum - discount}");
    }