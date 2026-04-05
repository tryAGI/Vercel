
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAccountInfoResponse
    {
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
        /// The best contact for the integration, which can change as team members and their roles change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact")]
        public global::Vercel.GetAccountInfoResponseContact? Contact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// A URL linking to the installation in the Vercel Dashboard.
        /// </param>
        /// <param name="name">
        /// The name of the team the installation is tied to.
        /// </param>
        /// <param name="contact">
        /// The best contact for the integration, which can change as team members and their roles change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountInfoResponse(
            string url,
            string? name,
            global::Vercel.GetAccountInfoResponseContact? contact)
        {
            this.Name = name;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Contact = contact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInfoResponse" /> class.
        /// </summary>
        public GetAccountInfoResponse()
        {
        }
    }
}