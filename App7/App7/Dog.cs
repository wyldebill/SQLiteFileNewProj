using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App7
{
    public class Dog
    {
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public String Name { get; set; }
		public int Age { get; set; }
		public string Breed { get; set; }

		public Dog()
		{

		}
	}
}
