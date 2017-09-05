using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ExceptionHandling
{
	public class MainPage : ContentPage 
	{
		List<string> messages = new List<String>();

		public MainPage() 
		{
			List<string> names = new List<string>
			{
				"Jesse",
				"Mark",
				null,
				"Stacey"
			};

			//TODO #2: Add try and catch to stop the program crash
			foreach (string name in names) 
			{
				try 
				{
					SayHello(name);
				}
				catch (ArgumentNullException)
				{
					messages.Add("Anonymous name");
				}
			}

			Padding = 20;
			Content = new ListView() { ItemsSource = messages };
		}

		public void SayHello(string name) 
		{
			//TODO #1: use string.IsNullOrEmpty to test the passed
			// parameter - if it's empty or null then throw an exception.
			if (string.IsNullOrEmpty(name)) 
			{
				throw new ArgumentNullException("name");
			} 

			messages.Add(name);
		}
	}
}