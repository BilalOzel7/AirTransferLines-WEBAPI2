﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core.Entities.Concrete
{
   public class UyeOperationClaim:IEntity
    {
        public int Id { get; set; }
        public int UyeID { get; set; }
        public int OperationClaimId { get; set; }
    }
}
