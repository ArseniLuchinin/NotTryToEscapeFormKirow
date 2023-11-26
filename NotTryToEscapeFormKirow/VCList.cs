using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NotTryToEscapeFormKirow.Properties;

namespace Generator
{   
    class VaccinationList : IEnumerable
    {
        public List<String> vaccinationList { get; protected set; }
        public int Lenght { get; protected set; }

        public VaccinationList() {
            vaccinationList = new List<String>();
        }
        public String[] getVaccine()
        {
            return vaccinationList.ToArray();
        }
        
        public String this [int index]
        {
            get
            {
                return vaccinationList[index];
            }
        }
        public bool this[String Vaccine]
        {
            get
            {
                return vaccinationList.Contains(Vaccine);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public VCLenumerator GetEnumerator()
        {
            return new VCLenumerator(vaccinationList);
        }

    }
    class VCLenumerator : IEnumerator<String>
    {
        public List<String> vaccinationList;
        int position;
        public VCLenumerator(List<string> vaccinationList)
        {
            this.vaccinationList = vaccinationList;
            Reset();
        }
        public bool MoveNext()
        {
            position++;
            return (position < vaccinationList.Count);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose() { }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public String Current
        {
            get
            {
                try
                {
                    return vaccinationList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
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
            vaccinationList = mainVaccin.ToList();
            
            Lenght = random.Next(1, dopVaccin.Length + 1);
            for (int i = 0; i < Lenght; i++)
                vaccinationList.Add(generateVaccine(i));

            Lenght += 4;

        }
        private String generateVaccine(int i)
        {
            int end = dopVaccin.Length - i;
            int r = random.Next(0, end);
            swapInDpoWVList(r, end - 1);
            return dopVaccin[end - 1];
        }
        private void swapInDpoWVList(int a, int b)
        {
            String tmp = dopVaccin[a];
            dopVaccin[a] = dopVaccin[b];
            dopVaccin[b] = tmp;
        }
    }
}
