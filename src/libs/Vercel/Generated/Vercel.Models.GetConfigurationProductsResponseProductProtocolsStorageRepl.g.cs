
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductProtocolsStorageRepl
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
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsReadOnlyMode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsReadOnlyMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("welcomeMessage")]
        public string? WelcomeMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsStorageRepl" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="supportsReadOnlyMode"></param>
        /// <param name="welcomeMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductProtocolsStorageRepl(
            bool enabled,
            bool supportsReadOnlyMode,
            string? welcomeMessage)
        {
            this.Enabled = enabled;
            this.SupportsReadOnlyMode = supportsReadOnlyMode;
            this.WelcomeMessage = welcomeMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsStorageRepl" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductProtocolsStorageRepl()
        {
        }
    }
}