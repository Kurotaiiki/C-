using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Facturacion
{
    internal class Products
    {
        public string name;
        public double price;
        List<Products> productsObject= new List<Products>();

        public  void Create(string _name,double _price)
        {
            Products product=new Products();
            product.name = _name;
            product.price = _price;
            productsObject.Add(product);
        }

        public void Show()
        {
            Array arr_productsObject = productsObject.ToArray();

            for(int i = 0; i < arr_productsObject.Length; i++)
            {
                WriteLine($"{productsObject[i].name}  {productsObject[i].price}");
            }
        }

        public Products[] See()
        {
            Products[] arr_productsObject = productsObject.ToArray();
            return arr_productsObject;

        }

    }
}
