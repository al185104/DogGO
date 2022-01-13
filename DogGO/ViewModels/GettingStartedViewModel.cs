using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DogGO.ViewModels
{
    public class GettingStartedViewModel : BaseViewModel
    {
        public GettingStartedViewModel()
        {

        }

        #region Commands
        public ICommand GetStartedCommand => new Command(async () => await ExecuteGetStartedCommand());

        private async Task ExecuteGetStartedCommand()
        {
            await Shell.Current.GoToAsync("//AboutPage");
        } 
        #endregion
    }
}
