using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class StateMaster
    {
        public StateMaster()
        {
            CityMaster = new HashSet<CityMaster>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<CityMaster> CityMaster { get; set; }
    }
}
