using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotTryToEscapeFormKirow.Properties;

namespace Generator
{   
    class VaccinationList
    {
        public Dictionary<String, bool> vaccinationList { get; protected set; }

        public VaccinationList() {
            vaccinationList = new Dictionary<String, bool>();
        }
        public String[] getVaccine()
        {
            return vaccinationList.Keys.ToArray();
        }
    }
    class randomVCList : VaccinationList
    {
        
        String[] mainVaccin = Resources.mainVak.Split('/');
        String[] dopVaccin = Resources.dopVak.Split('/');
        Random random = new Random();

        public randomVCList() : base()
        {
            vaccinationList.Clear();
            Generate();
        }

        public void Generate()
        {
            foreach (var s in mainVaccin)
            {
                vaccinationList[s] = true;
            }
            for (int i = 0, randLen = random.Next(1, dopVaccin.Length + 1); i < randLen; i++)
            {
                int r = random.Next(0, dopVaccin.Length);
                String s = dopVaccin[r];
                //while (vaccinationList.ContainsKey(s))
                    //s = dopVaccin[r];

                vaccinationList[s] = true;
                
            }

        }
    }
}
