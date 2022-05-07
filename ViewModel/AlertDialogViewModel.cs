using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class AlertDialogViewModel : DialogViewModelBase<bool>
    {
        public ICommand OkCommand { get; private set; }

        public AlertDialogViewModel(string title, string message) : base(title, message)
        {
            OkCommand = new OKCommand(this);
        }
    }
}
