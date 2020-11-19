using System;
using System.ComponentModel.DataAnnotations;

namespace Excellence.Ims.DataAccess.Tables
{
    public class Project : IDescribable, ICompletable
    {
        #region Primitive

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public bool Complete { get; set; }

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
