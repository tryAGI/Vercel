
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllChecksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetAllChecksResponseCheck> Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllChecksResponse" /> class.
        /// </summary>
        /// <param name="checks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllChecksResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetAllChecksResponseCheck> checks)
        {
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllChecksResponse" /> class.
        /// </summary>
        public GetAllChecksResponse()
        {
        }
    }
}