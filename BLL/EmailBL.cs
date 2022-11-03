using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class EmailBL
    {
        public IDataSource ds;

        public EmailBL(IDataSource ds)
        {
            this.ds = ds;
        }


        public List<Email> GetAll()
        {
            var list = ds.GetAll();
            return list;
        }
    }
}
