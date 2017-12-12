using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App7
{
    public class MySQLDB
    {
		private SQLiteConnection _connection;

		public MySQLDB()
		{
			_connection = DependencyService.Get<ISQLite>().GetAConnection();
		}

		public void  insertDog(Dog dogToInsert)
		{
			_connection.Insert(dogToInsert);
		}
    }
}
