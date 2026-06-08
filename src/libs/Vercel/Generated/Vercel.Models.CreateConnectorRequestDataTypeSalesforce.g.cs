
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeSalesforce
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumerSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsumerSecret { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSalesforce" /> class.
        /// </summary>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <param name="loginHost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeSalesforce(
            string consumerKey,
            string consumerSecret,
            string loginHost)
        {
            this.ConsumerKey = consumerKey ?? throw new global::System.ArgumentNullException(nameof(consumerKey));
            this.ConsumerSecret = consumerSecret ?? throw new global::System.ArgumentNullException(nameof(consumerSecret));
            this.LoginHost = loginHost ?? throw new global::System.ArgumentNullException(nameof(loginHost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeSalesforce" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeSalesforce()
        {
        }

    }
}