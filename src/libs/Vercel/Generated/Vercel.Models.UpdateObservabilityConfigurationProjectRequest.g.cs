
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityConfigurationProjectRequest
    {
        /// <summary>
        /// Whether Observability Plus should be disabled for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityConfigurationProjectRequest" /> class.
        /// </summary>
        /// <param name="disabled">
        /// Whether Observability Plus should be disabled for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityConfigurationProjectRequest(
            bool disabled)
        {
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityConfigurationProjectRequest" /> class.
        /// </summary>
        public UpdateObservabilityConfigurationProjectRequest()
        {
        }
    }
}