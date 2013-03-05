using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum2.ViewModel
{
    public class ThreadViewModels
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime DatePosted { get; set; }
    }
}