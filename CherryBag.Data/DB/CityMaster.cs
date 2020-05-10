using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class CityMaster
    {
        public CityMaster()
        {
            UserAddress = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }

        public virtual StateMaster State { get; set; }
        public virtual ICollection<UserAddress> UserAddress { get; set; }
    }
}
