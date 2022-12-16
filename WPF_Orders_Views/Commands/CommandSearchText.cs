using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Orders_Views.ModelViews;

namespace WPF_Orders_Views.Commands
{
    public class CommandSearchText : CommandBase
    {
        private HomeViewModel _homeModelView;

        public CommandSearchText(HomeViewModel homeModelView)
        {
            _homeModelView = homeModelView;
        }

        public override void Execute(object? parameter)
        {
            _homeModelView.Search();
        }
    }
}
