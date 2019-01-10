﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Wimym.Model.Domain._Control;

namespace Wimym.Model.Domain.DbHelper
{
    public class AuditEntity
    {
        //public string Code { get; set; }

        //public string Name { get; set; }
       
        //public string Description { get; set; }

        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public ApplicationUser CreatedUser { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        [ForeignKey("UpdatedBy")]
        public ApplicationUser UpdatedUser { get; set; }

        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        [ForeignKey("DeletedBy")]
        public ApplicationUser DeletedUser { get; set; }
    }
}
