using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dxSampleGrid {
      [DebuggerDisplay("Id = {Id}, Name = {FirstName}, Value = {Age}")]
    public class Person : INotifyPropertyChanged {
        public Person() {

        }
        public Person(int i) {
            FirstName = "FirstName" + i;
            LastName = "LastName" + i;
            Age = i * 10;
            Group = i % 2 == 0;
            Id = i;
            SomeClasses = new ObservableCollection<SomeClass>();
            for (int j = 0; j < 5; j++) {
                SomeClasses.Add(new SomeClass(j));
            }
            BirthDate = new DateTime(2010, 1, 1).AddDays(i);
        }

        string _firstName;

        public string FirstName {
            get { return _firstName; }
            set {
                _firstName = value;
                RaisePropertyChanged();
            }
        }
        public string LastName { get; set; }
        int _age;

        public int Age {
            get { return _age; }
            set { _age = value; }
        }
        public bool Group { get; set; }
        public int Id { get; set; }
		        public int ParentId { get; set; }
        public DateTime BirthDate { get; set; }
        public ObservableCollection<SomeClass> SomeClasses { get; set; }

        public override string ToString() {
            return FirstName;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName]String propertyName = "") {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
