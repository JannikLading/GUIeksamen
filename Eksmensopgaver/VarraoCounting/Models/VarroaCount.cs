using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using Prism.Mvvm;

namespace VarraoCounting.Models
{
    public class VarroaCount : BindableBase
    {
        private string _beehive;
        private string _date = DateTime.Today.ToString("dd/MM/yyyy");
        private int _count;
        private string _notes;

        public string Beehive
        {
            get { return _beehive; }
            set { SetProperty(ref _beehive, value); }

        }

        public string Date
        {
            get { return _date; }
            set
            {
                SetProperty(ref _date, value);
            }

        }

        public int Count
        {
            get { return _count; }
            set { SetProperty(ref _count, value); }
        }

        public string Notes
        {
            get { return _notes; }
            set { SetProperty(ref _notes, value); }

        }
    }
}
