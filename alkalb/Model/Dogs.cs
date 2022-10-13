using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace alkalb.Model
{
    public class Dogs : INotifyPropertyChanged
    {

        private int id;
        private string pedigreeNumber;
        private string name;
        private int birthday;
        private char gender;
        private string color;
        private string chipNumber;
        private string fathersPedigeeNumber;
        private string mothersPedigeeNumber;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertychanged(string PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertychanged("ID");
            }
        }
        public string PedigreeNumber
        {
            get { return pedigreeNumber; }
            set
            {
                pedigreeNumber = value;
                OnPropertychanged("PedigreeNumber");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertychanged("Name");
            }
        }

        public int Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertychanged("Birthday");
            }
        }
        public char Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertychanged("Gender");
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertychanged("Color");
            }
        }
        public string ChipNumber
        {
            get { return chipNumber; }
            set
            {
                chipNumber = value;
                OnPropertychanged("ChipNumber");
            }
        }
        public string FathersPedigeeNumber
        {
            get { return fathersPedigeeNumber; }
            set
            {
                fathersPedigeeNumber = value;
                OnPropertychanged("FatherssPedigeeNumber");
            }
        }
        public string MothersPedigeeNumber
        {
            get { return mothersPedigeeNumber; }
            set
            {
                mothersPedigeeNumber = value;
                OnPropertychanged("MotherssPedigeeNumber");

            }
        }








    }
}

