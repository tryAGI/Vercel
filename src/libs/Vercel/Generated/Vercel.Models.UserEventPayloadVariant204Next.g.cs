
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant204Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public string? Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationProduction")]
        public string? ExpirationProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationCanceled")]
        public string? ExpirationCanceled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationErrored")]
        public string? ExpirationErrored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant204Next" /> class.
        /// </summary>
        /// <param name="expiration"></param>
        /// <param name="expirationProduction"></param>
        /// <param name="expirationCanceled"></param>
        /// <param name="expirationErrored"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant204Next(
            string? expiration,
            string? expirationProduction,
            string? expirationCanceled,
            string? expirationErrored)
        {
            this.Expiration = expiration;
            this.ExpirationProduction = expirationProduction;
            this.ExpirationCanceled = expirationCanceled;
            this.ExpirationErrored = expirationErrored;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant204Next" /> class.
        /// </summary>
        public UserEventPayloadVariant204Next()
        {
        }
    }
}