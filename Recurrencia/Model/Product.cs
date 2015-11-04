using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrencia.Model
{
    class Product
    {
        private int _id;

        public int  Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Product(string description,int price)
        {
            
            this.Description = description;
            this.Price = price;
            

        }

        public Product(int id, int price, int quantity)
        {

            this.Id = id;
            this.Price = price;
            this.Quantity=quantity;

        }


    }
}
