using Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    internal class Game
    {
        private VaccinationList _vcl;
        public VaccinationList VCL { get; private set; }
            
        int VCLIteration = 0;
        int VCLCount = 3;
        Visitor visitor;
        
        public Game() 
        {
            VCL = _vcl = new randomVCList();
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
            if (visitor.pasport.DatePasport.CompareTo(DateOnly.FromDateTime(DateTime.Now)) < 0 )
            {
                isValid = false;
            }
        }
        private void checkVCL()
        {
            bool isValidname = visitor.NVCL.Name == visitor.pasport.Name;
            bool isValidLName = visitor.NVCL.LastName == visitor.pasport.LastName;
            bool isValidbornDate = visitor.NVCL.BornData == visitor.pasport.BornDate;
            bool isValidDate = visitor.NVCL.Date.CompareTo( DateOnly.FromDateTime(DateTime.Now)) >= 0;

            if(!(isValidname && isValidLName && isValidbornDate && isValidDate) )
                isValid = false;

            foreach (var item in _vcl)
            {
                if (!visitor.NVCL[item])
                {
                    isValid = false;
                    break;
                }
            }
        }

        private void checkPermission()
        {
            if(!visitor.permission.stamp)
                isValid = false;
            if(visitor.permission.Name != visitor.pasport.Name || visitor.permission.LastName != visitor.pasport.LastName)
                isValid = false;
            
                if (visitor.permission.LastNameIana != "Цист" || visitor.permission.NameIana != "Яна")
                {
                    isValid = false;
                }           
        }
        public Visitor Next()
        {
            if (VCLIteration >= VCLCount)
                VCL = _vcl = new randomVCList();
            else
                VCL = null;

            visitor = new RandomVisitor(_vcl);
            VCLIteration++;
            isValid = true;
            return visitor;
        }
    }
}
