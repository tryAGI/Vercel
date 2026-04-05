
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing information of the domain creator, including the user's id, username, and email.<br/>
    /// Example: {"id":"ZspSRT4ljIEEmMHgoDwKWDei","username":"vercel_user","email":"demo@example.com"}
    /// </summary>
    public sealed partial class CreateOrTransferDomainResponseDomainCreator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDomainReseller")]
        public bool? IsDomainReseller { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainResponseDomainCreator" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="customerId"></param>
        /// <param name="isDomainReseller"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrTransferDomainResponseDomainCreator(
            string username,
            string email,
            string id,
            string? customerId,
            bool? isDomainReseller)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.CustomerId = customerId;
            this.IsDomainReseller = isDomainReseller;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainResponseDomainCreator" /> class.
        /// </summary>
        public CreateOrTransferDomainResponseDomainCreator()
        {
        }
    }
}