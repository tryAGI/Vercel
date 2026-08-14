
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeLinear, global::Vercel.CreateConnectorRequestDataTypeLinq, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSendblue, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, global::Vercel.CreateConnectorRequestDataTypeSnowflakeWif, global::Vercel.CreateConnectorRequestDataTypePhoton, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeLinear, global::Vercel.CreateConnectorRequestDataTypeLinq, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSendblue, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, global::Vercel.CreateConnectorRequestDataTypeSnowflakeWif, global::Vercel.CreateConnectorRequestDataTypePhoton, object> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accentColor")]
        public string? AccentColor { get; set; }

        /// <summary>
        /// Known types: api-key, github, linear, linq, oauth, photon, salesforce, sendblue, slack, snowflake. Optional when \"connectionMethod\" is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Service slug or URL for which the connector is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// Connection method slug of the service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMethod")]
        public string? ConnectionMethod { get; set; }

        /// <summary>
        /// Values for the connection method's templateFields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.Dictionary<string, string>? Params { get; set; }

        /// <summary>
        /// Which of the service's targets this connector is for. Requires \"connectionMethod\" and must be one that method serves. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

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
        /// Use these built-in environment names or stable custom environment IDs when linking to projectId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// Whether the triggers are enabled for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public bool? Triggers { get; set; }

        /// <summary>
        /// Initial trigger destination routing for the linked project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerDestination")]
        public global::Vercel.CreateConnectorRequestTriggerDestination? TriggerDestination { get; set; }

        /// <summary>
        /// The list of the defaults trigger events for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="icon"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="accentColor"></param>
        /// <param name="type">
        /// Known types: api-key, github, linear, linq, oauth, photon, salesforce, sendblue, slack, snowflake. Optional when \"connectionMethod\" is set.
        /// </param>
        /// <param name="service">
        /// Service slug or URL for which the connector is used.
        /// </param>
        /// <param name="connectionMethod">
        /// Connection method slug of the service.
        /// </param>
        /// <param name="params">
        /// Values for the connection method's templateFields.
        /// </param>
        /// <param name="target">
        /// Which of the service's targets this connector is for. Requires \"connectionMethod\" and must be one that method serves. Optional.
        /// </param>
        /// <param name="uid"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Link to the specified project when specified. See environments.
        /// </param>
        /// <param name="environments">
        /// Use these built-in environment names or stable custom environment IDs when linking to projectId.
        /// </param>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="triggerDestination">
        /// Initial trigger destination routing for the linked project.
        /// </param>
        /// <param name="events">
        /// The list of the defaults trigger events for this connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequest(
            global::Vercel.AnyOf<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeLinear, global::Vercel.CreateConnectorRequestDataTypeLinq, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSendblue, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, global::Vercel.CreateConnectorRequestDataTypeSnowflakeWif, global::Vercel.CreateConnectorRequestDataTypePhoton, object> data,
            string? icon,
            string? backgroundColor,
            string? accentColor,
            string? type,
            string? service,
            string? connectionMethod,
            global::System.Collections.Generic.Dictionary<string, string>? @params,
            string? target,
            string? uid,
            string? name,
            string? projectId,
            global::System.Collections.Generic.IList<string>? environments,
            bool? triggers,
            global::Vercel.CreateConnectorRequestTriggerDestination? triggerDestination,
            global::System.Collections.Generic.IList<string>? events)
        {
            this.Data = data;
            this.Icon = icon;
            this.BackgroundColor = backgroundColor;
            this.AccentColor = accentColor;
            this.Type = type;
            this.Service = service;
            this.ConnectionMethod = connectionMethod;
            this.Params = @params;
            this.Target = target;
            this.Uid = uid;
            this.Name = name;
            this.ProjectId = projectId;
            this.Environments = environments;
            this.Triggers = triggers;
            this.TriggerDestination = triggerDestination;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequest" /> class.
        /// </summary>
        public CreateConnectorRequest()
        {
        }

    }
}