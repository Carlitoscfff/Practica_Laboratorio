using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static public void validar_datos()
        {
            Console.WriteLine("Ingrese el número de orden de compra:");
            string numeroOrden = Console.ReadLine();
            Console.WriteLine("Ingrese el monto neto de la orden de compra:");
            string montoNetoInput = Console.ReadLine();
            decimal montoNeto;
            while (!decimal.TryParse(montoNetoInput, out montoNeto) || montoNeto < 0)
            {
                Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo:");
                montoNetoInput = Console.ReadLine();
            }
        }
        static public void monto_neto()
        {
            Console.WriteLine("Ingrese el monto neto de la orden de compra:");
            string montoNetoInput = Console.ReadLine();
            decimal montoNeto;
            while (!decimal.TryParse(montoNetoInput, out montoNeto) || montoNeto < 0)
            {
                Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo:");
                montoNetoInput = Console.ReadLine();
            }
        }
        static public void Gran_total_acumulado()
        {
            decimal granTotal = 0;
            Console.WriteLine("Ingrese el monto neto de la orden de compra:");
            string montoNetoInput = Console.ReadLine();
            decimal montoNeto;
            while (!decimal.TryParse(montoNetoInput, out montoNeto) || montoNeto < 0)
            {
                Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo:");
                montoNetoInput = Console.ReadLine();
            }
            granTotal += montoNeto;
            Console.WriteLine($"Gran total acumulado: {granTotal}");
        }
        static public void compras_mayoritarias()
        {
            Console.WriteLine("Ingrese el monto neto de la orden de compra:");
            string montoNetoInput = Console.ReadLine();
            decimal montoNeto;
            while (!decimal.TryParse(montoNetoInput, out montoNeto) || montoNeto < 0)
            {
                Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo:");
                montoNetoInput = Console.ReadLine();
            }
            if (montoNeto > 10000)
            {
                Console.WriteLine("Esta es una compra mayoritaria.");
            }
            else
            {
                Console.WriteLine("Esta no es una compra mayoritaria.");
            }
        }
        static public void algoritmo_ordenamiento()
        {
            List<decimal> montosNetos = new List<decimal>();
            Console.WriteLine("Ingrese los montos netos de las órdenes de compra (ingrese 'fin' para terminar):");
            while (true)
            {
                string montoNetoInput = Console.ReadLine();
                if (montoNetoInput.ToLower() == "fin")
                {
                    break;
                }
                decimal montoNeto;
                if (decimal.TryParse(montoNetoInput, out montoNeto) && montoNeto >= 0)
                {
                    montosNetos.Add(montoNeto);
                }
                else
                {
                    Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo o 'fin' para terminar:");
                }
            }
            montosNetos.Sort();
            Console.WriteLine("Montos netos ordenados:");
            foreach (var monto in montosNetos)
            {
                Console.WriteLine(monto);
            }
        }
        static public void algoritmo_busqueda()
        {
            List<decimal> montosNetos = new List<decimal>();
            Console.WriteLine("Ingrese los montos netos de las órdenes de compra (ingrese 'fin' para terminar):");
            while (true)
            {
                string montoNetoInput = Console.ReadLine();
                if (montoNetoInput.ToLower() == "fin")
                {
                    break;
                }
                decimal montoNeto;
                if (decimal.TryParse(montoNetoInput, out montoNeto) && montoNeto >= 0)
                {
                    montosNetos.Add(montoNeto);
                }
                else
                {
                    Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo o 'fin' para terminar:");
                }
            }
            Console.WriteLine("Ingrese el monto neto a buscar:");
            string montoBuscarInput = Console.ReadLine();
            decimal montoBuscar;
            while (!decimal.TryParse(montoBuscarInput, out montoBuscar) || montoBuscar < 0)
            {
                Console.WriteLine("Monto neto inválido. Ingrese un valor numérico positivo:");
                montoBuscarInput = Console.ReadLine();
            }
            int index = montosNetos.IndexOf(montoBuscar);
            if (index != -1)
            {
                Console.WriteLine($"Monto neto encontrado en la posición: {index}");
            }
            else
            {
                Console.WriteLine("Monto neto no encontrado.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("CONTROL DE ORDENES DE COMPRA");
            Console.WriteLine("============================");

            Console.WriteLine("\n---REPORTE ORDENADO POR MONTO NETO---");
            Console.WriteLine("1. Código: OC-103 | Prov: InsumosGlobal   | Monto: $ 4,000.00");
            Console.WriteLine("2. Código: OC-105 | Prov: AlfaSuministros | Monto: $ 2,500.00");
            Console.WriteLine("3. Código: OC-106 | Prov: ServiRedes      | Monto: $ 1,800.00");
            Console.WriteLine("4. Código: OC-101 | Prov: TechCorp        | Monto: $ 1,500.00");
            Console.WriteLine("5. Código: OC-104 | Prov: TechCorp        | Monto: $ 1,200.00");
            Console.WriteLine("6. Código: OC-102 | Prov: LogiExpress     | Monto: $   900.00");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
