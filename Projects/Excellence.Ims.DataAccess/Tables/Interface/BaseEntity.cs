using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims.DataAccess.Tables.Contact
{
    //public abstract class BaseContact : BaseId
    //{
    //    public string Email { get; set; }
    //    public string Phone { get; set; }
    //    public string Address { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string Country { get; set; }
    //}

    //public abstract class BasePerson : BaseContact
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}

    //public abstract class BaseCompany : BasePerson
    //{
    //    public string CompanyName { get; set; }
    //    public string CompanyEmail { get; set; }
    //    public string CompanyPhone { get; set; }
    //}

    public interface IContact
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public interface IPerson : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface ICompany : IContact
    {
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
    }
}
