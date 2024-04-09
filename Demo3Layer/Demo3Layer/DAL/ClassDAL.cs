using Demo3Layer.DTO;
using System.Data;

namespace Demo3Layer.DAL
{
    public class ClassDAL
    {
        public DataTable GetAllClass()
        {
            var query = "SELECT * FROM [CLASS]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddClass(Class data){
            var query = $"INSERT INTO [CLASS] (ClassName) VALUES (N'{data.ClassName}')";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteClass(int id)
        {
            var query = $"DELETE [CLASS] WHERE Id = {id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateClass(Class data)
        {
            var query = $"UPDATE [CLASS] SET ClassName = N'{data.ClassName}' WHERE Id = {data.Id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
