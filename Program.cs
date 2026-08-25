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

decimal totalDiscount = productSum;
decimal discount = 0.0m;
decimal totalCharge = 0.0m;

 if (productSum <= 20000) 
        {
            Console.WriteLine($"Suma total de los precios: {productSum}");
        }
    else if ( productSum < 50000) 
        {
        discount = productSum * minDiscount;
        totalDiscount = productSum - discount;

        Console.WriteLine($"Subtotal de los precios: {productSum}");
        Console.WriteLine($"Descuento aplicado: {discount} (5%)");
        Console.WriteLine($"Total de los precios: {productSum - discount}");
    }
    else if (productSum >= 50000)
    {
        discount = productSum * maxDiscount;
        totalDiscount = productSum - discount;

        Console.WriteLine($"Subtotal de los precios: {productSum}");
        Console.WriteLine($"Descuento aplicado: {discount} (10%)");
        Console.WriteLine($"Total de los precios: {productSum - discount}");
    }

int opt;

do
{

Console.WriteLine("Medio de pago: ");
Console.WriteLine("1 - Efectivo ");
Console.WriteLine("2 - Débito ");
Console.WriteLine("3 - Crédito ");
Console.Write("Marque el número del método que prefiera: ");

opt = int.Parse(Console.ReadLine());

switch (opt)
{
    case 1:
        decimal dsc = totalDiscount * maxDiscount;
        discount += dsc;

        Console.WriteLine("Tiene un 10% de descuento adicional!");
        Console.WriteLine($"Su total a pagar ahora es de: {totalDiscount - discount}");
        break;

    case 2:
        Console.WriteLine($"El total a pagar es de: {totalDiscount}");
        break;

    case 3:
        decimal maxCharge = 0.15m;
        decimal extCharge = totalDiscount * maxCharge;
        totalCharge += extCharge;

        Console.WriteLine("Tiene un 15% de RECARGO");
        Console.WriteLine($"Su total a pagar ahora es de: {totalDiscount + extCharge} ");
        break;

    default:
        Console.WriteLine("Input desconocido, marque nuevamente");
        break;

}} while (opt > 3 || opt < 1);

Console.WriteLine();
Console.WriteLine();

decimal total = productSum - discount + totalCharge;

    for (int i = 0; i < 30; i++) Console.Write('-');
    Console.WriteLine();
    Console.WriteLine("KIOSCO");
    for (int i = 0; i < 30; i++) Console.Write('-');
    Console.WriteLine();
    Console.WriteLine($"Cajero: {name}");
    Console.WriteLine($"Productos: {productQty}");
    Console.WriteLine($"Subtotal: {productSum}");
    Console.WriteLine($"Descuento: {discount}");
    Console.WriteLine($"Recargo: {totalCharge}");
    for (int i = 0; i < 30; i++) Console.Write('-');
    Console.WriteLine();
    Console.WriteLine($"Total: {total}");
    for (int i = 0; i < 30; i++) Console.Write('-');

Console.WriteLine();

    