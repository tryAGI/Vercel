
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal that most recently mutated the connector. Same shape as {@link createdBy} but tracks the most recent updater, not the original creator. At create time the two fields point at the same principal; they diverge on the first subsequent update.
    /// </summary>
    public sealed partial class ConnectConnectorCreateResultUpdatedByVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?> Environment { get; set; }

        /// <summary>
        /// Vercel project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Principal kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant3TypeJsonConverter))]
        public global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateResultUpdatedByVariant3" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="id">
        /// Vercel project ID.
        /// </param>
        /// <param name="type">
        /// Principal kind.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateResultUpdatedByVariant3(
            global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?> environment,
            string id,
            global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type type)
        {
            this.Environment = environment;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateResultUpdatedByVariant3" /> class.
        /// </summary>
        public ConnectConnectorCreateResultUpdatedByVariant3()
        {
        }

    }
}