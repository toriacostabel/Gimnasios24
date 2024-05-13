namespace Gimnasios24.Model.Domain
{
    public class Machine
    {
        private int _id;
        private int _localId;
        private DateTime _purchaseDate;
        private decimal _purchasePrice;
        private int _lifespan;
        private string _type;
        private bool _available;

        public Machine(int id, int localId, DateTime purchaseDate, decimal purchasePrice, int lifespan, string type, bool available)
        {
            _id = id;
            _localId = localId;
            _purchaseDate = purchaseDate;
            _purchasePrice = purchasePrice;
            _lifespan = lifespan;
            _type = type;
            _available = available;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int LocalId
        {
            get { return _localId; }
            set { _localId = value; }
        }

        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        public decimal PurchasePrice
        {
            get { return _purchasePrice; }
            set { _purchasePrice = value; }
        }

        public int Lifespan
        {
            get { return _lifespan; }
            set { _lifespan = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }
    }
}
