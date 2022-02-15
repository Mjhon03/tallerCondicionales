using System;

namespace Taller_edwin_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero del ejercicio: ");
            int numeroEjercicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es la cantidad en bodega?");
            int cantBodega = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es la cantidad minima requerida?");
            int cantMinima = int.Parse(Console.ReadLine());
            int cantrestante = cantBodega - cantMinima;
            switch (numeroEjercicio)
            {
                case 1:
                    if (cantBodega > cantMinima)
                    {
                        Console.WriteLine("No es necesario realizar pedido al provedor");

                    }
                    if (cantBodega < cantMinima)
                    {
                        Console.WriteLine("Es necesario realizar un pedido al provedor");
                    }
                    break;

                case 2:
                    if (cantBodega > cantMinima)
                    {
                        Console.WriteLine("No es necesario realizar pedido al provedor");

                    }
                    else
                    {
                        Console.WriteLine("Es necesario realizar un pedido al provedor");
                    }
                    break;

                case 3:

                    if (cantBodega > cantMinima)
                    {
                        Console.WriteLine($"Cantidad en bodega {cantBodega}, cantidad minima requeridad {cantMinima}.\n Enotnces no es necesario realizar el pedido al provedor. Unindades que hacen falta por vender {cantrestante} ");
                    }
                    if (cantrestante < 10)
                    {
                        Console.WriteLine($"Cantidad en bodega {cantBodega}, cantidad minima requeridad {cantMinima}.\n Enotnces no es necesario realizar el pedido al provedor. Unindades que hacen falta por vender {cantrestante}. \n Alerta generada!  ");
                    }
                    if (cantBodega < cantMinima)
                    {
                        Console.WriteLine("Es necesario realizar un pedido al provedor");
                    }
                    break;

                case 4:
                    if (cantBodega > cantMinima)
                    {
                        Console.WriteLine($"Cantidad en bodega {cantBodega}, cantidad minima requeridad {cantMinima}.\n Enotnces no es necesario realizar el pedido al provedor. Unindades que hacen falta por vender {cantrestante} ");
                    }
                    if (cantrestante < 10)
                    {
                        Console.WriteLine($"Cantidad en bodega {cantBodega}, cantidad minima requeridad {cantMinima}.\n Enotnces no es necesario realizar el pedido al provedor. Unindades que hacen falta por vender {cantrestante}. \n Alerta generada!  ");
                    }
                    if (cantBodega < cantMinima)
                    {
                        Console.WriteLine("Es necesario realizar un pedido al provedor ");
                        Console.WriteLine("Cuantos productos desea comprar ?");
                        int cantAcomprar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cual es el valor de compra para cada producto ?");
                        int precio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cual es el valor en caja ?");
                        int valorEnCaja = Convert.ToInt32(Console.ReadLine());
                        int precioAPagar = cantAcomprar * precio;
                        if (valorEnCaja > precioAPagar)
                        {
                            Console.WriteLine($"Cantidad en bodega {cantBodega}, cantidad minima requeridad {cantMinima}.\n Enotnces es necesario realizar el pedido al provedor.  \n cantidades de compra deseada {cantAcomprar}. valor de compra por cada producto {precio} \n Valor en caja {valorEnCaja}. Si es posible realizar el pedido");
                        }
                        else
                        {
                            Console.WriteLine($"Cantidad en bodega {cantBodega}, cantidad minima requeridad {cantMinima}.\n Enotnces es necesario realizar el pedido al provedor.  \n cantidades de compra deseada {cantAcomprar}. valor de compra por cada producto {precio} \n Valor en caja {valorEnCaja}. No es posible realizar el pedido");
                        }
                    }

                    break;

                case 5:
                    Console.WriteLine("Cual es el dia de la semana en numero del 1 al 7? ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cual es total a pagar? ");
                    int preciototal = Convert.ToInt32(Console.ReadLine());
                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.5));
                            break;
                        case 2:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.3));
                            break;
                        case 3:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.10));
                            break;
                        case 4:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.4));
                            break;
                        case 5:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.6));
                            break;
                        case 6:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.2));
                            break;
                        case 7:
                            Console.WriteLine("El total a pagar es " + (preciototal * 0.1));
                            break;

                        default:
                            Console.WriteLine("El numero de la semana no valido ");
                            break;
                    }

                    break;

                case 6:
                    Console.WriteLine("Cuantos productos desea llevar ?");
                    int cantidadProducto = int.Parse(Console.ReadLine());
                    int count = 1;
                    while(count < cantidadProducto)
                    {
                        Console.WriteLine($"Cantidad del producto {count} ");
                        int cantidadDeProductos = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Escriba el valor de ese producto {count} ");
                        int valorDeProducto = int.Parse(Console.ReadLine());

                    }

                    break;

                case 7:
                    bool start = true;
                    while(start)
                    Console.WriteLine("Para atender un cliente ingrese el 1, para dejar de antender 2");
                    int opcion = int.Parse(Console.ReadLine());
                    int clint = 1;
                    if(opcion == 1)
                    {   
                        Console.WriteLine("Cliente: " + clint);
                        Console.WriteLine("Cuantos productos desea llevar ?");
                        cantidadProducto = int.Parse(Console.ReadLine());
                        int sum = 0;
                        for (int i = 1; i < cantidadProducto; i++)
                        {
                            Console.WriteLine($"Cantidad del producto {i} ");
                            int cantidadDeProductos = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Valor del producto {i} ");
                            int valorDeProducto = int.Parse(Console.ReadLine());
                            sum = sum + valorDeProducto;
                        }
                        
                        if(sum < 100000)
                        {
                            double discount = sum * 0.1;
                            double totalpay = sum - discount;
                            Console.WriteLine("Total de la factura: " + totalpay);
                        }
                        if (sum< 100000)
                        {
                            Console.WriteLine("Total de la factura: " + sum);
                        }

                        clint = clint +1;
                    }

                    break;
            }
        }
    }
}
