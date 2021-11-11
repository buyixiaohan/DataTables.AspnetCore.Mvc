using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace DataTables.AspNetCore.Mvc
{
    /// <summary>
    /// Represents the language options
    /// </summary>
    public class LanguageBuilder : IJToken
    {
        private LanguageOptions lg;

        /// <summary>
        /// Initialize a new instance of <see cref="LanguageBuilder"/>
        /// </summary>
        public LanguageBuilder()
        {
            this.lg = new LanguageOptions();
        }

        /// <summary>
        /// Load language information from remote file
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public LanguageBuilder Url(string url)
        {
            this.lg.Url = url;
            return this;
        }

        /// <summary>
        /// Gets the <see cref="JToken"/> of current instance
        /// </summary>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public JToken ToJToken()
        {
            JObject jObject = new JObject();
            if (!string.IsNullOrEmpty(this.lg.Url)) jObject.Add("url", new JValue(this.lg.Url));
            return jObject;
        }
    }
}