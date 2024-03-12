using Generator;

namespace NotTryToEscapeFormKirow
{   
    class NamedVaccinationList : VaccinationList
    {
        public String Name { get; protected set; }
        public String LastName { get; protected set; }
        public DateOnly BornData { get; protected set; }
        public DateOnly Date { get; protected set; }

        public NamedVaccinationList(Pasport p, VaccinationList vcl, DateOnly date)
        {
            Name = p.Name;
            LastName = p.LastName;
            BornData = p.BornDate;
            Date = date;
            vaccinationList = vcl.vaccinationList;
        }
        protected NamedVaccinationList() { }
    }

    partial class FormNamedVCList : FormVaccinationList
    {
        public FormNamedVCList() : base()
        {
            InitializeComponent();
        }
        public void setInfo(NamedVaccinationList NVCL)
        {
            FormName.Text = NVCL.Name;
            FormLastName.Left = FormName.Left + FormName.Size.Width;
            FormLastName.Text = NVCL.LastName;
            BornDate.Text = NVCL.BornData.ToString();
            BornDateLabel.Left = BornDate.Left + BornDate.Size.Width;
            Date.Text = NVCL.Date.ToString();
            setVCList(NVCL);
        }
    }
}
