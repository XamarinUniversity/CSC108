using System.Collections.Generic;

namespace Debugging
{
	public class Person 
    {
		public string Name     { get; set; }
		public int    Age      { get; set; }
		public int    Siblings { get; set; }

		public string HaveBirthday() 
        {
            return string.Format("{0} is {1} years old!", Name, ++Age);
		}

		public string DescribeFamily() 
        {
            string siblingText;

            if (Siblings == 0)
			{
                siblingText = " has no siblings";
            }
			else
			{
                siblingText = " has " + Siblings + " siblings";
            }

            return Name + siblingText;
		}

        public static List<Person> GetPeople()
		{
            var people = new List<Person>
			{
                new Person { Name = "Rachel", Age = 20, Siblings = 0 },
				new Person { Name = "Bobby",  Age = 16, Siblings = 2 },
				new Person { Name = "John",   Age = 35, Siblings = 1 },
				new Person { Name = "Mary",   Age = 40, Siblings = 4 },
			};

			return people;
		}
	}
}