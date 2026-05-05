
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant144Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcePercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EnforcePercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newResourceBlockingPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant144NextNewResourceBlockingPolicyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant144NextNewResourceBlockingPolicy NewResourceBlockingPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant144Next" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="mode"></param>
        /// <param name="enforcePercentage"></param>
        /// <param name="newResourceBlockingPolicy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant144Next(
            bool enabled,
            string mode,
            double enforcePercentage,
            global::Vercel.UserEventPayloadVariant144NextNewResourceBlockingPolicy newResourceBlockingPolicy)
        {
            this.Enabled = enabled;
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.EnforcePercentage = enforcePercentage;
            this.NewResourceBlockingPolicy = newResourceBlockingPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant144Next" /> class.
        /// </summary>
        public UserEventPayloadVariant144Next()
        {
        }
    }
}