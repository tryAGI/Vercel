
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Project-defined CI requirement; its selection is frozen on each check run.
    /// </summary>
    public sealed partial class AutoSDKShared12773eaec07789a9SourceVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared12773eaec07789a9SourceVariant5OriginJsonConverter))]
        public global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant1, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant1, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4> Selection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared12773eaec07789a9SourceVariant5SubKindJsonConverter))]
        public global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SubKind SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared12773eaec07789a9SourceVariant5" /> class.
        /// </summary>
        /// <param name="selection"></param>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared12773eaec07789a9SourceVariant5(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant1, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant3, global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant4> selection,
            global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5Origin origin,
            global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SubKind subKind)
        {
            this.Origin = origin;
            this.Selection = selection;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared12773eaec07789a9SourceVariant5" /> class.
        /// </summary>
        public AutoSDKShared12773eaec07789a9SourceVariant5()
        {
        }

    }
}