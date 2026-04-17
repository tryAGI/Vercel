
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemFromVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemFromVariant2> From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2> To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItem(
            global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemFromVariant2> from,
            global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItemToVariant2> to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseTrustedSourcesProjectsCustomAllowItem()
        {
        }
    }
}