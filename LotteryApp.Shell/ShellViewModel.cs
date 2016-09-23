using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryApp.Common.Utils;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace LotteryApp.Shell
{
    public class ShellViewModel : BindableBase
    {

        public DelegateCommand<object> GenerateLotteryNumberCommand { get; set; }

        public ShellViewModel()
        {
            GenerateLotteryNumberCommand = new DelegateCommand<object>(OnNumberChange);
        }
        private IEnumerable<int> _lotteryNumbers;
        public IEnumerable<int> LotteryNumbers
        {
            get { return _lotteryNumbers; }
            set
            {
                _lotteryNumbers = value;
                OnPropertyChanged(() => this.LotteryNumbers);
            }
        }

        public void OnNumberChange(object param)
        {
            LotteryNumbers = LotteryHelper.GenerateLotteryNumbers(6, 1, 49);
        }
    }
}
