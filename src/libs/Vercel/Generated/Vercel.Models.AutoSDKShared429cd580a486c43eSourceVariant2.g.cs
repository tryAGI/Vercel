
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CI sentinel — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class AutoSDKShared429cd580a486c43eSourceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared429cd580a486c43eSourceVariant2OriginJsonConverter))]
        public global::Vercel.AutoSDKShared429cd580a486c43eSourceVariant2Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared429cd580a486c43eSourceVariant2SubKindJsonConverter))]
        public global::Vercel.AutoSDKShared429cd580a486c43eSourceVariant2SubKind SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared429cd580a486c43eSourceVariant2" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared429cd580a486c43eSourceVariant2(
            global::Vercel.AutoSDKShared429cd580a486c43eSourceVariant2Origin origin,
            global::Vercel.AutoSDKShared429cd580a486c43eSourceVariant2SubKind subKind)
        {
            this.Origin = origin;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared429cd580a486c43eSourceVariant2" /> class.
        /// </summary>
        public AutoSDKShared429cd580a486c43eSourceVariant2()
        {
        }

    }
}