using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPAMS.Service;
using PPAMS.Entity;

namespace PPAMS.DAL
{
    public  class BookInfoService : IBookInfoService
    {
        #region IBookInfoService Members

        List<BookInfo> IBookInfoService.GetAll()
        {
            throw new NotImplementedException();

            //
            //Hello
            //
        }

        BookInfo IBookInfoService.GetById(long categotyId)
        {
            throw new NotImplementedException();
        }

        void IBookInfoService.Save(BookInfo bookCategory)
        {
            throw new NotImplementedException();
        }

        void IBookInfoService.Update(BookInfo bookCategory)
        {
            throw new NotImplementedException();
        }

        void IBookInfoService.Delete(BookCatagory bookCategory)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
