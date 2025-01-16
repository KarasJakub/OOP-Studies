namespace LAB02
{
    internal class Exercise3
    {
        public static void Run()
        {
             Student student = new Student("Jan", "Kowalski", 22, "w70844");
             
             Student2 student2 = new Student2("Jan", "Nowak");
             student2.AddGrades(4);
             student2.AddGrades(3);
             student2.AddGrades(3);
             student2.AddGrades(5);
             
             student.View();
             student.ViewStudent();
        }
    }
}