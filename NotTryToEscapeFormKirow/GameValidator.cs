using Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    internal class GameValidator
    {
        public Pasport pasport;
        public NamedVaccinationList namedVaccinationList;
        public VaccinationList vaccinationList;
        public OriginalPermission permission;
        public GameValidator(Pasport p, NamedVaccinationList NVCL, VaccinationList VCL, OriginalPermission per) 
        {
            pasport = p;
            namedVaccinationList = NVCL;
            vaccinationList = VCL;
            permission = per;
        }
        bool isValid = true;
        public bool getDataValidation()
        {
            checkPasport();
            checkVCL();
            checkPermission();

            return isValid;
        }
        private void checkPasport()
        {
            if (pasport.DatePasport.CompareTo(DateOnly.FromDateTime(DateTime.Now)) < 0 )
            {
                isValid = false;
            }
        }
        private void checkVCL()
        {
            bool isValidname = namedVaccinationList.Name == pasport.Name;
            bool isValidLName = namedVaccinationList.LastName == pasport.LastName;
            bool isValidbornDate = namedVaccinationList.BornData == pasport.BornDate;
            bool isValidDate = namedVaccinationList.Date.CompareTo( DateOnly.FromDateTime(DateTime.Now)) >= 0;

            if(!(isValidname && isValidLName && isValidbornDate && isValidDate) )
                isValid = false;

            foreach (var item in vaccinationList)
            {
                if (!namedVaccinationList[item])
                {
                    isValid = false;
                    break;
                }
            }
        }

        private void checkPermission()
        {
            if(!permission.stamp)
                isValid = false;
            if(permission.Name != pasport.Name || permission.LastName != pasport.LastName)
                isValid = false;
            
                if (permission.LastNameIana != "Цист" || permission.NameIana != "Яна")
                {
                    isValid = false;
                }
                    
        }
    }
}
