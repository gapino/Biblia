using System;
using System.Collections.Generic;
using System.Text;

namespace Biblia.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel instace;

        public StartViewModel Start { get; set; }

        public BibliasViewModel Biblias { get; set; }

        #region Contructor
        public MainViewModel()
        {
            instace = this;
            this.Start = new StartViewModel();
        } 
        #endregion

        #region Patron Singleton
        public static MainViewModel GetInstance()
        {
            if (instace == null)
            {
                return new MainViewModel();
            }
            return instace;
        } 
        #endregion
    }
}
