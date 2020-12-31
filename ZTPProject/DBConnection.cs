using System;
using System.Collections.Generic;
using System.Text;

namespace ZTPProject
{
    class DBConnection
    {
        private DBConnection() { }
        private static DBConnection instance = null;
        public static DBConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
    }
}
