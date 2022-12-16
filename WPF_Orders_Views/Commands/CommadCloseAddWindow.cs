using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Orders_Views.ModelViews;

namespace WPF_Orders_Views.Commands
{
    public class CommadCloseAddWindow : CommandBase
    {

        private MainViewModel _mainViewModel;
        private HomeViewModel _homeViewModel;

        public CommadCloseAddWindow(MainViewModel mainViewModel, HomeViewModel homeModelView)
        {
            _mainViewModel = mainViewModel;
            _homeViewModel = homeModelView;
        }

        public override void Execute(object? parameter)
        {
            _mainViewModel.CurrentView = _homeViewModel;
        }
    }
}
