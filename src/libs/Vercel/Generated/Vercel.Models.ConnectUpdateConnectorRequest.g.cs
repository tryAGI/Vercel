
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Connector fields to update.
    /// </summary>
    public sealed partial class ConnectUpdateConnectorRequest
    {
        /// <summary>
        /// Whether the triggers are enabled for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public bool? Triggers { get; set; }

        /// <summary>
        /// Default trigger events for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Provider configuration fields for the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorUpdateDataJsonConverter))]
        public global::Vercel.ConnectConnectorUpdateData? Data { get; set; }

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
        /// Full team-scoped UID, such as `slack/my-bot`. It cannot contain whitespace, `%`, `#`, control characters, or Vercel-owned namespaces. Changing it breaks callers that use the old UID. The stable connector ID does not change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Display name for the connector. It is trimmed and cannot be empty or contain control characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectUpdateConnectorRequest" /> class.
        /// </summary>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="events">
        /// Default trigger events for this connector.
        /// </param>
        /// <param name="data">
        /// Provider configuration fields for the connector type.
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
        /// <param name="backgroundColor"></param>
        /// <param name="accentColor"></param>
        /// <param name="uid">
        /// Full team-scoped UID, such as `slack/my-bot`. It cannot contain whitespace, `%`, `#`, control characters, or Vercel-owned namespaces. Changing it breaks callers that use the old UID. The stable connector ID does not change.
        /// </param>
        /// <param name="name">
        /// Display name for the connector. It is trimmed and cannot be empty or contain control characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectUpdateConnectorRequest(
            bool? triggers,
            global::System.Collections.Generic.IList<string>? events,
            global::Vercel.ConnectConnectorUpdateData? data,
            string? icon,
            string? backgroundColor,
            string? accentColor,
            string? uid,
            string? name)
        {
            this.Triggers = triggers;
            this.Events = events;
            this.Data = data;
            this.Icon = icon;
            this.BackgroundColor = backgroundColor;
            this.AccentColor = accentColor;
            this.Uid = uid;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectUpdateConnectorRequest" /> class.
        /// </summary>
        public ConnectUpdateConnectorRequest()
        {
        }

    }
}