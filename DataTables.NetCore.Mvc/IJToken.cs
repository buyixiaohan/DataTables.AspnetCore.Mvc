using Newtonsoft.Json.Linq;

namespace DataTables.NetCore.Mvc
{
    /// <summary>
    /// Provides functionalities for Json
    /// </summary>
    internal interface IJToken
    {
        /// <summary>
        /// Gets the <see cref="JToken"/> of current instance
        /// </summary>
        /// <returns></returns>
        JToken ToJToken();
    }
}