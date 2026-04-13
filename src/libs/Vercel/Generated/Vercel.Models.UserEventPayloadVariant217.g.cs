
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant217
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProvider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProviderGroupDescriptor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitProviderGroupDescriptor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitScope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant217" /> class.
        /// </summary>
        /// <param name="gitProvider"></param>
        /// <param name="gitProviderGroupDescriptor"></param>
        /// <param name="gitScope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant217(
            string gitProvider,
            string gitProviderGroupDescriptor,
            string gitScope)
        {
            this.GitProvider = gitProvider ?? throw new global::System.ArgumentNullException(nameof(gitProvider));
            this.GitProviderGroupDescriptor = gitProviderGroupDescriptor ?? throw new global::System.ArgumentNullException(nameof(gitProviderGroupDescriptor));
            this.GitScope = gitScope ?? throw new global::System.ArgumentNullException(nameof(gitScope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant217" /> class.
        /// </summary>
        public UserEventPayloadVariant217()
        {
        }
    }
}