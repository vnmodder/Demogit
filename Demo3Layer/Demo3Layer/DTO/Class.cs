using System.Data;

namespace Demo3Layer.DTO
{
    public class Class
    {
        public int? Id { get; set; }
        public string? ClassName { get; set; }

        public Class(int? id, string className)
        {
            Id = id;
            ClassName = className;
        }

        public Class(DataRow row)
        {
            Id = (int)row["Id"];
            ClassName = row["ClassName"].ToString();
        }
    }
}
