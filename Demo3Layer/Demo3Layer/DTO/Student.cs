using System.Data;

namespace Demo3Layer.DTO
{
    public class Student
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? ClassId { get; set; }
        public decimal? Scores { get; set; }

        public Student() { }

        public Student(DataRow row)
        {
            Id = (int)row["Id"];
            Name = row["Name"].ToString();
            Gender = (bool) row["Gender"];
            BirthDay = row["BirthDay"]!=null?DateTime.Parse(row["BirthDay"].ToString()): null;
            ClassId = (int)row["ClassId"];
            Scores = (decimal)row["Scores"];
        }
    }
}
