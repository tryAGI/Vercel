
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBulkAvailabilityResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetBulkAvailabilityResponseResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkAvailabilityResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBulkAvailabilityResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetBulkAvailabilityResponseResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBulkAvailabilityResponse" /> class.
        /// </summary>
        public GetBulkAvailabilityResponse()
        {
        }
    }
}