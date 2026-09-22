
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedb13a6bca2ca06cfe
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drains")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9e8f7cd3a066bfd9JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9e8f7cd3a066bfd9 Drains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb13a6bca2ca06cfe" /> class.
        /// </summary>
        /// <param name="drains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb13a6bca2ca06cfe(
            global::Vercel.AutoSDKShared9e8f7cd3a066bfd9 drains)
        {
            this.Drains = drains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb13a6bca2ca06cfe" /> class.
        /// </summary>
        public AutoSDKSharedb13a6bca2ca06cfe()
        {
        }

    }
}