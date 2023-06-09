﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Models
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        public int ClosetNumber { get; set; }
        public int ShelfNumber { get; set; }
        public int Capacity { get; set; }

        // relations
        public ICollection<BookStorage>? Storages { get; set;}

    }
}
