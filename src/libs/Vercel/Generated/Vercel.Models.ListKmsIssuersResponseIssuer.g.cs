
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListKmsIssuersResponseIssuer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListKmsIssuersResponseIssuerAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListKmsIssuersResponseIssuerAlgorithm Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListKmsIssuersResponseIssuerOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListKmsIssuersResponseIssuerOrigin Origin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        public string? ManagedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimsSchema")]
        public object? ClaimsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListKmsIssuersResponseIssuerSigningKey> SigningKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.ListKmsIssuersResponseIssuerPolicieVariant1, global::Vercel.ListKmsIssuersResponseIssuerPolicieVariant2>> Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKmsIssuersResponseIssuer" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="name"></param>
        /// <param name="algorithm"></param>
        /// <param name="origin"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="signingKeys"></param>
        /// <param name="policies"></param>
        /// <param name="managedBy"></param>
        /// <param name="claimsSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListKmsIssuersResponseIssuer(
            string id,
            string ownerId,
            string name,
            global::Vercel.ListKmsIssuersResponseIssuerAlgorithm algorithm,
            global::Vercel.ListKmsIssuersResponseIssuerOrigin origin,
            string createdAt,
            string updatedAt,
            global::System.Collections.Generic.IList<global::Vercel.ListKmsIssuersResponseIssuerSigningKey> signingKeys,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.ListKmsIssuersResponseIssuerPolicieVariant1, global::Vercel.ListKmsIssuersResponseIssuerPolicieVariant2>> policies,
            string? managedBy,
            object? claimsSchema)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Algorithm = algorithm;
            this.Origin = origin;
            this.ManagedBy = managedBy;
            this.ClaimsSchema = claimsSchema;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.SigningKeys = signingKeys ?? throw new global::System.ArgumentNullException(nameof(signingKeys));
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKmsIssuersResponseIssuer" /> class.
        /// </summary>
        public ListKmsIssuersResponseIssuer()
        {
        }

    }
}