
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBulkAvailabilityRequest
    {
        /// <summary>
        /// an array of at most 50 item(s)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkAvailabilityRequest" /> class.
        /// </summary>
        /// <param name="domains">
        /// an array of at most 50 item(s)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBulkAvailabilityRequest(
            global::System.Collections.Generic.IList<string> domains)
        {
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkAvailabilityRequest" /> class.
        /// </summary>
        public GetBulkAvailabilityRequest()
        {
        }
    }
}