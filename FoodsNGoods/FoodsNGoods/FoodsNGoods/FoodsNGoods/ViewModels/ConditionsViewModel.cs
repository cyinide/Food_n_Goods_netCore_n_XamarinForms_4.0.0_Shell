using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodsNGoods.ViewModels
{
    public class ConditionsViewModel : BaseViewModel
    {

        private string _terms = "By accessing this web site, you are agreeing to be bound by these web site Terms and Conditions of Use, all applicable laws and regulations," +
           " and agree that you are responsible for compliance with any applicable local laws. If you do not agree with any of these terms," +
           " you are prohibited from using or accessing this site. The materials contained in this web site are protected by applicable copyright and trade mark law.The materials on Foods and Goods web site are provided as is." +
            " Foods and Goods makes no warranties, expressed or implied, and hereby disclaims and negates all other warranties, including without limitation," +
            " implied warranties or conditions of merchantability, fitness for a particular purpose, or non-infringement of intellectual property or other violation of rights." +
           " Further, Foods and Goods does not warrant or make any representations concerning the accuracy, likely results, or reliability of the use of the materials on its Internet web site or otherwise relating to such materials or on any sites linked to this site.";

        public string Terms
        {
            get
            {
                return _terms;
            }
            set
            {
                _terms = value;
                RaisePropertyChanged(() => Terms);
            }
        }

        private bool _termsAreScrolled = false;
        public bool TermsAreScrolled
        {
            get
            {
                return _termsAreScrolled;
            }
            set
            {
                _termsAreScrolled = value;
                RaisePropertyChanged(() => TermsAreScrolled);
            }
        }


        public ICommand NavigateCommand
        {
            get
            {
                return new Command<string>(async (route) =>
                {

                    await Shell.Current.GoToAsync(route);


                });
            }
        }

    }
}
