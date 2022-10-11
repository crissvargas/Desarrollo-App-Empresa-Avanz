using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Program
    {
        public static DataClasses2DataContext context = new DataClasses2DataContext();
        static void Main(string[] args)
        {
            IntroToLINQ();
            Console.Read();
        }
        static void IntroToLINQ()
        {
    
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numQuery)
            {
                Console.Write("{0,1}", num);
            }
        }
        static void DataSource()
        {

            var queryAllCustomers = from cust in context.clientes
                                    select cust;
            foreach (var item in queryAllCustomers)
            {
                Console.WriteLine(item.NombreCompañia);
            }

        }
        static void Filtering()
        {
            var queryLondonCustomers = from cust in context.clientes
                                       where cust.Ciudad == "Londres"
                                       select cust;
            foreach (var item in queryLondonCustomers)
            {
                Console.WriteLine(item.Ciudad);
            }
        }
        static void Ordering()
        {
            var queryLondonCustomer3 =
                from cust in context.clientes
                where cust.Ciudad == "London"
                orderby cust.NombreCompañia ascending
                select cust;
            
            foreach (var item in queryLondonCustomer3)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }
        static void Grouping()
        {
            var queryCustomersByCity =
                from cust in context.clientes
                group cust by cust.Ciudad;


            foreach (var customerGroup in queryCustomersByCity)
            {
                Console.WriteLine(customerGroup.Key);
                foreach (clientes customer in customerGroup)
                {
                    Console.WriteLine(" {0}", customer.NombreCompañia);
                }
            }
        }
        static void Grouping2()
        {
            var custQuery =
                from cust in context.clientes
                group cust by cust.Ciudad into custGroup
                where custGroup.Count()>2   
                orderby custGroup.Key
                select custGroup;
            
            foreach (var item in custQuery)
            {
                Console.WriteLine(item.Key);
            }
        }
        static void Joining()
        {
            var innerJoinQuery =
                from cust in context.clientes
                join dist in context.Pedidos on cust.idCliente equals dist.IdCliente
                select new { CustomerName = cust.NombreCompañia, DistributorName = dist.PaisDestinatario };
            
            foreach(var item in innerJoinQuery)
            {
                Console.WriteLine(item.CustomerName);
            }
        }
        //Lamdas
        static void LambdaILQ()
        {
            {
                int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };


                var numQuery = numbers.Where(c => c % 2 == 0).Select(c => c);


                foreach (int num in numQuery)
                {
                    Console.Write("{0,1}", num);
                }

            }
        }

        //LamdaDataSource
        static void LambdaDS()
        {
            var queryAllCustomers = context.clientes.Select(x => x);

            foreach (var item in queryAllCustomers)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }

        //Lambda Filtering
        static void LambdaF()
        {
            var queryLondonCustomers = context.clientes.Where(x => x.Ciudad == "Londres")
              .Select(x => x);

            foreach (var item in queryLondonCustomers)
            {
                Console.WriteLine(item.Ciudad);
            }
        }
        static void LambdaO()
        {
            var queryLondonCUstomers = context.clientes.Where(x => x.Ciudad == "London")
                            .OrderBy(x => x.NombreContacto)
                            .Select(x => x);

            foreach (var item in queryLondonCUstomers)
            {
                Console.WriteLine(item.NombreCompañia);
            }
        }
        static void LambdaG()
        {
            var queryCustomerByCity = context.clientes.GroupBy(x => x.Ciudad);


            foreach (var customerGroup in queryCustomerByCity)
            {
                Console.WriteLine(customerGroup);
                foreach (clientes customer in customerGroup)
                {
                    Console.WriteLine("   {0}", customer.NombreCompañia);
                }
            }
        }
        static void LambdaG2()
        {
            var custQuery = context.clientes.GroupBy(x => x.Ciudad)
                            .Where(x => x.Count() > 2)
                            .OrderBy(x => x.Key)
                            .Select(x => x);

            foreach (var item in custQuery)
            {
                Console.WriteLine(item.Key);
            }
        }
        static void LambdaJ()
        {
            var clients = context.clientes;
            var pedidos = context.Pedidos;

            var innerJoinQuery =
                clients.Join(pedidos, c =>
                c.idCliente, p => p.IdCliente,
                (c, p)
                => new { CustomerName = c.NombreCompañia, DistributorName = p.PaisDestinatario });


            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine(item.CustomerName);
            }
        }

    }
}
