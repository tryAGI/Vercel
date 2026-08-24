
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Create a connector with full provider configuration or with a known service connection method.
    /// </summary>
    public sealed partial class ConnectCreateConnectorRequest
    {
        /// <summary>
        /// Provider configuration. With type, provide the complete configuration for that type. With service and connectionMethod, provide only credentials and preferences; Connect supplies the type, endpoints, templates, and defaults. Other connector types accept an arbitrary object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorCreateData Data { get; set; }

        /// <summary>
        /// SHA-1 digest of a PNG or JPEG icon that is at least 640 by 640 pixels. This field does not accept a URL or image bytes.<br/>
        /// First compute the digest and upload the raw image with [POST /v2/files](https://vercel.com/docs/rest-api/deployments/upload-deployment-files). Send `Content-Length` and the same 40-character digest in `x-vercel-digest`. Then set `icon` to that digest.<br/>
        /// ```js<br/>
        /// import { createHash } from 'node:crypto';<br/>
        /// import { readFile } from 'node:fs/promises';<br/>
        /// const VERCEL_TOKEN = process.env.VERCEL_TOKEN;<br/>
        /// const connectorId = 'scl_...';<br/>
        /// const bytes = await readFile('icon.png');<br/>
        /// const digest = createHash('sha1').update(bytes).digest('hex');<br/>
        /// await fetch('https://api.vercel.com/v2/files', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${VERCEL_TOKEN}`,<br/>
        ///     'Content-Type': 'application/octet-stream',<br/>
        ///     'Content-Length': String(bytes.length),<br/>
        ///     'x-vercel-digest': digest,<br/>
        ///   },<br/>
        ///   body: bytes,<br/>
        /// });<br/>
        /// await fetch(`https://api.vercel.com/v2/connect/connectors/${connectorId}`, {<br/>
        ///   method: 'PATCH',<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${VERCEL_TOKEN}`,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({ icon: digest }),<br/>
        /// });<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Branding background color (6-digit hex, for example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Branding accent color (6-digit hex, for example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accentColor")]
        public string? AccentColor { get; set; }

        /// <summary>
        /// Connector implementation type for full configuration. Known types: api-key, discord, github, linear, linq, microsoft-entra, oauth, photon, salesforce, sendblue, slack, snowflake, snowflake-wif. Optional when service and connectionMethod select the type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Service slug or URL for which the connector is used. Required when connectionMethod is set. Service alone does not enable preset configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// Connection method slug of the service. Use it with service to select preset configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMethod")]
        public string? ConnectionMethod { get; set; }

        /// <summary>
        /// Values for the selected connection method's template fields. Requires connectionMethod.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.Dictionary<string, string>? Params { get; set; }

        /// <summary>
        /// Which of the service's targets this connector is for. Requires \"connectionMethod\" and must be one that method serves. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Optional team-scoped unique identifier for the connector. If omitted or empty, Connect generates a value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Connector name. The value is trimmed and cannot contain control characters. If omitted or empty, the project name is used. A name or projectId is required. API key connectors require name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Project to connect during creation. If environments is omitted, the connection uses development, preview, and production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Environments for the project connection. Requires projectId. Use one or more built-in environment names or stable custom environment IDs that belong to the project. Duplicate values are accepted and removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>>? Environments { get; set; }

        /// <summary>
        /// Whether the triggers are enabled for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public bool? Triggers { get; set; }

        /// <summary>
        /// Initial trigger destination. Requires triggers to be enabled and a projectId here or at the top level. Connector responses expose the resulting set as triggerDestinations. Replace the complete set with PATCH /v1/connect/connectors/{connector}/trigger-destinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerDestination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>))]
        public global::Vercel.OneOf<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>? TriggerDestination { get; set; }

        /// <summary>
        /// Default trigger events for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectCreateConnectorRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Provider configuration. With type, provide the complete configuration for that type. With service and connectionMethod, provide only credentials and preferences; Connect supplies the type, endpoints, templates, and defaults. Other connector types accept an arbitrary object.
        /// </param>
        /// <param name="icon">
        /// SHA-1 digest of a PNG or JPEG icon that is at least 640 by 640 pixels. This field does not accept a URL or image bytes.<br/>
        /// First compute the digest and upload the raw image with [POST /v2/files](https://vercel.com/docs/rest-api/deployments/upload-deployment-files). Send `Content-Length` and the same 40-character digest in `x-vercel-digest`. Then set `icon` to that digest.<br/>
        /// ```js<br/>
        /// import { createHash } from 'node:crypto';<br/>
        /// import { readFile } from 'node:fs/promises';<br/>
        /// const VERCEL_TOKEN = process.env.VERCEL_TOKEN;<br/>
        /// const connectorId = 'scl_...';<br/>
        /// const bytes = await readFile('icon.png');<br/>
        /// const digest = createHash('sha1').update(bytes).digest('hex');<br/>
        /// await fetch('https://api.vercel.com/v2/files', {<br/>
        ///   method: 'POST',<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${VERCEL_TOKEN}`,<br/>
        ///     'Content-Type': 'application/octet-stream',<br/>
        ///     'Content-Length': String(bytes.length),<br/>
        ///     'x-vercel-digest': digest,<br/>
        ///   },<br/>
        ///   body: bytes,<br/>
        /// });<br/>
        /// await fetch(`https://api.vercel.com/v2/connect/connectors/${connectorId}`, {<br/>
        ///   method: 'PATCH',<br/>
        ///   headers: {<br/>
        ///     Authorization: `Bearer ${VERCEL_TOKEN}`,<br/>
        ///     'Content-Type': 'application/json',<br/>
        ///   },<br/>
        ///   body: JSON.stringify({ icon: digest }),<br/>
        /// });<br/>
        /// ```
        /// </param>
        /// <param name="backgroundColor">
        /// Branding background color (6-digit hex, for example
        /// </param>
        /// <param name="accentColor">
        /// Branding accent color (6-digit hex, for example
        /// </param>
        /// <param name="type">
        /// Connector implementation type for full configuration. Known types: api-key, discord, github, linear, linq, microsoft-entra, oauth, photon, salesforce, sendblue, slack, snowflake, snowflake-wif. Optional when service and connectionMethod select the type.
        /// </param>
        /// <param name="service">
        /// Service slug or URL for which the connector is used. Required when connectionMethod is set. Service alone does not enable preset configuration.
        /// </param>
        /// <param name="connectionMethod">
        /// Connection method slug of the service. Use it with service to select preset configuration.
        /// </param>
        /// <param name="params">
        /// Values for the selected connection method's template fields. Requires connectionMethod.
        /// </param>
        /// <param name="target">
        /// Which of the service's targets this connector is for. Requires \"connectionMethod\" and must be one that method serves. Optional.
        /// </param>
        /// <param name="uid">
        /// Optional team-scoped unique identifier for the connector. If omitted or empty, Connect generates a value.
        /// </param>
        /// <param name="name">
        /// Connector name. The value is trimmed and cannot contain control characters. If omitted or empty, the project name is used. A name or projectId is required. API key connectors require name.
        /// </param>
        /// <param name="projectId">
        /// Project to connect during creation. If environments is omitted, the connection uses development, preview, and production.
        /// </param>
        /// <param name="environments">
        /// Environments for the project connection. Requires projectId. Use one or more built-in environment names or stable custom environment IDs that belong to the project. Duplicate values are accepted and removed.
        /// </param>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="triggerDestination">
        /// Initial trigger destination. Requires triggers to be enabled and a projectId here or at the top level. Connector responses expose the resulting set as triggerDestinations. Replace the complete set with PATCH /v1/connect/connectors/{connector}/trigger-destinations.
        /// </param>
        /// <param name="events">
        /// Default trigger events for this connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectCreateConnectorRequest(
            global::Vercel.ConnectConnectorCreateData data,
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
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>>? environments,
            bool? triggers,
            global::Vercel.OneOf<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>? triggerDestination,
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
        /// Initializes a new instance of the <see cref="ConnectCreateConnectorRequest" /> class.
        /// </summary>
        public ConnectCreateConnectorRequest()
        {
        }

    }
}