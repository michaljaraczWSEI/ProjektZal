using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseIt
{
    class ExpenseReportViewModel
    {
        private DataBaseService _db;
        ExpenseReportViewModel()
        {
            _db = new DataBaseService();
        }
    }
}
