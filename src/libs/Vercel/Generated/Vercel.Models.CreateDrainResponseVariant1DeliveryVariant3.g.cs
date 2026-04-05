
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainResponseVariant1DeliveryVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant1DeliveryVariant3TypeJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant1DeliveryVariant3Type Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1DeliveryVariant3" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="table"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant1DeliveryVariant3(
            string endpoint,
            string table,
            global::Vercel.CreateDrainResponseVariant1DeliveryVariant3Type type)
        {
            this.Type = type;
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1DeliveryVariant3" /> class.
        /// </summary>
        public CreateDrainResponseVariant1DeliveryVariant3()
        {
        }
    }
}