using Demo3Layer.DAL;
using Demo3Layer.DTO;
using System.Data;

namespace Demo3Layer.BUS
{
    public class ClassBUS
    {
        private readonly ClassDAL _classDAL;

        public ClassBUS()
        {
            _classDAL = new ClassDAL();
        }

        /// <summary>
        /// Gets all class.
        /// </summary>
        /// <returns></returns>
        public List<Class> GetAllClass()
        {
            var list = new List<Class>();
            var results = _classDAL.GetAllClass();
            foreach (var result in results.Rows)
            {
                list.Add(new((DataRow) result));
            }
            return list;
        }

        /// <summary>
        /// Updates the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public bool Update(Class data)
        { 
            if(data == null || string.IsNullOrEmpty(data.ClassName) || data.Id == null)
            {
                return false;
            }

            return _classDAL.UpdateClass(data);
        }

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public bool Add(Class data)
        {
            if (data == null || string.IsNullOrEmpty(data.ClassName))
            {
                return false;
            }

            return _classDAL.AddClass(data);
        }

        /// <summary>
        /// Delects the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return _classDAL.DeleteClass(id);
        }
    }
}
