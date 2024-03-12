using NotTryToEscapeFormKirow;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Generator
{
    class PasportMissGenerator : RandomPasportGenerator
    {
        public PasportMissGenerator() : base(1) { }
        public void GenerateMiss(ref Pasport p)
        {
            Name = p.Name;
            LastName = p.LastName;
            Id = p.Id;
            BornDate = p.BornDate;
            DatePasport = p.DatePasport;
            Foto = p.Foto;

            int len = MainRandom.Next(0,5);
            for(int i = 0; i < len; i++)
            {
                generate();
            }
            p = this;
        }

        private void generate() // TODO преобразовать в масссив делегатов, для избежания повторений
        {
            switch (MainRandom.Next(0, 5))
            {
                case 0:
                    Name = Names[MainRandom.Next(0, Names.Length)];
                    break;
                case 1:
                    LastName = LastNames[MainRandom.Next(0, LastNames.Length)];
                    break;
                case 2:
                    Id = MainRandom.Next(1000, 10000);
                    break;
                case 3:
                    generateBornDate();
                    break;
                case 4: 
                    DatePasport = new DateOnly(
                    MainRandom.Next(YearToday - 10, YearToday),
                    MainRandom.Next(1, MonthToday),
                    MainRandom.Next(1, DayToday)
                    ) ;
                    break;
            }
        }
    }

    class MissNVCLGenerator : NamedVaccinationList
    {   
        Random random = new Random();
        public MissNVCLGenerator() : base ()
        { 
        }
        public void GenerateMiss(ref NamedVaccinationList p)
        {
            Name = p.Name;
            LastName = p.LastName;
            BornData = p.BornData;
            Date = p.Date;
            vaccinationList = p.vaccinationList;

            int len = random.Next(0, 5);
            for (int i = 0; i < len; i++)
            {
                generate();
            }
            p = this;
        }
        private void generate()
        {
            switch (random.Next(0, 6))
            {
                case 0:
                    Name = RandomPasportGenerator.Names[random.Next(0, RandomPasportGenerator.Names.Length)];
                    break;
                case 1:
                    LastName = RandomPasportGenerator.LastNames[random.Next(0, RandomPasportGenerator.LastNames.Length)];
                    break;
                case 2:
                    generateVacin();
                    break;
                case 3: case 4: case 5:
                    int YearToday = DateTime.Now.Year;
                    Date = new DateOnly(
                    random.Next(YearToday - 10, YearToday),
                    random.Next(1, DateTime.Now.Month),
                    random.Next(1, DateTime.Now.Day)
                    );
                    break;
            }
        }

        private void generateVacin()
        {
            int len = random.Next(0, vaccinationList.Count);
            for(int i = 0; i < len; i++)
            {
                int index = random.Next(0, len - i);
                vaccinationList.RemoveAt(index);
            }
        }
    }

    class PermissionMissGenerator : OriginalPermission
    {
        Random random = new Random();
        public void GenerateMiss(ref OriginalPermission p)
        {
            Name = p.Name;
            LastName = p.LastName;
            Id = p.Id;

            int len = random.Next(0, 2);
            for (int i = 0; i < len; i++)
            {
                generate();
            }
        }

        private void generate()
        {
            
            switch(random.Next(0,3))
            {
                case 0:
                    Name = RandomPasportGenerator.Names[random.Next(0, RandomPasportGenerator.Names.Length)];
                    break;
                case 1:
                    LastName = RandomPasportGenerator.LastNames[random.Next(0, RandomPasportGenerator.LastNames.Length)];
                    break;
                case 2:
                    Id = random.Next(1000, 9999);
                    break;
            }
        }
    }
}
