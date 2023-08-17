using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace DataTables.NetCore.Mvc
{
    /// <summary>
    /// Represents the grid datasource
    /// </summary>
    public class GridDataSourceBuilder : IJToken
    {
        private AjaxBuilder ajaxBuilder;

        /// <summary>
        /// Initialize a new instance of <see cref="AjaxBuilder"/>
        /// </summary>
        /// <returns></returns>
        public AjaxBuilder Ajax()
        {
            this.ajaxBuilder = new AjaxBuilder();
            return this.ajaxBuilder;
        }

        /// <summary>
        /// Gets the <see cref="JToken"/> of current instance
        /// </summary>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public JToken ToJToken()
        {
            return this.ajaxBuilder?.ToJToken();
        }
    }
}