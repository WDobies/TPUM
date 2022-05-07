using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class SetListCommand : ICommand
    {
        private ShopViewModel viewModel;

        private int listIndex;

        public SetListCommand(ShopViewModel viewModel, int listIndex)
        {
            this.viewModel = viewModel;
            this.listIndex = listIndex;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.SelectedListIndex != listIndex;
        }

        public void Execute(object parameter)
        {
            viewModel.SelectedListIndex = listIndex;
            viewModel.model.ChangeProductList(viewModel.SelectedListIndex);
            viewModel.CopyModelAllProducts();
        }
    }
}
