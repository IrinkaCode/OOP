using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lesson88_DZ_WPF.Привязка_данных
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Person _person;
        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                OnPropertyChanged(nameof(Person));
            }
        }

        public ICommand GetDataCommand { get; }

        public MainViewModel()
        {
            GetDataCommand = new RelayCommand(GetData);
        }

        private void GetData()
        {
            DataService dataService = new DataService();
            Person = dataService.GetFirstPerson();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
