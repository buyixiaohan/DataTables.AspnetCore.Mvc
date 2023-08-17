using Microsoft.AspNetCore.Mvc;

namespace DataTables.NetCore.Mvc.Binder
{
    /// <summary>
    /// Modelbinder for <see cref="DataTablesRequest"/>
    /// </summary>
    public class DataTablesRequestAttribute : ModelBinderAttribute
    {
        /// <summary>
        /// Initialize a new instance of <see cref="DataTablesRequestAttribute"/>
        /// </summary>
        public DataTablesRequestAttribute() : base(typeof(DataTablesRequestModelBinder))
        {
        }
    }
}