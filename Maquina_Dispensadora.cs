using System;
using System.Collections.Generic;
using System.Linq;

namespace Maquina_Dispensadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Dinero = new int[] { 5, 10, 25, 50, 100, 200 };

            List<Productos> productos = new List<Productos>();
            int[] ID = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] Nombres = { "Coca cola","Agua","Barra Milky Way","Emanems M&M","Oreo","Doritos","Ruffles Jamon","Monster","Cheetos Picantes","Barra Twix"};
            int[] Precios = { 20, 10, 30, 15, 20, 15, 20, 120, 30, 25 };
            int[] Existencia = { 4, 2, 2, 3, 6, 7, 5, 8, 7, 5 };

            for (int i = 0; i < Nombres.Length; i++)
            {
                productos.Add(new Productos() { ID = ID[i], Nombre = Nombres[i], Precio = Precios[i], Existencia = Existencia[i] });
            }

            Console.WriteLine("\n-->       MAQUINA EXPENDEDORA        <--\n");
            
            Console.WriteLine();
            foreach (Productos Articulos in productos)
            {
                Console.WriteLine($"{Articulos.ID}  - Articulo: {Articulos.Nombre} -- Precio: {Articulos.Precio}");
            }
            Console.WriteLine("---------------------------------------");
            Console.Write("Introduce el dinero: ");

            try {
                int DineroIngresado = int.Parse(Console.ReadLine());
                int DineroTotal = 0;

                if (Dinero.Contains(DineroIngresado))
                {
                    DineroTotal = DineroIngresado;
                    Console.WriteLine("");
                    Console.Write("Eligir El Articulo: ");
                    int opcion = int.Parse(Console.ReadLine());
                    var data = productos.Where(x => x.ID == opcion).ToList();
                    Console.WriteLine();
                    foreach (var i in data)
                    {
                        Console.WriteLine($"{i.Nombre} -- {i.Precio}$ ");
                        Console.WriteLine("");
                        Console.WriteLine("-------------");
                        Console.WriteLine("1 - Confirmar");
                        Console.WriteLine("2 - Cancelar");
                        Console.WriteLine("-------------");
                        Console.Write("Elige una opcion: ");
                        int confirmar = int.Parse(Console.ReadLine());
                        if (confirmar == 1)
                        {
                            Console.WriteLine("");
                            int compra = ( DineroTotal - i.Precio);
                            if (compra >= 0)
                            {
                                int DineroRestante = (DineroTotal - i.Precio);

                                Console.WriteLine($"Compra confirmada, dinero restante: {DineroRestante}");
                                Console.WriteLine($"Articulo elegido: {i.Nombre}");
                                i.ID = (i.ID - 1);
                                Console.WriteLine($"Existencia: {i.ID}");
                            }
                            else
                            {
                                Console.WriteLine("Dinero insuficiente");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Cancelando compra y regresando el dinero: {DineroTotal}$");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("No se admite ese tipo de dinero, Favor introducir el dinero permitido");
                }
            }
           
            catch (Exception e) 
            {
                Console.WriteLine("valor invalido");
            }
            Console.ReadKey();
        }
        public class Productos
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Precio { get; set; }
            public int Existencia { get; set; }
        }
    }
}