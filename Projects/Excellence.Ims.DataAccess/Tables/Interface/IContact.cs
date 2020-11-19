using System.ComponentModel.DataAnnotations;

namespace Excellence.Ims.DataAccess.Tables
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

    public interface IAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public interface IContact
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }

    public interface IPerson : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface ICompany : IContact
    {
        public string CompanyName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string CompanyEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string CompanyPhone { get; set; }
    }
}
