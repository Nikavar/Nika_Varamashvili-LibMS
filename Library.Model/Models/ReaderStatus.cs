﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Models
{
    public class ReaderStatus
    {
        public int ReaderStatusID { get; set; }
        public string ReaderStat { get; set; }
        public int LogID { get; set; }
        public LogInfo Logs { get; set; }
        public ICollection<StaffReader> StaffReaders { get; set; }
    }
}
