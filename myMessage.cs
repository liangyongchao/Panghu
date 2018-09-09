using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallMe.Models
{
    public class myMessage
    {
        public int _id { get; set; }
        public string _msg { get; set; }

        private int ID { get; set; }
        private string Msg { get; set; }

        public void main()
        {
            ID = _id;
            Msg = _msg;
        }
    }
}