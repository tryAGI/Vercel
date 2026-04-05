
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEventTypesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListEventTypesResponseType> Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventTypesResponse" /> class.
        /// </summary>
        /// <param name="types"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEventTypesResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListEventTypesResponseType> types)
        {
            this.Types = types ?? throw new global::System.ArgumentNullException(nameof(types));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventTypesResponse" /> class.
        /// </summary>
        public ListEventTypesResponse()
        {
        }
    }
}