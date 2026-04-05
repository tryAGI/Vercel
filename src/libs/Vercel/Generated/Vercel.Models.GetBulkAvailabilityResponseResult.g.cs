
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBulkAvailabilityResponseResult
    {
        /// <summary>
        /// A valid domain name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkAvailabilityResponseResult" /> class.
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="available"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBulkAvailabilityResponseResult(
            string domain,
            bool available)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkAvailabilityResponseResult" /> class.
        /// </summary>
        public GetBulkAvailabilityResponseResult()
        {
        }
    }
}