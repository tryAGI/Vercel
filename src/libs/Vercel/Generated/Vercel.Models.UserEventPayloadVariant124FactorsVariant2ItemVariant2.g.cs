
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant124FactorsVariant2ItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant124FactorsVariant2ItemVariant2OriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant124FactorsVariant2ItemVariant2Origin Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant124FactorsVariant2ItemVariant2" /> class.
        /// </summary>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant124FactorsVariant2ItemVariant2(
            global::Vercel.UserEventPayloadVariant124FactorsVariant2ItemVariant2Origin origin)
        {
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant124FactorsVariant2ItemVariant2" /> class.
        /// </summary>
        public UserEventPayloadVariant124FactorsVariant2ItemVariant2()
        {
        }
    }
}