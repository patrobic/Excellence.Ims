using Excellence.Ims.DataAccess.Tables.Contact;

namespace Excellence.Ims.DataAccess.Tables.Misc
{
    public class Project : BaseDesc
    {
        #region Primitive

        #endregion

        #region Foreign - One

        public Client Client { get; set; }

        #endregion

        #region Foreign - Many

        #endregion

        #region Inverse

        #endregion
    }
}
