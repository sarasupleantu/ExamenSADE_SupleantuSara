using ExamenSADE_SupleantuSara.Models;

namespace ExamenSADE_SupleantuSara.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            if(context.Products.Any())
            {
                return; //BD a fost creata anterior
            }

            var products = new Product[]
            {
                new Product{ProductName="Bright Crystal",Brand="Versace",Price=Decimal.Parse("406")},
                new Product{ProductName="Magie Noire",Brand="Lancome",Price=Decimal.Parse("504")},
                new Product{ProductName="Libre",Brand="Yves Saint Laurent",Price=Decimal.Parse("398")}
            };
            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();

            var customers = new Customer[]
            {
                new Customer{CustomerID=10,Name="Pop Andrei",BirthDate=DateTime.Parse("1999-12-05")},
                new Customer{CustomerID=11,Name="Rusu Monica",BirthDate=DateTime.Parse("2001-01-10")},
                new Customer{CustomerID=12,Name="Ana Sofia",BirthDate=DateTime.Parse("1997-11-08")}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{ProductID=2,CustomerID=10},
                new Order{ProductID=1,CustomerID=10},
                new Order{ProductID=1,CustomerID=11},
                new Order{ProductID=3,CustomerID=12},
            };
            foreach (Order e in orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}
