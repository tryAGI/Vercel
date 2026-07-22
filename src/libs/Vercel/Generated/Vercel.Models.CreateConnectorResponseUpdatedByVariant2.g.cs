
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal that most recently mutated the connector. Same shape as {@link createdBy} but tracks the most recent updater, not the original creator. At create time the two fields point at the same principal; they diverge on the first subsequent update.
    /// </summary>
    public sealed partial class CreateConnectorResponseUpdatedByVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorResponseUpdatedByVariant2TypeJsonConverter))]
        public global::Vercel.CreateConnectorResponseUpdatedByVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateConnectorResponseUpdatedByVariant2Environment?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.CreateConnectorResponseUpdatedByVariant2Environment?> Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseUpdatedByVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environment"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponseUpdatedByVariant2(
            string id,
            global::Vercel.OneOf<string, global::Vercel.CreateConnectorResponseUpdatedByVariant2Environment?> environment,
            global::Vercel.CreateConnectorResponseUpdatedByVariant2Type type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponseUpdatedByVariant2" /> class.
        /// </summary>
        public CreateConnectorResponseUpdatedByVariant2()
        {
        }

    }
}