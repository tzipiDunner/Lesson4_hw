using System.Collections.Generic;
using Models;

namespace DAL
{
    public class MockDataSorse:IDataSource
    {

        void init()
        {
            emails = new List<Email>();
            Contact p1 = new Contact("erdf", "fcf", "234@defg.gh");   
            Contact p2 = new Contact("gfhj", "fghj", "34567@defg.gh");
            List<Contact> acceptedList = new List<Contact>();
            acceptedList.Add(p1);
            acceptedList.Add(p2);
            emails.Add(new Email() { send = p1, subject = "fff", text = "khdfgf", accepteds = acceptedList }) ;
            emails.Add(new Email() { send = p2, subject = "GFDDG", text = "FGDSGFDSG", accepteds = acceptedList }) ;
            emails.Add(new Email() { send = p1, subject = "mmm", text = "jhjkd", accepteds = acceptedList }) ;
        }

        //CRUD
        public List<Email> GetAll()
        {
            if (emails == null) init();
            return emails;
        }

        public Email GetBySendMailAdress(string mailAdress)
        {
            foreach (var item in emails)
            {
                if (item.send.EmailAdress == mailAdress)
                    return item;
            }
            return null;
        }

        public void AddProduct(Email product)
        {
            emails.Add(product);
        }
        public void RemoveMail(string mailAdress)
        {
            emails.Remove(GetBySendMailAdress(mailAdress));
        }
        public void UpdateMail(string mailAdress,string newText)
        {
            Email e = GetBySendMailAdress(mailAdress);
            if (e != null)
                e.text = newText;
        }

        List<Email> emails;
    }
}
