using LoginRegister_Xamarin.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoginRegister_Xamarin.Service
{
    public class LoginService : ILoginService
    {
        private SQLiteConnection _dbConnection;

        public LoginService()
        {
            SetupDb();
        }

        

        private void SetupDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LoginDB.db3");

                _dbConnection = new SQLiteConnection(dbPath);
                _dbConnection.CreateTable<LoginData>();
            }
        }

        public void AddUser()
        {
            throw new NotImplementedException();
        }
    }
}
