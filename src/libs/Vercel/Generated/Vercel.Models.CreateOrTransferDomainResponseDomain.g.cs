
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrTransferDomainResponseDomain
    {
        /// <summary>
        /// If the domain has the ownership verified.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// A list of the current nameservers of the domain.<br/>
        /// Example: [ns1.nameserver.net, ns2.nameserver.net]
        /// </summary>
        /// <example>[ns1.nameserver.net, ns2.nameserver.net]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameservers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Nameservers { get; set; }

        /// <summary>
        /// A list of the intended nameservers for the domain to point to Vercel DNS.<br/>
        /// Example: [ns1.vercel-dns.com, ns2.vercel-dns.com]
        /// </summary>
        /// <example>[ns1.vercel-dns.com, ns2.vercel-dns.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("intendedNameservers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IntendedNameservers { get; set; }

        /// <summary>
        /// A list of custom nameservers for the domain to point to. Only applies to domains purchased with Vercel.<br/>
        /// Example: [ns1.nameserver.net, ns2.nameserver.net]
        /// </summary>
        /// <example>[ns1.nameserver.net, ns2.nameserver.net]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customNameservers")]
        public global::System.Collections.Generic.IList<string>? CustomNameservers { get; set; }

        /// <summary>
        /// An object containing information of the domain creator, including the user's id, username, and email.<br/>
        /// Example: {"id":"ZspSRT4ljIEEmMHgoDwKWDei","username":"vercel_user","email":"demo@example.com"}
        /// </summary>
        /// <example>{"id":"ZspSRT4ljIEEmMHgoDwKWDei","username":"vercel_user","email":"demo@example.com"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateOrTransferDomainResponseDomainCreator Creator { get; set; }

        /// <summary>
        /// The domain name.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// If it was purchased through Vercel, the timestamp in milliseconds when it was purchased.<br/>
        /// Example: 1613602938882L
        /// </summary>
        /// <example>1613602938882L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("boughtAt")]
        public double? BoughtAt { get; set; }

        /// <summary>
        /// Timestamp in milliseconds when the domain was created in the registry.<br/>
        /// Example: 1613602938882L
        /// </summary>
        /// <example>1613602938882L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Timestamp in milliseconds at which the domain is set to expire. `null` if not bought with Vercel.<br/>
        /// Example: 1613602938882L
        /// </summary>
        /// <example>1613602938882L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// The unique identifier of the domain.<br/>
        /// Example: EmTbe5CEJyTk2yVAHBUWy4A3sRusca3GCwRjTC1bpeVnt1
        /// </summary>
        /// <example>EmTbe5CEJyTk2yVAHBUWy4A3sRusca3GCwRjTC1bpeVnt1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Indicates whether the domain is set to automatically renew.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("renew")]
        public bool? Renew { get; set; }

        /// <summary>
        /// The type of service the domain is handled by. `external` if the DNS is externally handled, `zeit.world` if handled with Vercel, or `na` if the service is not available.<br/>
        /// Example: zeit.world
        /// </summary>
        /// <example>zeit.world</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateOrTransferDomainResponseDomainServiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateOrTransferDomainResponseDomainServiceType ServiceType { get; set; }

        /// <summary>
        /// Timestamp in milliseconds at which the domain was successfully transferred into Vercel. `null` if the transfer is still processing or was never transferred in.<br/>
        /// Example: 1613602938882L
        /// </summary>
        /// <example>1613602938882L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferredAt")]
        public double? TransferredAt { get; set; }

        /// <summary>
        /// If transferred into Vercel, timestamp in milliseconds when the domain transfer was initiated.<br/>
        /// Example: 1613602938882L
        /// </summary>
        /// <example>1613602938882L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferStartedAt")]
        public double? TransferStartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainResponseDomain" /> class.
        /// </summary>
        /// <param name="verified">
        /// If the domain has the ownership verified.<br/>
        /// Example: true
        /// </param>
        /// <param name="nameservers">
        /// A list of the current nameservers of the domain.<br/>
        /// Example: [ns1.nameserver.net, ns2.nameserver.net]
        /// </param>
        /// <param name="intendedNameservers">
        /// A list of the intended nameservers for the domain to point to Vercel DNS.<br/>
        /// Example: [ns1.vercel-dns.com, ns2.vercel-dns.com]
        /// </param>
        /// <param name="creator">
        /// An object containing information of the domain creator, including the user's id, username, and email.<br/>
        /// Example: {"id":"ZspSRT4ljIEEmMHgoDwKWDei","username":"vercel_user","email":"demo@example.com"}
        /// </param>
        /// <param name="name">
        /// The domain name.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="createdAt">
        /// Timestamp in milliseconds when the domain was created in the registry.<br/>
        /// Example: 1613602938882L
        /// </param>
        /// <param name="id">
        /// The unique identifier of the domain.<br/>
        /// Example: EmTbe5CEJyTk2yVAHBUWy4A3sRusca3GCwRjTC1bpeVnt1
        /// </param>
        /// <param name="serviceType">
        /// The type of service the domain is handled by. `external` if the DNS is externally handled, `zeit.world` if handled with Vercel, or `na` if the service is not available.<br/>
        /// Example: zeit.world
        /// </param>
        /// <param name="userId"></param>
        /// <param name="customNameservers">
        /// A list of custom nameservers for the domain to point to. Only applies to domains purchased with Vercel.<br/>
        /// Example: [ns1.nameserver.net, ns2.nameserver.net]
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="boughtAt">
        /// If it was purchased through Vercel, the timestamp in milliseconds when it was purchased.<br/>
        /// Example: 1613602938882L
        /// </param>
        /// <param name="expiresAt">
        /// Timestamp in milliseconds at which the domain is set to expire. `null` if not bought with Vercel.<br/>
        /// Example: 1613602938882L
        /// </param>
        /// <param name="renew">
        /// Indicates whether the domain is set to automatically renew.<br/>
        /// Example: true
        /// </param>
        /// <param name="transferredAt">
        /// Timestamp in milliseconds at which the domain was successfully transferred into Vercel. `null` if the transfer is still processing or was never transferred in.<br/>
        /// Example: 1613602938882L
        /// </param>
        /// <param name="transferStartedAt">
        /// If transferred into Vercel, timestamp in milliseconds when the domain transfer was initiated.<br/>
        /// Example: 1613602938882L
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrTransferDomainResponseDomain(
            bool verified,
            global::System.Collections.Generic.IList<string> nameservers,
            global::System.Collections.Generic.IList<string> intendedNameservers,
            global::Vercel.CreateOrTransferDomainResponseDomainCreator creator,
            string name,
            double createdAt,
            string id,
            global::Vercel.CreateOrTransferDomainResponseDomainServiceType serviceType,
            string userId,
            global::System.Collections.Generic.IList<string>? customNameservers,
            string? teamId,
            double? boughtAt,
            double? expiresAt,
            bool? renew,
            double? transferredAt,
            double? transferStartedAt)
        {
            this.Verified = verified;
            this.Nameservers = nameservers ?? throw new global::System.ArgumentNullException(nameof(nameservers));
            this.IntendedNameservers = intendedNameservers ?? throw new global::System.ArgumentNullException(nameof(intendedNameservers));
            this.CustomNameservers = customNameservers;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamId = teamId;
            this.BoughtAt = boughtAt;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Renew = renew;
            this.ServiceType = serviceType;
            this.TransferredAt = transferredAt;
            this.TransferStartedAt = transferStartedAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainResponseDomain" /> class.
        /// </summary>
        public CreateOrTransferDomainResponseDomain()
        {
        }
    }
}