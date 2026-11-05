
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedab64e9622c80dc17ResponseMissingItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedab64e9622c80dc17ResponseMissingItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItemValue>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItemValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab64e9622c80dc17ResponseMissingItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedab64e9622c80dc17ResponseMissingItem(
            global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItemType type,
            string? key,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItemValue>? value)
        {
            this.Key = key;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab64e9622c80dc17ResponseMissingItem" /> class.
        /// </summary>
        public AutoSDKSharedab64e9622c80dc17ResponseMissingItem()
        {
        }

    }
}