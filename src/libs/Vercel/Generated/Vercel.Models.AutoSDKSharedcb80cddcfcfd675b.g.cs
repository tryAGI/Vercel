
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedcb80cddcfcfd675b
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drains")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared7dc1a28efb1dd3cfJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7dc1a28efb1dd3cf Drains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcb80cddcfcfd675b" /> class.
        /// </summary>
        /// <param name="drains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedcb80cddcfcfd675b(
            global::Vercel.AutoSDKShared7dc1a28efb1dd3cf drains)
        {
            this.Drains = drains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedcb80cddcfcfd675b" /> class.
        /// </summary>
        public AutoSDKSharedcb80cddcfcfd675b()
        {
        }

    }
}