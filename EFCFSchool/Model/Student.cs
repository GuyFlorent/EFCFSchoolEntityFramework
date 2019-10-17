namespace EFCFSchool.Model
{
    public class Student
    {
        public int Id{ get; set; }
        public string Fisrtname { get; set; }
        public string Lastname { get; set; }

        public int TeacherId{ get; set; }// clés secondaire
        // public int? pour dire queles student peuven,t avoir comme clé etrangere teachear null
    }
}