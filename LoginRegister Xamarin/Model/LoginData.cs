using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginRegister_Xamarin.Model
{
    public class LoginData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
