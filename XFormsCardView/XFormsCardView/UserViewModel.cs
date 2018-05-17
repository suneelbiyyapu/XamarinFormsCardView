using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFormsCardView
{
    public class UserViewModel
    {
        public IList<User> lstUsers { get; set; }

        public object SelectedItem { get; set; }

        public UserViewModel()
        {
            lstUsers = new List<User>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            string[] arrNames = {
                "David", "John", "Paul", "Mark", "James",
                "Andrew", "Scott", "Steven", "Robert", "Stephen",
                "William", "Craig", "Michael", "Stuart", "Christopher",
                "Alan", "Colin", "Brian", "Kevin"
            };

            Random rnd = new Random();

            for (var i = 0; i < arrNames.Length; i++)
            {
                var age = rnd.Next(10, 30);
                var user = new User()
                {
                    Name = arrNames[i],
                    Age = age,
                    HasVote = age > 18 ? Color.Green : Color.Red,
                };
                lstUsers.Add(user);
            }
        }
    }
}
