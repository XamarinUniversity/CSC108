using Xamarin.Forms;
using System.Collections.Generic;

namespace Debugging
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            List<string> messages = new List<string>();

            messages.Add("Happy Birthday Everyone!");

            var people = Person.GetPeople();

            foreach (Person p in people)
			{
                messages.Add( p.HaveBirthday() );
                messages.Add( p.DescribeFamily() );
            }

            Content = new ListView { ItemsSource = messages };
        }
    }
}