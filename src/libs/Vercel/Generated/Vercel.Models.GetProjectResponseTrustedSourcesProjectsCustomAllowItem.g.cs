
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets.
    /// </summary>
    public sealed partial class GetProjectResponseTrustedSourcesProjectsCustomAllowItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2> From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2> To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseTrustedSourcesProjectsCustomAllowItem(
            global::Vercel.OneOf<global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemFromVariant2> from,
            global::Vercel.OneOf<global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.GetProjectResponseTrustedSourcesProjectsCustomAllowItemToVariant2> to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        public GetProjectResponseTrustedSourcesProjectsCustomAllowItem()
        {
        }
    }
}