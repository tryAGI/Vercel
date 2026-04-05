
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConfigurableLogDrainRequest
    {
        /// <summary>
        /// The delivery log format<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConfigurableLogDrainRequestDeliveryFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat DeliveryFormat { get; set; }

        /// <summary>
        /// The log drain url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Headers to be sent together with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateConfigurableLogDrainRequestSource> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateConfigurableLogDrainRequestEnvironment>? Environments { get; set; }

        /// <summary>
        /// Custom secret of log drain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// The sampling rate for this log drain. It should be a percentage rate between 0 and 100. With max 2 decimal points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplingRate")]
        public double? SamplingRate { get; set; }

        /// <summary>
        /// The custom name of this log drain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigurableLogDrainRequest" /> class.
        /// </summary>
        /// <param name="deliveryFormat">
        /// The delivery log format<br/>
        /// Example: json
        /// </param>
        /// <param name="url">
        /// The log drain url
        /// </param>
        /// <param name="sources"></param>
        /// <param name="headers">
        /// Headers to be sent together with the request
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="environments"></param>
        /// <param name="secret">
        /// Custom secret of log drain
        /// </param>
        /// <param name="samplingRate">
        /// The sampling rate for this log drain. It should be a percentage rate between 0 and 100. With max 2 decimal points
        /// </param>
        /// <param name="name">
        /// The custom name of this log drain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConfigurableLogDrainRequest(
            global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat deliveryFormat,
            string url,
            global::System.Collections.Generic.IList<global::Vercel.CreateConfigurableLogDrainRequestSource> sources,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.CreateConfigurableLogDrainRequestEnvironment>? environments,
            string? secret,
            double? samplingRate,
            string? name)
        {
            this.DeliveryFormat = deliveryFormat;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.ProjectIds = projectIds;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Environments = environments;
            this.Secret = secret;
            this.SamplingRate = samplingRate;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigurableLogDrainRequest" /> class.
        /// </summary>
        public CreateConfigurableLogDrainRequest()
        {
        }
    }
}