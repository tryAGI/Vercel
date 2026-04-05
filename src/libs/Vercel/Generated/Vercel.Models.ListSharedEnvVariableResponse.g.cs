
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSharedEnvVariableResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListSharedEnvVariableResponseDataItem> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="ListSharedEnvVariableResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pagination">
        /// This object contains information related to the pagination of the current request, including the necessary parameters to get the next or previous page of data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSharedEnvVariableResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListSharedEnvVariableResponseDataItem> data,
            global::Vercel.Pagination pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSharedEnvVariableResponse" /> class.
        /// </summary>
        public ListSharedEnvVariableResponse()
        {
        }
    }
}