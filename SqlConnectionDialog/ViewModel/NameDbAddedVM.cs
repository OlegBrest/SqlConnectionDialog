using SqlConnectionDialog.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionDialog.ViewModel
{
    public class NameDbAddedVM : NotifyUIBase
    {
        private  string _name = string.Empty;
        public string NameDB 
        {
            get => _name;
            set
            {
                _name = value;
                onPropertyChanged(nameof(NameDB));
            }
        }
    }
}
