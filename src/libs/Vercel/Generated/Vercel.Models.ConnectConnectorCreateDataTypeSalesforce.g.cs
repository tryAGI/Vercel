
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSalesforce
    {
        /// <summary>
        /// Salesforce connected app consumer key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerKey { get; set; }

        /// <summary>
        /// Salesforce connected app consumer secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerSecret")]
        public string? ConsumerSecret { get; set; }

        /// <summary>
        /// Salesforce login host, such as login.salesforce.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loginHost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LoginHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSalesforce" /> class.
        /// </summary>
        /// <param name="consumerKey">
        /// Salesforce connected app consumer key.
        /// </param>
        /// <param name="loginHost">
        /// Salesforce login host, such as login.salesforce.com.
        /// </param>
        /// <param name="consumerSecret">
        /// Salesforce connected app consumer secret.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSalesforce(
            string consumerKey,
            string loginHost,
            string? consumerSecret)
        {
            this.ConsumerKey = consumerKey ?? throw new global::System.ArgumentNullException(nameof(consumerKey));
            this.ConsumerSecret = consumerSecret;
            this.LoginHost = loginHost ?? throw new global::System.ArgumentNullException(nameof(loginHost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSalesforce" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSalesforce()
        {
        }

    }
}