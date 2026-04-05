
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Successful response retrieving a list of paginated DNS records.
    /// </summary>
    public sealed partial class GetRecordsResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRecordsResponseVariant3Record> Records { get; set; }

        /// <summary>
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordsResponseVariant3" /> class.
        /// </summary>
        /// <param name="records"></param>
        /// <param name="pagination">
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRecordsResponseVariant3(
            global::System.Collections.Generic.IList<global::Vercel.GetRecordsResponseVariant3Record> records,
            global::Vercel.Pagination pagination)
        {
            this.Records = records ?? throw new global::System.ArgumentNullException(nameof(records));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordsResponseVariant3" /> class.
        /// </summary>
        public GetRecordsResponseVariant3()
        {
        }
    }
}