
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared02b3ab4a1bf599af
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared02b3ab4a1bf599afAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm Algorithm { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared02b3ab4a1bf599afOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared02b3ab4a1bf599afOrigin Origin { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared02b3ab4a1bf599afPolicieVariant1, global::Vercel.AutoSDKShared02b3ab4a1bf599afPolicieVariant2>> Policies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3ba4fd4930b951c7> SigningKeys { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared02b3ab4a1bf599af" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="createdAt"></param>
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
        public AutoSDKShared02b3ab4a1bf599af(
            global::Vercel.AutoSDKShared02b3ab4a1bf599afAlgorithm algorithm,
            string createdAt,
            string id,
            string name,
            global::Vercel.AutoSDKShared02b3ab4a1bf599afOrigin origin,
            string ownerId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared02b3ab4a1bf599afPolicieVariant1, global::Vercel.AutoSDKShared02b3ab4a1bf599afPolicieVariant2>> policies,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3ba4fd4930b951c7> signingKeys,
            string updatedAt,
            object? claimsSchema,
            string? managedBy)
        {
            this.Algorithm = algorithm;
            this.ClaimsSchema = claimsSchema;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
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
        /// Initializes a new instance of the <see cref="AutoSDKShared02b3ab4a1bf599af" /> class.
        /// </summary>
        public AutoSDKShared02b3ab4a1bf599af()
        {
        }

    }
}