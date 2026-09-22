
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda0db2c4b058f2749Variant3
    {
        /// <summary>
        /// Event type - must be "schedule/v1beta" (REQUIRED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda0db2c4b058f2749Variant3TypeJsonConverter))]
        public global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda0db2c4b058f2749Variant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type - must be "schedule/v1beta" (REQUIRED)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda0db2c4b058f2749Variant3(
            global::Vercel.AutoSDKShareda0db2c4b058f2749Variant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda0db2c4b058f2749Variant3" /> class.
        /// </summary>
        public AutoSDKShareda0db2c4b058f2749Variant3()
        {
        }

    }
}