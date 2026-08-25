Console.WriteLine("==== KIOSCO ====");
Console.Write("Nombre del cajero: ");

string name =  Console.ReadLine();

Console.WriteLine($"Bienvenido {name}, Caja abierta");

Console.WriteLine("Agregue un Producto");
Console.Write("Nombre del producto: ");

string productName = Console.ReadLine();

Console.Write("Precio del producto: ");

decimal productPrice = decimal.Parse(Console.ReadLine());

Console.WriteLine($"=== Producto creado exitosamente ===");
Console.WriteLine($"Producto: {productName}, Precio: {productPrice} ");