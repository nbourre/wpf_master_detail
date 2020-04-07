using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_master_detail.Services
{
    interface IDataService<T>
    {
        public IEnumerable<T> GetAll();
    }
}
