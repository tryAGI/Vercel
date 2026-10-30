
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc57b57fa067d8814
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc57b57fa067d8814AlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm Algorithm { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("discoveryLayout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc57b57fa067d8814DiscoveryLayoutJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc57b57fa067d8814DiscoveryLayout DiscoveryLayout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        public string? ManagedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc57b57fa067d8814OriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc57b57fa067d8814Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedc57b57fa067d8814PolicieVariant1, global::Vercel.AutoSDKSharedc57b57fa067d8814PolicieVariant2>> Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared38e9af03824d67bc> SigningKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc57b57fa067d8814" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="createdAt"></param>
        /// <param name="discoveryLayout"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="origin"></param>
        /// <param name="ownerId"></param>
        /// <param name="policies"></param>
        /// <param name="signingKeys"></param>
        /// <param name="updatedAt"></param>
        /// <param name="claimsSchema"></param>
        /// <param name="managedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc57b57fa067d8814(
            global::Vercel.AutoSDKSharedc57b57fa067d8814Algorithm algorithm,
            string createdAt,
            global::Vercel.AutoSDKSharedc57b57fa067d8814DiscoveryLayout discoveryLayout,
            string id,
            string name,
            global::Vercel.AutoSDKSharedc57b57fa067d8814Origin origin,
            string ownerId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKSharedc57b57fa067d8814PolicieVariant1, global::Vercel.AutoSDKSharedc57b57fa067d8814PolicieVariant2>> policies,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared38e9af03824d67bc> signingKeys,
            string updatedAt,
            object? claimsSchema,
            string? managedBy)
        {
            this.Algorithm = algorithm;
            this.ClaimsSchema = claimsSchema;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DiscoveryLayout = discoveryLayout;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ManagedBy = managedBy;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Origin = origin;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
            this.SigningKeys = signingKeys ?? throw new global::System.ArgumentNullException(nameof(signingKeys));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc57b57fa067d8814" /> class.
        /// </summary>
        public AutoSDKSharedc57b57fa067d8814()
        {
        }

    }
}