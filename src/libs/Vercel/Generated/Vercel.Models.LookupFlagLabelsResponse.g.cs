
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LookupFlagLabelsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.LookupFlagLabelsResponseDataItem> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.LookupFlagLabelsResponseMissingItem> Missing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupFlagLabelsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="missing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LookupFlagLabelsResponse(
            global::System.Collections.Generic.IList<global::Vercel.LookupFlagLabelsResponseDataItem> data,
            global::System.Collections.Generic.IList<global::Vercel.LookupFlagLabelsResponseMissingItem> missing)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Missing = missing ?? throw new global::System.ArgumentNullException(nameof(missing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupFlagLabelsResponse" /> class.
        /// </summary>
        public LookupFlagLabelsResponse()
        {
        }

    }
}