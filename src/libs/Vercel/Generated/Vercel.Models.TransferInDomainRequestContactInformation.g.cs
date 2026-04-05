
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferInDomainRequestContactInformation
    {
        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// A valid RFC 5322 email address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// A valid E.164 phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phone { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address1 { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address2")]
        public string? Address2 { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string City { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Zip { get; set; }

        /// <summary>
        /// A valid ISO 3166-1 alpha-2 country code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// a non empty string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// A valid E.164 phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fax")]
        public string? Fax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInDomainRequestContactInformation" /> class.
        /// </summary>
        /// <param name="firstName">
        /// a non empty string
        /// </param>
        /// <param name="lastName">
        /// a non empty string
        /// </param>
        /// <param name="email">
        /// A valid RFC 5322 email address
        /// </param>
        /// <param name="phone">
        /// A valid E.164 phone number
        /// </param>
        /// <param name="address1">
        /// a non empty string
        /// </param>
        /// <param name="city">
        /// a non empty string
        /// </param>
        /// <param name="state">
        /// a non empty string
        /// </param>
        /// <param name="zip">
        /// a non empty string
        /// </param>
        /// <param name="country">
        /// A valid ISO 3166-1 alpha-2 country code
        /// </param>
        /// <param name="address2">
        /// a non empty string
        /// </param>
        /// <param name="companyName">
        /// a non empty string
        /// </param>
        /// <param name="fax">
        /// A valid E.164 phone number
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferInDomainRequestContactInformation(
            string firstName,
            string lastName,
            string email,
            string phone,
            string address1,
            string city,
            string state,
            string zip,
            string country,
            string? address2,
            string? companyName,
            string? fax)
        {
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.Address1 = address1 ?? throw new global::System.ArgumentNullException(nameof(address1));
            this.Address2 = address2;
            this.City = city ?? throw new global::System.ArgumentNullException(nameof(city));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Zip = zip ?? throw new global::System.ArgumentNullException(nameof(zip));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.CompanyName = companyName;
            this.Fax = fax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInDomainRequestContactInformation" /> class.
        /// </summary>
        public TransferInDomainRequestContactInformation()
        {
        }
    }
}