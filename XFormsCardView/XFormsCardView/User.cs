using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFormsCardView
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // I assume if color is 
        // Green, then user has vote
        // Red, then user is below 18
        public Color HasVote { get; set; }
    }
}
