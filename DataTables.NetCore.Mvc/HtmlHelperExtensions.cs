using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataTables.NetCore.Mvc
{
    /// <summary>
    /// Provides HtmlHelper extensions
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Extension to controls
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static ControlBuilder<TModel> Ext<TModel>(this IHtmlHelper<TModel> htmlHelper) where TModel : class
        {
            return new ControlBuilder<TModel>(htmlHelper);
        }
    }
}