
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared209b2cb84e1d7219
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared3ee0b14b2005812d Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared209b2cb84e1d7219" /> class.
        /// </summary>
        /// <param name="domain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared209b2cb84e1d7219(
            global::Vercel.AutoSDKShared3ee0b14b2005812d domain)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared209b2cb84e1d7219" /> class.
        /// </summary>
        public AutoSDKShared209b2cb84e1d7219()
        {
        }

    }
}