
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLogDrainResponse
    {
        /// <summary>
        /// The oauth2 client application id that created this log drain<br/>
        /// Example: oac_xRhY4LAB7yLhUADD69EvV7ct
        /// </summary>
        /// <example>oac_xRhY4LAB7yLhUADD69EvV7ct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The client configuration this log drain was created with<br/>
        /// Example: icfg_3bwCLgxL8qt5kjRLcv2Dit7F
        /// </summary>
        /// <example>icfg_3bwCLgxL8qt5kjRLcv2Dit7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// A timestamp that tells you when the log drain was created<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The unique identifier of the log drain. Always prefixed with `ld_`<br/>
        /// Example: ld_nBuA7zCID8g4QZ8g
        /// </summary>
        /// <example>ld_nBuA7zCID8g4QZ8g</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The delivery log format<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateLogDrainResponseDeliveryFormatJsonConverter))]
        public global::Vercel.CreateLogDrainResponseDeliveryFormat? DeliveryFormat { get; set; }

        /// <summary>
        /// The name of the log drain<br/>
        /// Example: My first log drain
        /// </summary>
        /// <example>My first log drain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The identifier of the team or user whose events will trigger the log drain<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </summary>
        /// <example>kr1PsOIzqEL5Xg6M4VZcZosf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Example: AbCgVkqoxXeXCDWehVir51LHGrrcWL4mkYm14W6UBPWQeb
        /// </summary>
        /// <example>AbCgVkqoxXeXCDWehVir51LHGrrcWL4mkYm14W6UBPWQeb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The identifier of the projects this log drain is associated with<br/>
        /// Example: AbCgVkqoxXeXCDWehVir51LHGrrcWL4mkYm14W6UBPWQeb
        /// </summary>
        /// <example>AbCgVkqoxXeXCDWehVir51LHGrrcWL4mkYm14W6UBPWQeb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        public global::System.Collections.Generic.IList<string>? ProjectIds { get; set; }

        /// <summary>
        /// The URL to call when logs are generated<br/>
        /// Example: https://example.com/log-drain
        /// </summary>
        /// <example>https://example.com/log-drain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The sources from which logs are currently being delivered to this log drain.<br/>
        /// Example: [build, edge]
        /// </summary>
        /// <example>[build, edge]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainResponseSource>? Sources { get; set; }

        /// <summary>
        /// Whether the log drain was created by an integration or by a user<br/>
        /// Example: integration
        /// </summary>
        /// <example>integration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdFrom")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateLogDrainResponseCreatedFromJsonConverter))]
        public global::Vercel.CreateLogDrainResponseCreatedFrom? CreatedFrom { get; set; }

        /// <summary>
        /// The headers to send with the request<br/>
        /// Example: {"Authorization": "Bearer 123"}
        /// </summary>
        /// <example>{"Authorization": "Bearer 123"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The environment of log drain<br/>
        /// Example: [production]
        /// </summary>
        /// <example>[production]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainResponseEnvironment>? Environments { get; set; }

        /// <summary>
        /// The branch regexp of log drain<br/>
        /// Example: feature/*
        /// </summary>
        /// <example>feature/*</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The sampling rate of log drain<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplingRate")]
        public double? SamplingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateLogDrainResponseSourceVariant1, global::Vercel.CreateLogDrainResponseSourceVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.CreateLogDrainResponseSourceVariant1, global::Vercel.CreateLogDrainResponseSourceVariant2> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogDrainResponse" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// A timestamp that tells you when the log drain was created<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="id">
        /// The unique identifier of the log drain. Always prefixed with `ld_`<br/>
        /// Example: ld_nBuA7zCID8g4QZ8g
        /// </param>
        /// <param name="name">
        /// The name of the log drain<br/>
        /// Example: My first log drain
        /// </param>
        /// <param name="ownerId">
        /// The identifier of the team or user whose events will trigger the log drain<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </param>
        /// <param name="url">
        /// The URL to call when logs are generated<br/>
        /// Example: https://example.com/log-drain
        /// </param>
        /// <param name="source"></param>
        /// <param name="clientId">
        /// The oauth2 client application id that created this log drain<br/>
        /// Example: oac_xRhY4LAB7yLhUADD69EvV7ct
        /// </param>
        /// <param name="configurationId">
        /// The client configuration this log drain was created with<br/>
        /// Example: icfg_3bwCLgxL8qt5kjRLcv2Dit7F
        /// </param>
        /// <param name="deliveryFormat">
        /// The delivery log format<br/>
        /// Example: json
        /// </param>
        /// <param name="projectId">
        /// Example: AbCgVkqoxXeXCDWehVir51LHGrrcWL4mkYm14W6UBPWQeb
        /// </param>
        /// <param name="projectIds">
        /// The identifier of the projects this log drain is associated with<br/>
        /// Example: AbCgVkqoxXeXCDWehVir51LHGrrcWL4mkYm14W6UBPWQeb
        /// </param>
        /// <param name="sources">
        /// The sources from which logs are currently being delivered to this log drain.<br/>
        /// Example: [build, edge]
        /// </param>
        /// <param name="createdFrom">
        /// Whether the log drain was created by an integration or by a user<br/>
        /// Example: integration
        /// </param>
        /// <param name="headers">
        /// The headers to send with the request<br/>
        /// Example: {"Authorization": "Bearer 123"}
        /// </param>
        /// <param name="environments">
        /// The environment of log drain<br/>
        /// Example: [production]
        /// </param>
        /// <param name="branch">
        /// The branch regexp of log drain<br/>
        /// Example: feature/*
        /// </param>
        /// <param name="samplingRate">
        /// The sampling rate of log drain<br/>
        /// Example: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLogDrainResponse(
            double createdAt,
            string id,
            string name,
            string ownerId,
            string url,
            global::Vercel.OneOf<global::Vercel.CreateLogDrainResponseSourceVariant1, global::Vercel.CreateLogDrainResponseSourceVariant2> source,
            string? clientId,
            string? configurationId,
            global::Vercel.CreateLogDrainResponseDeliveryFormat? deliveryFormat,
            string? projectId,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainResponseSource>? sources,
            global::Vercel.CreateLogDrainResponseCreatedFrom? createdFrom,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainResponseEnvironment>? environments,
            string? branch,
            double? samplingRate)
        {
            this.ClientId = clientId;
            this.ConfigurationId = configurationId;
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DeliveryFormat = deliveryFormat;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectId = projectId;
            this.ProjectIds = projectIds;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Sources = sources;
            this.CreatedFrom = createdFrom;
            this.Headers = headers;
            this.Environments = environments;
            this.Branch = branch;
            this.SamplingRate = samplingRate;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogDrainResponse" /> class.
        /// </summary>
        public CreateLogDrainResponse()
        {
        }
    }
}