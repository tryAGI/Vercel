
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal that originally created the connector — either a Vercel user (interactive dashboard / CLI flow) or a Vercel deployment (OIDC-authenticated project, used by runtime auto-provisioning). See {@link ConnexPrincipal}. Optional: pre-existing rows from before this shape was introduced may carry no attribution at all.
    /// </summary>
    public sealed partial class ConnectConnectorCreatedByVariant2
    {
        /// <summary>
        /// Principal kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2TypeJsonConverter))]
        public global::Vercel.ConnectConnectorCreatedByVariant2Type Type { get; set; }

        /// <summary>
        /// Vercel project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deployment environment of the project principal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorCreatedByVariant2Environment?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreatedByVariant2Environment?> Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreatedByVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Vercel project ID.
        /// </param>
        /// <param name="environment">
        /// Deployment environment of the project principal.
        /// </param>
        /// <param name="type">
        /// Principal kind.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreatedByVariant2(
            string id,
            global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreatedByVariant2Environment?> environment,
            global::Vercel.ConnectConnectorCreatedByVariant2Type type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreatedByVariant2" /> class.
        /// </summary>
        public ConnectConnectorCreatedByVariant2()
        {
        }

    }
}