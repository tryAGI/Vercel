
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSalesforce
    {
        /// <summary>
        /// Salesforce connected app consumer key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerKey")]
        public string? ConsumerKey { get; set; }

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
        public string? LoginHost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSalesforce" /> class.
        /// </summary>
        /// <param name="consumerKey">
        /// Salesforce connected app consumer key.
        /// </param>
        /// <param name="consumerSecret">
        /// Salesforce connected app consumer secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="loginHost">
        /// Salesforce login host, such as login.salesforce.com.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSalesforce(
            string? consumerKey,
            string? consumerSecret,
            string? loginHost)
        {
            this.ConsumerKey = consumerKey;
            this.ConsumerSecret = consumerSecret;
            this.LoginHost = loginHost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSalesforce" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSalesforce()
        {
        }

    }
}