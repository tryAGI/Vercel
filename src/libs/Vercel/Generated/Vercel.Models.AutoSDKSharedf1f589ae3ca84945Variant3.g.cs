
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf1f589ae3ca84945Variant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3Integration Integration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf1f589ae3ca84945Variant3TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf1f589ae3ca84945Variant3" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf1f589ae3ca84945Variant3(
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3Integration integration,
            global::Vercel.AutoSDKSharedf1f589ae3ca84945Variant3Type type)
        {
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf1f589ae3ca84945Variant3" /> class.
        /// </summary>
        public AutoSDKSharedf1f589ae3ca84945Variant3()
        {
        }

    }
}