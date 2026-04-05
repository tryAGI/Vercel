
#nullable enable

namespace Vercel
{
    /// <summary>
    /// move-in
    /// </summary>
    public sealed partial class CreateOrTransferDomainRequestVariant2
    {
        /// <summary>
        /// The domain name you want to add.<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The domain operation to perform.<br/>
        /// Example: move-in
        /// </summary>
        /// <example>move-in</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// The move-in token from Move Requested email.<br/>
        /// Example: fdhfr820ad#@FAdlj$$
        /// </summary>
        /// <example>fdhfr820ad#@FAdlj$$</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainRequestVariant2" /> class.
        /// </summary>
        /// <param name="name">
        /// The domain name you want to add.<br/>
        /// Example: example.com
        /// </param>
        /// <param name="method">
        /// The domain operation to perform.<br/>
        /// Example: move-in
        /// </param>
        /// <param name="token">
        /// The move-in token from Move Requested email.<br/>
        /// Example: fdhfr820ad#@FAdlj$$
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrTransferDomainRequestVariant2(
            string name,
            string method,
            string? token)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrTransferDomainRequestVariant2" /> class.
        /// </summary>
        public CreateOrTransferDomainRequestVariant2()
        {
        }
    }
}