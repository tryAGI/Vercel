
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem
    {
        /// <summary>
        /// A set of environments, expressed as explicit slugs, a named preset, or both. At least one of `slugs` or `preset` must be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemTo To { get; set; }

        /// <summary>
        /// A set of environments, expressed as explicit slugs, a named preset, or both. At least one of `slugs` or `preset` must be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFrom From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        /// <param name="to">
        /// A set of environments, expressed as explicit slugs, a named preset, or both. At least one of `slugs` or `preset` must be set.
        /// </param>
        /// <param name="from">
        /// A set of environments, expressed as explicit slugs, a named preset, or both. At least one of `slugs` or `preset` must be set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem(
            global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemTo to,
            global::Vercel.UpdateProjectRequestTrustedSourcesProjectsCustomAllowItemFrom from)
        {
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSourcesProjectsCustomAllowItem()
        {
        }
    }
}