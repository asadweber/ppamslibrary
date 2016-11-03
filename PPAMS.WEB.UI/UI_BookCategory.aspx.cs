using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPAMS.Service;
using PPAMS.DAL;
using PPAMS.Entity;

namespace PPAMS.WEB.UI
{
    public partial class UI_BookCategory : System.Web.UI.Page
    {
        private IBookCategoryService bookCategoryService { get; set; }
        
        public UI_BookCategory()
        {
            bookCategoryService = new BookCategoryService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bookCategoryService.GetAll();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            bookCategoryService.Save(BuildEntity(new BookCatagory()));
        }

        private BookCatagory BuildEntity(BookCatagory obj)
        {
            if (!string.IsNullOrEmpty(hhdId.Value))
                obj.Id = long.Parse(hhdId.Value);
            obj.Name = txtName.Text;
            return obj;
        }
    }
}
