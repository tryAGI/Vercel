
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public sealed partial class AuthUserResourceConfigBuildQueue
    {
        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserResourceConfigBuildQueueConfigurationJsonConverter))]
        public global::Vercel.AuthUserResourceConfigBuildQueueConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigBuildQueue" /> class.
        /// </summary>
        /// <param name="configuration">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserResourceConfigBuildQueue(
            global::Vercel.AuthUserResourceConfigBuildQueueConfiguration? configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigBuildQueue" /> class.
        /// </summary>
        public AuthUserResourceConfigBuildQueue()
        {
        }
    }
}