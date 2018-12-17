using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestINotifyPropertyChanged
{
    public class MainViewModel : BaseViewModel
    {
        private string currentTime = "";
        public string CurrentTime
        {
            get { return currentTime; }
            set
            {
                if (value != currentTime)
                {
                    currentTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int randNumber = 0;
        public int RandNumber
        {
            get { return randNumber; }
            set
            {
                if (value != randNumber)
                {
                    randNumber = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
