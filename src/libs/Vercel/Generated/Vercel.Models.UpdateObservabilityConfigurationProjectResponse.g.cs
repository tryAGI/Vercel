
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityConfigurationProjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityConfigurationProjectResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="disabledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityConfigurationProjectResponse(
            string id,
            double? disabledAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisabledAt = disabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityConfigurationProjectResponse" /> class.
        /// </summary>
        public UpdateObservabilityConfigurationProjectResponse()
        {
        }
    }
}