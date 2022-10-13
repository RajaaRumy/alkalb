using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alkalb.Model
{
    public class Hundeserviccs
    {
        private static List<Dogs> ObjDogsList;
        public Hundeserviccs()
        {
            ObjDogsList = new List<Dogs>()
            {
                new Dogs{ID= 01, PedigreeNumber= "2055/856", Name="Fofo", Birthday= 01021999, Gender= 'H', ChipNumber="1235/8dd", Color="hvid", FathersPedigeeNumber = "dh752", MothersPedigeeNumber= "tydj852" }

            };
             
        }
        public List<Dogs> GetAll()
        {
            return ObjDogsList;

        }
        public bool Add(Dogs objNewDogs)
        {
           ObjDogsList.Add(objNewDogs);
            return true;
        }
        public bool Update(Dogs objDogsToUpdate)
        {
            bool IsUpdate = false;
           for( int index = 0; index < ObjDogsList.Count; index++)
            {
                if (ObjDogsList[index].ID == objDogsToUpdate.ID)
                {
                   
                    ObjDogsList[index].PedigreeNumber = objDogsToUpdate.PedigreeNumber;
                    ObjDogsList[index].Name = objDogsToUpdate.Name; 
                    ObjDogsList[index].Birthday = objDogsToUpdate.Birthday;
                    ObjDogsList[index].Gender = objDogsToUpdate.Gender;
                    ObjDogsList[index].ChipNumber = objDogsToUpdate.ChipNumber;
                    ObjDogsList[index].Color = objDogsToUpdate.Color;
                    ObjDogsList[index].FathersPedigeeNumber = objDogsToUpdate.FathersPedigeeNumber;
                    ObjDogsList[index].MothersPedigeeNumber= objDogsToUpdate.MothersPedigeeNumber;


                    IsUpdate = true;
                    break;
                }
            }
            return IsUpdate;

        }
        public bool Delete(int ID)
        {
            bool IsDelete = false;

            
            for( int index =0; index<ObjDogsList.Count; index++)
            {
                if( ObjDogsList[index].ID == ID)
                {
                    ObjDogsList.RemoveAt(index);
                    IsDelete = true;
                    break;
                }
            }

            return IsDelete;
        }
        public Dogs Search(int ID)
        {
            return ObjDogsList.FirstOrDefault(e => e.ID == ID);
        }



    }
}
