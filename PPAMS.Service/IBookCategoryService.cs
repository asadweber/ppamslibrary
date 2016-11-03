using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPAMS.Entity;

namespace PPAMS.Service
{
    public interface IBookCategoryService
    {
        /// <summary>
        /// Get All Book Category
        /// </summary>
        /// <returns></returns>
        List<BookCatagory> GetAll();
        
        /// <summary>
        /// Get Book Category by Id
        /// </summary>
        /// <param name="categotyId"></param>
        /// <returns></returns>
        
        BookCatagory GetById(long categotyId);
        
        /// <summary>
        /// Save Book Category
        /// </summary>
        /// <param name="bookCategory"></param>
        void Save(BookCatagory bookCategory);
        
        /// <summary>
        /// Update Book Category
        /// </summary>
        /// <param name="bookCategory"></param>
        void Update(BookCatagory bookCategory);


        /// <summary>
        /// Delete Book Category
        /// </summary>
        /// <param name="bookCategory"></param>
        void Delete(BookCatagory bookCategory);

    }
}
