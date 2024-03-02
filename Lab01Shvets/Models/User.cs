namespace Lab01Shvets.Models
{
    class User
    {
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public int BDay
        {
            get { return _birthDate.Day; }
        }

        public int BMonth
        {
            get { return _birthDate.Month; }
        }

        public int BYear
        {
            get { return _birthDate.Year; }
        }
    }
}
