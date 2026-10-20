
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project-defined CI requirement; its selection is frozen on each check run.
    /// </summary>
    public sealed partial class AutoSDKSharede3c00aaf9d3a15beSourceVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant5OriginJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1, global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant2, global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1, global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant2, global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3> Selection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKindJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant5" /> class.
        /// </summary>
        /// <param name="selection"></param>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant5(
            global::Vercel.OneOf<global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant1, global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant2, global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3> selection,
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5Origin origin,
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind subKind)
        {
            this.Origin = origin;
            this.Selection = selection;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant5" /> class.
        /// </summary>
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant5()
        {
        }

    }
}