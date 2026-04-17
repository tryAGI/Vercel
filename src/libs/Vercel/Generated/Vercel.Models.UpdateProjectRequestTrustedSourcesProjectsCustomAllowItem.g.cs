
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem
    {
        /// <summary>
        /// A set of environments, either as explicit slugs or a named preset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2> To { get; set; }

        /// <summary>
        /// A set of environments, either as explicit slugs or a named preset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2> From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        /// <param name="to">
        /// A set of environments, either as explicit slugs or a named preset
        /// </param>
        /// <param name="from">
        /// A set of environments, either as explicit slugs or a named preset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem(
            global::Vercel.OneOf<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemToVariant2> to,
            global::Vercel.OneOf<global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFromVariant2> from)
        {
            this.To = to;
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem()
        {
        }
    }
}