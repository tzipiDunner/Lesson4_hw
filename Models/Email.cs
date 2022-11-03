using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Email
    {
       public Contact send;
       public  string subject;
       public  string text;
       public  List<Contact> accepteds;

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("");
            foreach (var item in accepteds)
                str.Append(Environment.NewLine+item.ToString()+" " );
            return "The sent-" + send.ToString() + Environment.NewLine+
                "the subject-" + subject + Environment.NewLine+
                "the text-" + text + Environment.NewLine+ "the accepted-" + str;
        }
    }
}
