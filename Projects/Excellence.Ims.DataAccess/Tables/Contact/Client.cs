namespace Excellence.Ims.DataAccess.Tables
{
    public class Client : IPerson, ICompany
    {
        #region Primitive

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }

        #endregion

        #region Foreign - One

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion     
    }
}
