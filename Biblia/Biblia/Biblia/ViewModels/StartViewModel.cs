using Biblia.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Biblia.ViewModels
{
    public class StartViewModel: BaseViewModel
    {
        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set { SetValue(ref isRunning, value); }
        }

        public ICommand NavegarCommand
        {
            get
            {
                return new RelayCommand(Navegar);
            }
        }

        private void Navegar()
        {
           Application.Current.MainPage = new BibliasPage();
        }

        public StartViewModel()
        {
            this.IsRunning = true;
           // MainViewModel.GetInstance().Biblias = new BibliasViewModel();
        }

        
    }
}
