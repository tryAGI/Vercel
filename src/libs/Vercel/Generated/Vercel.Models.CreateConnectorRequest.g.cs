
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequest
    {
        /// <summary>
        /// Known types: api-key, github, oauth, salesforce, slack, snowflake.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Service slug or URL for which the connector is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Link to the specified project when specified. See environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Use these environments when linking to the project specified by the projectId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// Whether the triggers are enabled for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public bool? Triggers { get; set; }

        /// <summary>
        /// The list of the defaults trigger events for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Branding icon. Either a SHA-1 hash already uploaded to the Vercel avatar service or an https:// URL that will be downloaded and rehosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Branding background color (6-digit hex, e.g. "#000000").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Branding accent color (6-digit hex, e.g. "#000000").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accentColor")]
        public string? AccentColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, object> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Known types: api-key, github, oauth, salesforce, slack, snowflake.
        /// </param>
        /// <param name="data"></param>
        /// <param name="service">
        /// Service slug or URL for which the connector is used.
        /// </param>
        /// <param name="uid"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Link to the specified project when specified. See environments.
        /// </param>
        /// <param name="environments">
        /// Use these environments when linking to the project specified by the projectId.
        /// </param>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="events">
        /// The list of the defaults trigger events for this connector.
        /// </param>
        /// <param name="icon">
        /// Branding icon. Either a SHA-1 hash already uploaded to the Vercel avatar service or an https:// URL that will be downloaded and rehosted.
        /// </param>
        /// <param name="backgroundColor">
        /// Branding background color (6-digit hex, e.g. "#000000").
        /// </param>
        /// <param name="accentColor">
        /// Branding accent color (6-digit hex, e.g. "#000000").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequest(
            string type,
            global::Vercel.AnyOf<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, object> data,
            string? service,
            string? uid,
            string? name,
            string? projectId,
            global::System.Collections.Generic.IList<string>? environments,
            bool? triggers,
            global::System.Collections.Generic.IList<string>? events,
            string? icon,
            string? backgroundColor,
            string? accentColor)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Service = service;
            this.Uid = uid;
            this.Name = name;
            this.ProjectId = projectId;
            this.Environments = environments;
            this.Triggers = triggers;
            this.Events = events;
            this.Icon = icon;
            this.BackgroundColor = backgroundColor;
            this.AccentColor = accentColor;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequest" /> class.
        /// </summary>
        public CreateConnectorRequest()
        {
        }

    }
}