using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmnipotantDev.API.Models
{
    public class Character 
    {
        public int ID { get; set; }
        public string CharacterName {get;set;}
        public string pictureUrl { get; set; }
        public int level { get; set; }
        public string UserName { set; get; }


    }
}