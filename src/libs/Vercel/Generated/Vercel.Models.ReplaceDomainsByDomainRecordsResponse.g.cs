
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplaceDomainsByDomainRecordsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RecordIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceDomainsByDomainRecordsResponse" /> class.
        /// </summary>
        /// <param name="recordIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceDomainsByDomainRecordsResponse(
            global::System.Collections.Generic.IList<string> recordIds)
        {
            this.RecordIds = recordIds ?? throw new global::System.ArgumentNullException(nameof(recordIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceDomainsByDomainRecordsResponse" /> class.
        /// </summary>
        public ReplaceDomainsByDomainRecordsResponse()
        {
        }

    }
}