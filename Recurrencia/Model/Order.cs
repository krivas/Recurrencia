using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrencia.Model
{
    class Order
    {
        private int _idClient;

        private int _IdOrder;

        public int IdOrder
        {
            get { return _IdOrder; }
            set { _IdOrder = value; }
        }


        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }
        private DateTime _originDate;

        public DateTime OriginDate
        {
            get { return _originDate; }
            set { _originDate = value; }
        }
        private DateTime _releaseDate;

        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

       private int _total;

       public int Total
       {
           get { return _total; }
           set { _total = value; }
       }
       public Order(int idClient, DateTime orderDate, DateTime requireDate, int total)
       {
           this._idClient = idClient;
           this._originDate = orderDate;
           this._releaseDate = requireDate;
           this._total = total;
       }
       
    }
}
