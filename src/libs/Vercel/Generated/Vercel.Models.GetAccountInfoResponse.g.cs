
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAccountInfoResponse
    {
        /// <summary>
        /// The best contact for the integration, which can change as team members and their roles change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact")]
        public global::Vercel.GetAccountInfoResponseContact? Contact { get; set; }

        /// <summary>
        /// Up to 3 contacts for the integration. `contact` comes first, followed by the confirmed owners of the team, longest-standing first. For a personal account, the account owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contacts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetAccountInfoResponseContact2> Contacts { get; set; }

        /// <summary>
        /// The name of the team the installation is tied to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A URL linking to the installation in the Vercel Dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponse" /> class.
        /// </summary>
        /// <param name="contacts">
        /// Up to 3 contacts for the integration. `contact` comes first, followed by the confirmed owners of the team, longest-standing first. For a personal account, the account owner.
        /// </param>
        /// <param name="url">
        /// A URL linking to the installation in the Vercel Dashboard.
        /// </param>
        /// <param name="contact">
        /// The best contact for the integration, which can change as team members and their roles change.
        /// </param>
        /// <param name="name">
        /// The name of the team the installation is tied to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountInfoResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetAccountInfoResponseContact2> contacts,
            string url,
            global::Vercel.GetAccountInfoResponseContact? contact,
            string? name)
        {
            this.Contact = contact;
            this.Contacts = contacts ?? throw new global::System.ArgumentNullException(nameof(contacts));
            this.Name = name;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponse" /> class.
        /// </summary>
        public GetAccountInfoResponse()
        {
        }

    }
}