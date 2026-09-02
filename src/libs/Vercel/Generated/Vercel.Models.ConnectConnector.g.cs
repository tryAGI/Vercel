
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A connector that defines how Vercel accesses an external service.
    /// </summary>
    public sealed partial class ConnectConnector
    {
        /// <summary>
        /// Stable `scl_` connector ID. Use this value directly in `{connector}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Team-scoped UID. URL-encode this value before using it in `{connector}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Installation used when a token request does not specify an installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultInstallationId")]
        public string? DefaultInstallationId { get; set; }

        /// <summary>
        /// Creation time in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Last update time in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Time when this connector started requiring reinstallation because an installation-affecting app-token grant changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinstallAt")]
        public double? ReinstallAt { get; set; }

        /// <summary>
        /// Principal that created the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2>))]
        public global::Vercel.OneOf<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2>? CreatedBy { get; set; }

        /// <summary>
        /// Principal that most recently updated the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2>))]
        public global::Vercel.OneOf<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2>? UpdatedBy { get; set; }

        /// <summary>
        /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreationModeJsonConverter))]
        public global::Vercel.ConnectConnectorCreationMode? CreationMode { get; set; }

        /// <summary>
        /// Managed connector metadata exposed without leaking the manager connector or installation identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed")]
        public global::Vercel.ConnectConnectorManaged? Managed { get; set; }

        /// <summary>
        /// Connector implementation type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorType Type { get; set; }

        /// <summary>
        /// Best-effort identifier of the third-party service this connector represents, independent of `type`. Examples: `'slack'`, `'mcp.linear.app'`, and `'auth.example.com'`. Always present in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// The connection method this connector was created from, when the create request named one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMethod")]
        public string? ConnectionMethod { get; set; }

        /// <summary>
        /// Which of the service's products/surfaces this connector points at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Connector name within the owning team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable connector name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Provider-side URL for viewing or managing the resource represented by the connector. The destination can be an app, account, phone line, or service instance, depending on the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientUrl")]
        public string? ClientUrl { get; set; }

        /// <summary>
        /// Redirect URI registered with the third-party service for this connector, if any. Used by `startAuthorization`/`startInstallation` to replay the exact URI back to the provider's token endpoint. Absent on connectors created before this field was introduced; those callers fall back to the `https://connect.vercel.com/callback` default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// Human-readable name of the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeName { get; set; }

        /// <summary>
        /// Icon identifier supplied by the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeIcon")]
        public string? TypeIcon { get; set; }

        /// <summary>
        /// Public website for the connected service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Developer website for the connected service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devsite")]
        public string? Devsite { get; set; }

        /// <summary>
        /// Developer documentation for the connected service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docsite")]
        public string? Docsite { get; set; }

        /// <summary>
        /// Connector branding icon. SHA-1 hash that resolves to the uploaded icon through the Vercel avatar service. Consumers render this with `https://vercel.com/api/www/avatar/{icon}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Hex background color (e.g., `#000000`) for branding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Hex accent color (e.g., `#000000`) for branding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accentColor")]
        public string? AccentColor { get; set; }

        /// <summary>
        /// Token subject types supported by the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedSubjectTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedSubjectTypes { get; set; }

        /// <summary>
        /// App-token capabilities and known grants for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appTokens")]
        public global::Vercel.ConnectConnectorAppTokens? AppTokens { get; set; }

        /// <summary>
        /// User-token capabilities and known grants for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userTokens")]
        public global::Vercel.ConnectConnectorUserTokens? UserTokens { get; set; }

        /// <summary>
        /// Whether the connector supports an installation flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsInstallation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsInstallation { get; set; }

        /// <summary>
        /// Whether Connect can revoke tokens for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsRevocation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsRevocation { get; set; }

        /// <summary>
        /// Whether this connector type supports trigger webhooks. Derived from the type definition; indicates that `triggers` and `triggerDestinations` may be meaningful for this connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsTriggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsTriggers { get; set; }

        /// <summary>
        /// Whether the connector icon can propagate to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsIcon")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorSupportsIconJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorSupportsIcon SupportsIcon { get; set; }

        /// <summary>
        /// Incoming trigger configuration. Only present when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::Vercel.ConnectTriggerConfiguration? Triggers { get; set; }

        /// <summary>
        /// Known events this connector subscribes to (e.g. Slack bot events, GitHub webhook events). Names are type-specific and validated by the managed-create flow when forwarded to the third-party service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Destinations that incoming triggers should be forwarded to. Limited to 3 entries. Set the initial destination with `triggerDestination` during creation. Replace the complete set with `PATCH /v1/connect/connectors/{connector}/trigger-destinations`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerDestinations")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestination>? TriggerDestinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnector" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable `scl_` connector ID. Use this value directly in `{connector}`.
        /// </param>
        /// <param name="uid">
        /// Team-scoped UID. URL-encode this value before using it in `{connector}`.
        /// </param>
        /// <param name="createdAt">
        /// Creation time in epoch milliseconds.
        /// </param>
        /// <param name="updatedAt">
        /// Last update time in epoch milliseconds.
        /// </param>
        /// <param name="type">
        /// Connector implementation type.
        /// </param>
        /// <param name="service">
        /// Best-effort identifier of the third-party service this connector represents, independent of `type`. Examples: `'slack'`, `'mcp.linear.app'`, and `'auth.example.com'`. Always present in API responses.
        /// </param>
        /// <param name="name">
        /// Connector name within the owning team.
        /// </param>
        /// <param name="displayName">
        /// Human-readable connector name.
        /// </param>
        /// <param name="typeName">
        /// Human-readable name of the connector type.
        /// </param>
        /// <param name="supportedSubjectTypes">
        /// Token subject types supported by the connector.
        /// </param>
        /// <param name="supportsInstallation">
        /// Whether the connector supports an installation flow.
        /// </param>
        /// <param name="supportsRevocation">
        /// Whether Connect can revoke tokens for this connector.
        /// </param>
        /// <param name="supportsTriggers">
        /// Whether this connector type supports trigger webhooks. Derived from the type definition; indicates that `triggers` and `triggerDestinations` may be meaningful for this connector.
        /// </param>
        /// <param name="supportsIcon">
        /// Whether the connector icon can propagate to the provider.
        /// </param>
        /// <param name="defaultInstallationId">
        /// Installation used when a token request does not specify an installation.
        /// </param>
        /// <param name="reinstallAt">
        /// Time when this connector started requiring reinstallation because an installation-affecting app-token grant changed.
        /// </param>
        /// <param name="createdBy">
        /// Principal that created the connector.
        /// </param>
        /// <param name="updatedBy">
        /// Principal that most recently updated the connector.
        /// </param>
        /// <param name="creationMode">
        /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
        /// </param>
        /// <param name="managed">
        /// Managed connector metadata exposed without leaking the manager connector or installation identifiers.
        /// </param>
        /// <param name="connectionMethod">
        /// The connection method this connector was created from, when the create request named one.
        /// </param>
        /// <param name="target">
        /// Which of the service's products/surfaces this connector points at.
        /// </param>
        /// <param name="clientUrl">
        /// Provider-side URL for viewing or managing the resource represented by the connector. The destination can be an app, account, phone line, or service instance, depending on the connector type.
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI registered with the third-party service for this connector, if any. Used by `startAuthorization`/`startInstallation` to replay the exact URI back to the provider's token endpoint. Absent on connectors created before this field was introduced; those callers fall back to the `https://connect.vercel.com/callback` default.
        /// </param>
        /// <param name="typeIcon">
        /// Icon identifier supplied by the connector type.
        /// </param>
        /// <param name="website">
        /// Public website for the connected service.
        /// </param>
        /// <param name="devsite">
        /// Developer website for the connected service.
        /// </param>
        /// <param name="docsite">
        /// Developer documentation for the connected service.
        /// </param>
        /// <param name="icon">
        /// Connector branding icon. SHA-1 hash that resolves to the uploaded icon through the Vercel avatar service. Consumers render this with `https://vercel.com/api/www/avatar/{icon}`.
        /// </param>
        /// <param name="backgroundColor">
        /// Hex background color (e.g., `#000000`) for branding.
        /// </param>
        /// <param name="accentColor">
        /// Hex accent color (e.g., `#000000`) for branding.
        /// </param>
        /// <param name="appTokens">
        /// App-token capabilities and known grants for the connector.
        /// </param>
        /// <param name="userTokens">
        /// User-token capabilities and known grants for the connector.
        /// </param>
        /// <param name="triggers">
        /// Incoming trigger configuration. Only present when enabled.
        /// </param>
        /// <param name="events">
        /// Known events this connector subscribes to (e.g. Slack bot events, GitHub webhook events). Names are type-specific and validated by the managed-create flow when forwarded to the third-party service.
        /// </param>
        /// <param name="triggerDestinations">
        /// Destinations that incoming triggers should be forwarded to. Limited to 3 entries. Set the initial destination with `triggerDestination` during creation. Replace the complete set with `PATCH /v1/connect/connectors/{connector}/trigger-destinations`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnector(
            string id,
            string uid,
            double createdAt,
            double updatedAt,
            global::Vercel.ConnectConnectorType type,
            string service,
            string name,
            string displayName,
            string typeName,
            global::System.Collections.Generic.IList<string> supportedSubjectTypes,
            bool supportsInstallation,
            bool supportsRevocation,
            bool supportsTriggers,
            global::Vercel.ConnectConnectorSupportsIcon supportsIcon,
            string? defaultInstallationId,
            double? reinstallAt,
            global::Vercel.OneOf<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2>? createdBy,
            global::Vercel.OneOf<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2>? updatedBy,
            global::Vercel.ConnectConnectorCreationMode? creationMode,
            global::Vercel.ConnectConnectorManaged? managed,
            string? connectionMethod,
            string? target,
            string? clientUrl,
            string? redirectUri,
            string? typeIcon,
            string? website,
            string? devsite,
            string? docsite,
            string? icon,
            string? backgroundColor,
            string? accentColor,
            global::Vercel.ConnectConnectorAppTokens? appTokens,
            global::Vercel.ConnectConnectorUserTokens? userTokens,
            global::Vercel.ConnectTriggerConfiguration? triggers,
            global::System.Collections.Generic.IList<string>? events,
            global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestination>? triggerDestinations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.DefaultInstallationId = defaultInstallationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ReinstallAt = reinstallAt;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.CreationMode = creationMode;
            this.Managed = managed;
            this.Type = type;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.ConnectionMethod = connectionMethod;
            this.Target = target;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ClientUrl = clientUrl;
            this.RedirectUri = redirectUri;
            this.TypeName = typeName ?? throw new global::System.ArgumentNullException(nameof(typeName));
            this.TypeIcon = typeIcon;
            this.Website = website;
            this.Devsite = devsite;
            this.Docsite = docsite;
            this.Icon = icon;
            this.BackgroundColor = backgroundColor;
            this.AccentColor = accentColor;
            this.SupportedSubjectTypes = supportedSubjectTypes ?? throw new global::System.ArgumentNullException(nameof(supportedSubjectTypes));
            this.AppTokens = appTokens;
            this.UserTokens = userTokens;
            this.SupportsInstallation = supportsInstallation;
            this.SupportsRevocation = supportsRevocation;
            this.SupportsTriggers = supportsTriggers;
            this.SupportsIcon = supportsIcon;
            this.Triggers = triggers;
            this.Events = events;
            this.TriggerDestinations = triggerDestinations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnector" /> class.
        /// </summary>
        public ConnectConnector()
        {
        }

    }
}