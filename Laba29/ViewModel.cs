using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Laba29
{
    internal class ViewModel:INotifyPropertyChanged
    {
        private Phone phone;
        public Phone selectedPhone
        {
            get => selectedPhone;
            set
            {
                selectedPhone = value;
                OnPropertyChanged()
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop="")
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        {

        }

    }
}
