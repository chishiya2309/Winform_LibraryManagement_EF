using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_LibraryManagement_EF6
{
    public partial class FormEditCategory: Form
    {
        private string maDanhMuc;
        public FormEditCategory(string maDanhMuc)
        {
            InitializeComponent();
            this.maDanhMuc = maDanhMuc;
        }
        public FormEditCategory()
        {
            InitializeComponent();
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
