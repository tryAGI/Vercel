
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal that most recently mutated the connector. Same shape as {@link createdBy} but tracks the most recent updater, not the original creator. At create time the two fields point at the same principal; they diverge on the first subsequent update.
    /// </summary>
    public sealed partial class ConnectConnectorCreateResultUpdatedByVariant1
    {
        /// <summary>
        /// Principal kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant1TypeJsonConverter))]
        public global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type Type { get; set; }

        /// <summary>
        /// Vercel user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateResultUpdatedByVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Vercel user ID.
        /// </param>
        /// <param name="type">
        /// Principal kind.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateResultUpdatedByVariant1(
            string id,
            global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateResultUpdatedByVariant1" /> class.
        /// </summary>
        public ConnectConnectorCreateResultUpdatedByVariant1()
        {
        }

    }
}