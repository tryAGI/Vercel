
#nullable enable

namespace Vercel
{
    /// <summary>
    /// data cache settings
    /// </summary>
    public sealed partial class AuthUserDataCache
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excessBillingEnabled")]
        public bool? ExcessBillingEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDataCache" /> class.
        /// </summary>
        /// <param name="excessBillingEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserDataCache(
            bool? excessBillingEnabled)
        {
            this.ExcessBillingEnabled = excessBillingEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDataCache" /> class.
        /// </summary>
        public AuthUserDataCache()
        {
        }
    }
}