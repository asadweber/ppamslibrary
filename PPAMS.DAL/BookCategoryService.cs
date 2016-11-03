using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPAMS.Service;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using PPAMS.Entity;
using System.Data;

namespace PPAMS.DAL
{
    public class BookCategoryService : IBookCategoryService
    {
        #region IBookCategoryService Members

        public List<BookCatagory> GetAll()
        {
            Database db;
            string sqlCommand;
            DbCommand dbCommand;

            db = DatabaseFactory.CreateDatabase();
            sqlCommand = "BookCatagoryGetAll";
            dbCommand = db.GetStoredProcCommand(sqlCommand);

            List<BookCatagory> objPrdList = new List<BookCatagory>();
            using (IDataReader objReader = db.ExecuteReader(dbCommand))
            {
                while (objReader.Read())
                {
                    BookCatagory obj = new BookCatagory();
                    objPrdList.Add(obj.ReadReader(objReader));
                }
            }
            return objPrdList;
        }

        public BookCatagory GetById(long categotyId)
        {
            Database db;
            string sqlCommand;
            DbCommand dbCommand;
            BookCatagory instance = null;

            db = DatabaseFactory.CreateDatabase();
            sqlCommand = "BookCatagoryGetById";
            dbCommand = db.GetStoredProcCommand(sqlCommand, categotyId);

            // Get results.
            using (IDataReader objReader = db.ExecuteReader(dbCommand))
            {
                while (objReader.Read())
                {
                    instance = instance.ReadReader(objReader);
                }
            }
            return instance;
        }

        public void Save(BookCatagory bookCategory)
        {
            Database db;
            string sqlCommand;
            DbCommand dbCommand;

            db = DatabaseFactory.CreateDatabase();
            sqlCommand = "BookCatagoryInsert";
            dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.DiscoverParameters(dbCommand);
            dbCommand.Parameters["@Name"].Value = bookCategory.Name;
            db.ExecuteNonQuery(dbCommand);
        }

        public void Update(BookCatagory bookCategory)
        {
            throw new NotImplementedException();
        }

        public void Delete(BookCatagory bookCategory)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
