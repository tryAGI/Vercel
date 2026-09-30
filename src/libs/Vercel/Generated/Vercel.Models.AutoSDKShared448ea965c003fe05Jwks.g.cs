
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Inline authorization server JSON Web Key Set.
    /// </summary>
    public sealed partial class AutoSDKShared448ea965c003fe05Jwks
    {
        /// <summary>
        /// JSON Web Keys published by the authorization server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared448ea965c003fe05JwksKey> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared448ea965c003fe05Jwks" /> class.
        /// </summary>
        /// <param name="keys">
        /// JSON Web Keys published by the authorization server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared448ea965c003fe05Jwks(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared448ea965c003fe05JwksKey> keys)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared448ea965c003fe05Jwks" /> class.
        /// </summary>
        public AutoSDKShared448ea965c003fe05Jwks()
        {
        }

    }
}