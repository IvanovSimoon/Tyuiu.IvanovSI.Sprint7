using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovSI.Sprint7.Project0.V2.Lib
{
    public class DataService
    {
        public class Store
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public double OwnerCapital { get; set; }
        }

        // Класс для представления поставщика
        public class Supplier
        {
            public int Number { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public double DeliveryCost { get; set; }
        }

        // Класс для представления связи между магазином и поставщиком
        public class SupplyRelationship
        {
            public int StoreNumber { get; set; }
            public int SupplierNumber { get; set; }
            public double DeliveryCost { get; set; }
        }
    }
}
