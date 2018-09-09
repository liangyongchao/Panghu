using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using CallMe.Models;

namespace CallMe.Service
{
    public class CommonFunctions
    {
        public string jsonSerialize(object obj)
        {
            if(obj is null)
            {
                return null;
            }
            string myStr = JsonConvert.SerializeObject(obj);
            return myStr;
        }

        public myMessage jsonDeserialize(string str)
        {
            if (str is null)
            {
                return null;
            }
            myMessage myObj =  JsonConvert.DeserializeObject<myMessage>(str);
            return myObj;
        }
    }
}