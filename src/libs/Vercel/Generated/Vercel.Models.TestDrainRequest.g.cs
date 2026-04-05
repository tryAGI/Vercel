
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestDrainRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.TestDrainRequestSchemas2> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.TestDrainRequestDeliveryVariant1, global::Vercel.TestDrainRequestDeliveryVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.TestDrainRequestDeliveryVariant1, global::Vercel.TestDrainRequestDeliveryVariant2> Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDrainRequest" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="delivery"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDrainRequest(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.TestDrainRequestSchemas2> schemas,
            global::Vercel.OneOf<global::Vercel.TestDrainRequestDeliveryVariant1, global::Vercel.TestDrainRequestDeliveryVariant2> delivery)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDrainRequest" /> class.
        /// </summary>
        public TestDrainRequest()
        {
        }
    }
}