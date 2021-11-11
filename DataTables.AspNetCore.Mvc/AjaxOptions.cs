namespace DataTables.AspNetCore.Mvc
{
    /// <summary>
    /// Represents an ajax object
    /// </summary>
    internal class AjaxOptions
    {
        /// <summary>
        /// Gets or sets ajax url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ajax method
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Data property or manipulation method for table data.
        /// </summary>
        public string DataSrc { get; set; }

        /// <summary>
        /// Add or modify data submitted to the server upon an Ajax request.
        /// </summary>
        public string PostData { get; set; }
    }
}