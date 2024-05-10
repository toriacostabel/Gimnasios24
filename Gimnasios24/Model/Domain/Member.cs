namespace Gimnasios24.Model.Domain
{
    public class Member : Person
    {
        private string _type;
        private string _email;
        private int _localId;

        public Member(int id, string name, string phone, string type, string email, int localId)
            : base(id, name, phone)
        {
            _type = type;
            _email = email;
            _localId = localId;
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int LocalId
        {
            get { return _localId; }
            set { _localId = value; }
        }
    }
}
