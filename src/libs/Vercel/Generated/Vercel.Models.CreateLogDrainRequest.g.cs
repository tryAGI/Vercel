
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLogDrainRequest
    {
        /// <summary>
        /// The name of the log drain<br/>
        /// Example: My first log drain
        /// </summary>
        /// <example>My first log drain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// A secret to sign log drain notification headers so a consumer can verify their authenticity<br/>
        /// Example: a1Xsfd325fXcs
        /// </summary>
        /// <example>a1Xsfd325fXcs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// The delivery log format<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateLogDrainRequestDeliveryFormatJsonConverter))]
        public global::Vercel.CreateLogDrainRequestDeliveryFormat? DeliveryFormat { get; set; }

        /// <summary>
        /// The url where you will receive logs. The protocol must be `https://` or `http://` when type is `json` and `ndjson`.<br/>
        /// Example: https://example.com/log-drain
        /// </summary>
        /// <example>https://example.com/log-drain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainRequestSource>? Sources { get; set; }

        /// <summary>
        /// Headers to be sent together with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainRequestEnvironment>? Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogDrainRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the log drain<br/>
        /// Example: My first log drain
        /// </param>
        /// <param name="url">
        /// The url where you will receive logs. The protocol must be `https://` or `http://` when type is `json` and `ndjson`.<br/>
        /// Example: https://example.com/log-drain
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="secret">
        /// A secret to sign log drain notification headers so a consumer can verify their authenticity<br/>
        /// Example: a1Xsfd325fXcs
        /// </param>
        /// <param name="deliveryFormat">
        /// The delivery log format<br/>
        /// Example: json
        /// </param>
        /// <param name="sources"></param>
        /// <param name="headers">
        /// Headers to be sent together with the request
        /// </param>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLogDrainRequest(
            string name,
            string url,
            global::System.Collections.Generic.IList<string>? projectIds,
            string? secret,
            global::Vercel.CreateLogDrainRequestDeliveryFormat? deliveryFormat,
            global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainRequestSource>? sources,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainRequestEnvironment>? environments)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectIds = projectIds;
            this.Secret = secret;
            this.DeliveryFormat = deliveryFormat;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Sources = sources;
            this.Headers = headers;
            this.Environments = environments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogDrainRequest" /> class.
        /// </summary>
        public CreateLogDrainRequest()
        {
        }
    }
}