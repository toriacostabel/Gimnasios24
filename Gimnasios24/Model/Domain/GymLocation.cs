namespace Gimnasios24.Model.Domain
{
    public class GymLocation
    {
        private int _id;
        private string _name;
        private string _city;
        private string _address;
        private string _phone;
        private Manager _manager;

        public GymLocation(int id, string name, string city, string address, string phone, Manager manager)
        {
            _id = id;
            _name = name;
            _city = city;
            _address = address;
            _phone = phone;
            _manager = manager;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public Manager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
    }
}
