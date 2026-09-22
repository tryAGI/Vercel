
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc97b32abf27d8b81QueryStringItem
    {
        /// <summary>
        /// Matcher for the entry key (header name or query key).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItemKey? Key { get; set; }

        /// <summary>
        /// Matcher for the entry value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItemValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc97b32abf27d8b81QueryStringItem" /> class.
        /// </summary>
        /// <param name="key">
        /// Matcher for the entry key (header name or query key).
        /// </param>
        /// <param name="value">
        /// Matcher for the entry value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc97b32abf27d8b81QueryStringItem(
            global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItemKey? key,
            global::Vercel.AutoSDKSharedc97b32abf27d8b81QueryStringItemValue? value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc97b32abf27d8b81QueryStringItem" /> class.
        /// </summary>
        public AutoSDKSharedc97b32abf27d8b81QueryStringItem()
        {
        }

    }
}