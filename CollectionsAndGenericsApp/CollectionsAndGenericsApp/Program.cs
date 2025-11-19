using CollectionsAndGenericsApp.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsAndGenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            // CaseStudy2();

            //CaseStudy3();

            //CaseStudy4();

            CaseStudy5();

        }

        private static void CaseStudy5()
        {

           var deptAndCount= new Dictionary<string,int>();
            deptAndCount["IT"] = 10;
            deptAndCount["Sales"] = 30;
            deptAndCount["Marketing"] = 50;

            foreach(string key in deptAndCount.Keys)
            {
                Console.Write(key.ToUpper());
                Console.WriteLine(deptAndCount["IT"]);
            }

            foreach (int value in deptAndCount.Values) {
                Console.WriteLine(value);
            }

            if (deptAndCount.ContainsKey("IT"))
            {
                deptAndCount["IT"] = deptAndCount["IT"]+ 100;
            }


        }

        private static void CaseStudy4()
        {
            var orderBasket = new HashSet<OrderItem>();
            var item1= new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 };
            var item2= new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 };

            Console.WriteLine(item1.GetHashCode());
            Console.WriteLine(item2.GetHashCode());


            orderBasket.Add(item1);
            orderBasket.Add(item2);


            Console.WriteLine(orderBasket.Count);
        }

        private static void CaseStudy3()
        {

            var uniqueNames = new HashSet<string>();
            uniqueNames.Add("Ashish");
            uniqueNames.Add("Praveen");
            uniqueNames.Add("Praveen");//GetHashCode() && Equals()

            Console.WriteLine(uniqueNames.Count);

            foreach (var name in uniqueNames) {
                Console.WriteLine(name);
            }

        }

        private static void CaseStudy2()
        {
            List<OrderItem> orderBasket = new List<OrderItem>();
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", Quantity = 2, UnitPrice = 65 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 55 });

            double checkoutPrice = 0;
            foreach (OrderItem temp in orderBasket)
            {
                checkoutPrice += temp.TotalCost();
                Console.WriteLine("id " + temp.Id + "name " + temp.Name + "unitprice" + temp.UnitPrice + "itemtotal" + temp.TotalCost());

            }

            

            Console.WriteLine("Checkout priceis " + checkoutPrice);
        }

        private static void CaseStudy1()
        {
            ArrayList orderBasket = new ArrayList();
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", Quantity = 2, UnitPrice = 65 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 55 });

            ///orderBasket.Add("Preeti");// collection not type safe
           // orderBasket.Add(100);

            double checkoutPrice = 0;
            foreach (object box in orderBasket)
            {

                OrderItem temp = box as OrderItem;
                checkoutPrice += temp.TotalCost();
                Console.WriteLine("id " + temp.Id + "name " + temp.Name + "unitprice" + temp.UnitPrice + "itemtotal" + temp.TotalCost());

            }

            Console.WriteLine("Checkout priceis " + checkoutPrice);
        }
    }
}
