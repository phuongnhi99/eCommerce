using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace eCommerce.Application.Dtos
{
    public class PagedViewModel<T>
    {
        List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
