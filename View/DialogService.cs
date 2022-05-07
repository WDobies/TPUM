using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class DialogService : ViewModel.IDialogService
    {
        public T OpenDialog<T>(ViewModel.DialogViewModelBase<T> viewModel)
        {
            ViewModel.IDialogWindow window = new DialogWindow();
            window.DataContext = viewModel;
            window.ShowDialog();
            return viewModel.DialogResult;
        }
    }
}
