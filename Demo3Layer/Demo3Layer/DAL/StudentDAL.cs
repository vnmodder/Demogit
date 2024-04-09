using Demo3Layer.DTO;
using System.Data;

namespace Demo3Layer.DAL
{
    public class StudentDAL
    {
        public DataTable GetAllStudent()
        {
            var query = "SELECT * FROM [STUDENT]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetStudentsByClassId(int classId)
        {
            var query = "SELECT * FROM [STUDENT] ";
            if(classId > 0)
            {
                query += $"WHERE ClassId ={classId}";
            }
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddStudent(Student data)
        {
            var query = $"INSERT INTO [STUDENT] ([Name], Gender, BirthDay, ClassId, Scores)" +
                        $" VALUES (N'{data.Name}', {(data.Gender==true?1:0)}, '{data.BirthDay:yyyy-MM-dd}'," +
                        $" {data.ClassId}, {data.Scores})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteStudent(int id)
        {
            var query = $"DELETE [STUDENT] WHERE Id = {id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateStudent(Student data)
        {
            var query = $"UPDATE [STUDENT] SET " +
                        $"Name = N'{data.Name}' , Gender = {(data.Gender == true ? 1 : 0)}, " +
                        $"BirthDay = '{data.BirthDay:yyyy-MM-dd}', " +
                        $"ClassId = {data.ClassId}, Scores = {data.Scores} WHERE Id = {data.Id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
