using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPAMS.Entity;

namespace PPAMS.Service
{
   public interface IBookInfoService
    {
        /// <summary>
        /// Get All Book Info
        /// </summary>
        /// <returns></returns>
       List<BookInfo> GetAll();

        /// <summary>
       /// Get Book Info by Id
        /// </summary>
        /// <param name="categotyId"></param>
        /// <returns></returns>
       BookInfo GetById(long categotyId);

        /// <summary>
       /// Save Book Info
        /// </summary>
        /// <param name="bookCategory"></param>
       void Save(BookInfo bookCategory);

        /// <summary>
       /// Update Book Info
        /// </summary>
        /// <param name="bookCategory"></param>
       void Update(BookInfo bookCategory);


        /// <summary>
       /// Delete Book Info
        /// </summary>
        /// <param name="bookCategory"></param>
        void Delete(BookCatagory bookCategory);
    }
}
