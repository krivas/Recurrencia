using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrencia.Model
{
    class Client
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _socialNumber;

        public string SocialNumber
        {
            get { return _socialNumber; }
            set { _socialNumber = value; }
        }
        private string _cellPhone;

        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }
        private string _homePhone;

        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }
        private string _workPhone;

        public string WorkPhone
        {
            get { return _workPhone; }
            set { _workPhone = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _alternateAdress;

        public string AlternateAdress
        {
            get { return _alternateAdress; }
            set { _alternateAdress = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _alternateEmail;

     

        public string AlternateEmail
        {
            get { return _alternateEmail; }
            set { _alternateEmail = value; }
        }
        private string _clientType;

        public string ClientType
        {
            get { return _clientType; }
            set { _clientType = value; }
        }
        private string _extention;

        public string Extention
        {
            get { return _extention; }
            set { _extention = value; }
        }
        private string _business;
        

   public string Business
    {
  get { return _business; }
  set { _business = value; }

}public Client(string name, string lastname, string socialNumber,string cellPhone,string homePhone,string workPhone,string address,string alternateAddress,string email,string alternateEmail,string clientType,string ext,string business )
        {
            this._name = name;
            this._lastName = lastname;
            this._socialNumber=socialNumber;
            this._cellPhone = cellPhone;
            this._homePhone = homePhone;
            this._workPhone = workPhone;
            this._address = address;
            this._alternateAdress = alternateAddress;
            this. _email = email;
            this._alternateEmail = alternateEmail;
            this._clientType = clientType;
            this._extention = ext;
            this._business = business;


        }

   public Client(string ID, string name, string lastName)
   {
       this.Id = ID;
       this.Name = name;
       this.LastName = lastName;
   }
       

    }
}
