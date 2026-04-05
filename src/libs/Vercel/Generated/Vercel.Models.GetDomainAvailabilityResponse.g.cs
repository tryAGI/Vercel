
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDomainAvailabilityResponse
    {
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
        /// Initializes a new instance of the <see cref="GetDomainAvailabilityResponse" /> class.
        /// </summary>
        /// <param name="available"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainAvailabilityResponse(
            bool available)
        {
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainAvailabilityResponse" /> class.
        /// </summary>
        public GetDomainAvailabilityResponse()
        {
        }
    }
}