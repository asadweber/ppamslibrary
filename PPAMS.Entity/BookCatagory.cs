using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PPAMS.Entity
{
    [Serializable]
    public class BookCatagory
    {
        public long? Id { get; set; }
        public string Name { get; set; }


        public BookCatagory ReadReader(IDataReader objReader)
        {
            BookCatagory instance = new BookCatagory();
            
            instance.Id = objReader["Id"] != DBNull.Value ? Convert.ToInt32(objReader["Id"]) : instance.Id = null;
            instance.Name = objReader["Name"] != DBNull.Value ?
              Convert.ToString(objReader["Name"]) : instance.Name = null;
            
            return instance;
        }

      
    }
}
