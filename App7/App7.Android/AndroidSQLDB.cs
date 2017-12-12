using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App7.Droid;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidSQLDB))]

namespace App7.Droid
{
	public class AndroidSQLDB : ISQLite
	{
		public AndroidSQLDB()
		{ }

		public SQLiteConnection GetAConnection()
		{
			var file = "dogs.db";
			var location = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(location, file);

			var platform = new SQLitePlatformAndroid();
			var connection = new SQLiteConnection(platform, path);

			connection.CreateTable<Dog>();

			return connection;
		}
	}
}