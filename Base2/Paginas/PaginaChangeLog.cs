using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base2.Paginas
{
    class PaginaChangeLog
    {
        public PaginaChangeLog()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
