using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using VarraoCounting.Models;

namespace VarraoCounting.Viewmodels
{
    public class AddVarroaCountViewModel : BindableBase
    {
        private VarroaCount _newVarroaCount;
        private DateTime _date = DateTime.Today; 

        public AddVarroaCountViewModel(VarroaCount varroaCount)
        {
            _newVarroaCount = varroaCount; 
        }

        public VarroaCount NewVarroaCount
        {
            get { return _newVarroaCount; }
            set { SetProperty(ref _newVarroaCount, value); }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                SetProperty(ref _date, value);
                NewVarroaCount.Date = value.ToString("dd/MM/yyyy"); 
            }
        }

    }
}
