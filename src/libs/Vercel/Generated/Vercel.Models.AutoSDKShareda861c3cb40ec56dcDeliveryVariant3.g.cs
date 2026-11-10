
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dcDeliveryVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Table { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcDeliveryVariant3TypeJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcDeliveryVariant3" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="table"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda861c3cb40ec56dcDeliveryVariant3(
            string endpoint,
            string table,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcDeliveryVariant3Type type)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcDeliveryVariant3" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dcDeliveryVariant3()
        {
        }

    }
}