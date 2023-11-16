using System.CodeDom.Compiler;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using NotTryToEscapeFormKirow.Properties;

namespace Generator
{
    class Pasport
    {
        public String Name { get; protected set; }
        public String LastName { get; protected set; }
        public int Id { get; protected set; }    
        public Image Foto { get; protected set; }
        public DateOnly DatePasport { get; protected set; }
        public DateOnly BornDate { get; protected set; }

        public Pasport(String name, String lNAme, int id, Image foto, DateOnly dt, DateOnly bornDate)
        {
            Name = name; LastName = lNAme; Id = id; Foto = foto; DatePasport = dt;
            BornDate = bornDate;
        }
        protected Pasport(Pasport p) 
        {
            Name = p.Name;
            LastName = p.LastName;
            Id = p.Id;
            Foto = p.Foto;
            DatePasport = p.DatePasport;
            BornDate = p.BornDate;
        }
        public Pasport() { }
    }

    class PasportGenerator : Pasport
    {
        private Random MainRandom = new Random();
        String[] Names = Resources.Names.Split('\n');
        String[] LastNames = Resources.LastNames.Split('\n');
        String[] Patronymics;
        PasportGenerator()
        {
            Generate();
        }

        private Pasport Generate()
        {
            Name = Names[MainRandom.Next(0,Names.Length)];
            LastName = Names[MainRandom.Next(0, LastNames.Length)];
            Id = MainRandom.Next(1000, 10000);
            int YearToday = DateTime.Today.Year + 1;
            int MonthToday = DateTime.Today.Month;
            int DayToday = DateTime.Today.Day;
            
            BornDate = new DateOnly(
                MainRandom.Next(YearToday - 112, YearToday),
                MainRandom.Next(1,13),
                MainRandom.Next(1, 30)
                );
            DatePasport = new DateOnly(
                MainRandom.Next(YearToday, YearToday + 10),
                MainRandom.Next(1, MonthToday),
                MainRandom.Next(1, DayToday)
                );
            using (Bitmap bmp = new Bitmap(1000, 1000))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    using (Image img1 = Resources.Instruction1)
                        g.DrawImage(img1, 0,0);

                    using (Image img2 = Resources.Dis)
                        g.DrawImage(img2, 0, 0);
                }
                Foto = bmp;
            }
            return this;
        }
    }
}
