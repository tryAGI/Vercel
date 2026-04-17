
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant290
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Vulnerabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ProtectionEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectedProjectCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProtectedProjectCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant290" /> class.
        /// </summary>
        /// <param name="vulnerabilities"></param>
        /// <param name="protectionEnabled"></param>
        /// <param name="protectedProjectCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant290(
            global::System.Collections.Generic.IList<string> vulnerabilities,
            bool protectionEnabled,
            double protectedProjectCount)
        {
            this.Vulnerabilities = vulnerabilities ?? throw new global::System.ArgumentNullException(nameof(vulnerabilities));
            this.ProtectionEnabled = protectionEnabled;
            this.ProtectedProjectCount = protectedProjectCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant290" /> class.
        /// </summary>
        public UserEventPayloadVariant290()
        {
        }
    }
}