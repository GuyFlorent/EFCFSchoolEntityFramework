namespace EFCFSchool.Model
{
    public class Room
    {

        public int Id { get; set; }
        public string Number { get; set; }
        public int SchoolId { get; set; } //school sera en clés secondaire  en colonne
    }
}