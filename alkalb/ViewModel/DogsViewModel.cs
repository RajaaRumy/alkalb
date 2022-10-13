using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using alkalb.Model;
using alkalb.Command; 
using System.Collections.ObjectModel;
using System.Security.AccessControl;

namespace alkalb.ViewModel
{
    public class DogsViewModel : INotifyPropertyChanged
    {
        #region INottifyPropertyChanged_Implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChaned(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        Hundeserviccs ObjHundeserviccs;
        public DogsViewModel()
        {
            ObjHundeserviccs = new Hundeserviccs();
            LoadData(); 
            CurrentDogs = new Dogs();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
           

        }
        #region DisplayOperation
        private ObservableCollection<Dogs> dogsList;

        public ObservableCollection<Dogs> DogsList
        {
            get { return dogsList; }    
            set { dogsList = value; OnPropertyChaned("DogsListe"); }   
        }
        private void LoadData()
        {
            DogsList = new ObservableCollection<Dogs>(ObjHundeserviccs.GetAll());

        }
        #endregion
        private Dogs currentDogs;
        public Dogs CurrentDogs
        {
            get { return currentDogs; }
            set { currentDogs = value; OnPropertyChaned("CurrentDogs"); }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChaned("Message"); }
        }


        #region SaveOperation
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get { return saveCommand; } 
          
        }
        public void Save()
        {
            try
            {
                var IsSaved =ObjHundeserviccs.Add(CurrentDogs); 
               
                if (IsSaved)
                {
                    Message = " Dogs Saved";
                    LoadData();
                }

                else
                {
                    Message = " Save operation failed";
                }



            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }


        }
        #endregion

        #region SearchOperation
        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }
        public void Search()
        {
            try
            {
                var ObjDogs = ObjHundeserviccs.Search(currentDogs.ID);
                if (ObjDogs != null)
                {
                    currentDogs.PedigreeNumber = ObjDogs.PedigreeNumber; // forsæt med de andre
                    currentDogs.Name = ObjDogs.Name;
                    currentDogs.Birthday = ObjDogs.Birthday;
                    currentDogs.Gender = ObjDogs.Gender;
                    currentDogs.Color = ObjDogs.Color;
                    currentDogs.ChipNumber = ObjDogs.ChipNumber;
                    currentDogs.FathersPedigeeNumber = ObjDogs.FathersPedigeeNumber;
                    currentDogs.MothersPedigeeNumber = ObjDogs.MothersPedigeeNumber;

                }
                else
                {
                    Message = " Dog not found";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
        #endregion
        #region UpdateOperation
        private RelayCommand updateCommand;
        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
            set { updateCommand = value; }

        }
        public void Update()
        {
            try
            {

                var IsUdated = ObjHundeserviccs.Update(CurrentDogs);
                if (IsUdated)
                {
                    Message = " Dog Updated";
                    LoadData();
                }
                else
                {
                    Message = "Update Operation failed";
                }
            }
            catch (Exception ex)
            {
                Message= ex.Message;
            }
              
        }
        #endregion

        #region DeleteOperation
        private RelayCommand deleteCommand;
        public RelayCommand Deletecommand
        {
            get { return deleteCommand; }

        }
        public void Delete()
        {
            try
            {
                var IsDelete = ObjHundeserviccs.Delete(CurrentDogs.ID);
                
                if (IsDelete)
                {
                    Message = " Dog is Delete"; 
                    LoadData();
                }

                else
                {
                    Message = " Delete operation failed";
                }



            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }


        }
        #endregion

    }
}
