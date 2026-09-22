
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf1f589ae3ca84945Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2App App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf1f589ae3ca84945Variant2TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf1f589ae3ca84945Variant2" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf1f589ae3ca84945Variant2(
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2App app,
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant2Type type)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf1f589ae3ca84945Variant2" /> class.
        /// </summary>
        public AutoSDKSharedf1f589ae3ca84945Variant2()
        {
        }

    }
}