using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    class AlertCommand : ICommand
    {
        private ShopViewModel viewModel;


        public AlertCommand(ShopViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var dialog = new AlertDialogViewModel("Zamówienie", "Zamówienie Anulowane :(");
            var result = viewModel.dialogService.OpenDialog(dialog);
        }
    }
}
