﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			Dog newDog = new Dog
			{
				Name = "Bobo",
				Age = 13,
				Breed = "Mix"
			};

			MySQLDB db = new MySQLDB();
			
			db.insertDog(newDog);

		}
	}
}
