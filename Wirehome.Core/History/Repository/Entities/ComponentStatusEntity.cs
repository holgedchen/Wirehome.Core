﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wirehome.Core.History.Repository.Entities
{
    [Table("ComponentStatus")]
    public class ComponentStatusEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong ID { get; set; } 

        [StringLength(256)]
        public string ComponentUid { get; set; }

        [StringLength(256)]
        public string StatusUid { get; set; }

        [StringLength(512)]
        public string Value { get; set; }

        public DateTime RangeStart { get; set; }

        public DateTime RangeEnd { get; set; }

        public ulong? PreviousEntityID { get; set; }

        [ForeignKey("PreviousEntityID")]
        public ComponentStatusEntity PreviousEntity { get; set; }

        public ulong? NextEntityID { get; set; }

        [ForeignKey("NextEntityID")]
        public ComponentStatusEntity NextEntity { get; set; }
    }
}
