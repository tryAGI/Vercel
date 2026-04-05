
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The best contact for the integration, which can change as team members and their roles change.
    /// </summary>
    public sealed partial class GetAccountInfoResponseContact
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponseContact" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountInfoResponseContact(
            string email,
            string? name)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponseContact" /> class.
        /// </summary>
        public GetAccountInfoResponseContact()
        {
        }
    }
}