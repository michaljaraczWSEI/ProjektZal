using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ExpenseIt
{
    class EmployeesListViewModel
    {
        private DataBaseService _dbService;
        private ObservableCollection<PersonModel> _users = new ObservableCollection<PersonModel>();
        public EmployeesListViewModel()
        {
            _dbService = new DataBaseService();
            _users = new ObservableCollection<PersonModel>(_dbService.LoadUsers());
        }
        public ObservableCollection<PersonModel> Users 
        { 
            get { return _users; } 
        }
    }
}
