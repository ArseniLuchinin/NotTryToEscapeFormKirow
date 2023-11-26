using System.CodeDom.Compiler;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using NotTryToEscapeFormKirow;
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
        public PasportGenerator()
        {
            Image a = Resources.Eyes;
            Generate();
        }

        private Pasport Generate()
        {
            Name = Names[MainRandom.Next(0,Names.Length)];
            LastName = LastNames[MainRandom.Next(0, LastNames.Length)];
            Id = MainRandom.Next(1000, 10000);
            int YearToday = DateTime.Today.Year + 1;
            int MonthToday = DateTime.Today.Month;
            int DayToday = DateTime.Today.Day;
            
            BornDate = new DateOnly(
                MainRandom.Next(YearToday - 98, YearToday - 18),
                MainRandom.Next(1,13),
                MainRandom.Next(1, 30)
                );

            DatePasport = new DateOnly(
                MainRandom.Next(YearToday, YearToday + 10),
                MainRandom.Next(1, MonthToday),
                MainRandom.Next(1, DayToday)
                );
            generateFoto();
            
            return this;
        }
        private void generateFoto()
        {
            Bitmap bmp = new Bitmap(170, 200);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            generateEyes(g, MainRandom);
            generateMonth(g, MainRandom);
            generateNoys(g, MainRandom);
            
            Foto = bmp;
        }

        private void generateEyes(Graphics g, Random r)
        {
            int i = r.Next(0, 3);
            int j = r.Next(0, 2);
            int W = Resources.Eyes.Width / 3, H = Resources.Eyes.Height / 2;
            Rectangle selection = new Rectangle(
                new Point(
                    (170 / 2) - W / 2,
                    (2 * 200 / 7) - (H / 2)),
                new Size(W, H)
                );

            Point startPoint = new Point(
                W * i,
                H * j
                );
            Rectangle selectionEyes = new Rectangle(
                startPoint,
                new Size(W, H)
                );
            Image Eyes = Resources.Eyes.Clone(selectionEyes, Resources.Eyes.PixelFormat);

            g.DrawImage(Eyes, selection);
        }

        private void generateMonth(Graphics g, Random r)
        {
            int i = r.Next(0, 5);
            int W = Resources.Months.Width / 5, H = Resources.Months.Height;
            Rectangle selection = new Rectangle(
                new Point(
                    (170 / 2) - W / 2,
                    (4 * 200 / 5) - (H / 2)),
                new Size(W, H)
                );

            Point startPoint = new Point(
                W * i,
                0
                );
            Rectangle selectionEyes = new Rectangle(
                startPoint,
                new Size(W, H)
                );
            Image Month = Resources.Months.Clone(selectionEyes, Resources.Months.PixelFormat);

            g.DrawImage(Month, selection);
        }

        private void generateNoys(Graphics g, Random r)
        {
            int i = r.Next(0, 5);
            int W = Resources.Noses.Width, H = Resources.Noses.Height / 5;
            Rectangle selection = new Rectangle(
                new Point(
                    (170 / 2) - W / 2,
                    (4 * 200 / 7) - (H / 2)),
                new Size(W, H)
                );

            Point startPoint = new Point(
                0,
                H * i
                );
            Rectangle selectionEyes = new Rectangle(
                startPoint,
                new Size(W, H)
                );
            Image Noys = Resources.Noses.Clone(selectionEyes, Resources.Noses.PixelFormat);

            g.DrawImage(Noys, selection);
        }
    }
}
