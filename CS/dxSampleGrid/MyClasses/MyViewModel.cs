using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dxSampleGrid {
    public class MyViewModel : INotifyPropertyChanged {
        public MyViewModel() {
            CreateList();
            ViewModelName = "MyViewModel1";
            SomeValue = 5;
        }
        string _viewModelName;
        Person _selectedPerson;
        ICommand _myVoidCommand;


        public ObservableCollection<Person> ListPerson { get; set; }
        public string ViewModelName {
            get { return _viewModelName; }
            set {
                _viewModelName = value;
                RaisePropertyChanged();
            }
        }
        public int SomeValue { get; set; }
        public Person SelectedPerson {
            get { return _selectedPerson; }
            set {
                _selectedPerson = value;
                RaisePropertyChanged();
            }
        }
        public ObservableCollection<SomeClass> ListSomeClass { get; set; }

        public ICommand MyVoidCommand {
            get {
                //if (_myVoidCommand == null)
                //    _myVoidCommand = new DelegateCommand(SomeMethod);
                return _myVoidCommand;
            }
        }


        void CreateList() {
            ListPerson = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++) {
                Person p = new Person(i);
                ListPerson.Add(p);
            }
            SelectedPerson = ListPerson[3];
            ListSomeClass = new ObservableCollection<SomeClass>();
            for (int i = 0; i < 200; i += 10)
                ListSomeClass.Add(new SomeClass(i));
        }
        void SomeMethod() {
            Debug.Print("Some action");

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName]String propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
