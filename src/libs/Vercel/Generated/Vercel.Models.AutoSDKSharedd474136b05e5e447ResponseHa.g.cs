
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd474136b05e5e447ResponseHa
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd474136b05e5e447ResponseHaTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHaType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHaValue>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHaValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd474136b05e5e447ResponseHa" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd474136b05e5e447ResponseHa(
            string? key,
            global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHaType type,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHaValue>? value)
        {
            this.Key = key;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd474136b05e5e447ResponseHa" /> class.
        /// </summary>
        public AutoSDKSharedd474136b05e5e447ResponseHa()
        {
        }

    }
}