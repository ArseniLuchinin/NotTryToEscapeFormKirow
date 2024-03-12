using Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    class Visitor
    {
        public Pasport pasport;
        public NamedVaccinationList NVCL;
        public OriginalPermission permission;
    }

    class RandomVisitor : Visitor
    {
        PasportMissGenerator pmg = new PasportMissGenerator();
        MissNVCLGenerator vmg = new MissNVCLGenerator();
        PermissionMissGenerator pemg = new PermissionMissGenerator();
        Random r = new Random();

        public RandomVisitor(VaccinationList mainVCL)
        {   
            pasport = new RandomPasportGenerator();
            NVCL = new NamedVaccinationList(pasport, mainVCL, DateOnly.FromDateTime(DateTime.Now));
            permission = new OriginalPermission(pasport);

            generateMissInDocuments();
        }

        private void generateMissInDocuments()
        {
            int shans = 100;
            if (r.Next(0, shans) > shans / 2)
                generateMiss();
        }

        private void generateMiss()
        {
            int len = r.Next(1, 3);
            for (int i = 0; i < len; i++)
            {
                switch (r.Next(0, 4))
                {
                    case 0:
                        pmg.GenerateMiss(ref pasport);
                        break;
                    case 1:case 3:
                        vmg.GenerateMiss(ref NVCL);
                        break;
                    case 2:
                        pemg.GenerateMiss(ref permission);
                        break;
                }

            }

        }
    }
}
