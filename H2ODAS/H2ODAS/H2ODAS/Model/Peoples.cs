using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2ODAS.Model
{
   public class Peoples
    {
         
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
    