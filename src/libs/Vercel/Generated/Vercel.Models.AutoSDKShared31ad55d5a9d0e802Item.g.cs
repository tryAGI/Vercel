
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional overrides for the default same-env-by-slug matching. Provide explicit rules to allow cross-env access or presets. An empty array denies all access and is only allowed for the current project.
    /// </summary>
    public sealed partial class AutoSDKShared31ad55d5a9d0e802Item
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1, global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1, global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant2> From { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemToVariant1, global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemToVariant1, global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemToVariant2> To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared31ad55d5a9d0e802Item" /> class.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared31ad55d5a9d0e802Item(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant1, global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemFromVariant2> from,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemToVariant1, global::Vercel.AutoSDKShared31ad55d5a9d0e802ItemToVariant2> to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared31ad55d5a9d0e802Item" /> class.
        /// </summary>
        public AutoSDKShared31ad55d5a9d0e802Item()
        {
        }

    }
}