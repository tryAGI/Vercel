
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
    /// </summary>
    public sealed partial class AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemFromVariant1, global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemFromVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemFromVariant1, global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemFromVariant2> From { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemToVariant1, global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemToVariant1, global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemToVariant2> To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemFromVariant1, global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemFromVariant2> from,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemToVariant1, global::Vercel.AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItemToVariant2> to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem" /> class.
        /// </summary>
        public AutoSDKShared4a88a64e6651d284ProjectsCustomAllowItem()
        {
        }

    }
}