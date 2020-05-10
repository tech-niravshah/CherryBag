using System;
using System.Collections.Generic;

namespace CherryBag.Data.DB
{
    public partial class PartyTypeMaster
    {
        public PartyTypeMaster()
        {
            PartyMaster = new HashSet<PartyMaster>();
        }

        public int Id { get; set; }
        public string PartyTypeName { get; set; }

        public virtual ICollection<PartyMaster> PartyMaster { get; set; }
    }
}
