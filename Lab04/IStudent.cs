namespace LAB04
{
    public interface IStudent : IOsobaZadanie3
    {
        public string School { get; set; }
        public string Major { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        public string GetFullNameAndSchool();
    }
}