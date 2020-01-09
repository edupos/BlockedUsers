using BlockedUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlockedUsers.ViewModel
{
    public class SearchViewModel
    {
        public int City { get; set; }
        public int Search { get; set; }
        public List<TblBloquedUsers> Result { get; set; }
    }
}