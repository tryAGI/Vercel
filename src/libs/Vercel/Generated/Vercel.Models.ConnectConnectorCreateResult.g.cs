
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Connector created by the request.
    /// </summary>
    public sealed partial class ConnectConnectorCreateResult
    {
        /// <summary>
        /// Hex accent color (e.g., `#000000`) for branding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accentColor")]
        public string? AccentColor { get; set; }

        /// <summary>
        /// App-token capabilities and known grants for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appTokens")]
        public global::Vercel.ConnectConnectorCreateResultAppTokens? AppTokens { get; set; }

        /// <summary>
        /// Hex background color (e.g., `#000000`) for branding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundColor")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Provider-side URL for viewing or managing the resource represented by the connector. The destination can be an app, account, phone line, or service instance, depending on the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientUrl")]
        public string? ClientUrl { get; set; }

        /// <summary>
        /// The connection method this connector was created from, when the create request named one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionMethod")]
        public string? ConnectionMethod { get; set; }

        /// <summary>
        /// Creation time in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Principal that created the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2>))]
        public global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2>? CreatedBy { get; set; }

        /// <summary>
        /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateResultCreationModeJsonConverter))]
        public global::Vercel.ConnectConnectorCreateResultCreationMode? CreationMode { get; set; }

        /// <summary>
        /// Installation used when a token request does not specify an installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultInstallationId")]
        public string? DefaultInstallationId { get; set; }

        /// <summary>
        /// Developer website for the connected service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devsite")]
        public string? Devsite { get; set; }

        /// <summary>
        /// Human-readable connector name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Developer documentation for the connected service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docsite")]
        public string? Docsite { get; set; }

        /// <summary>
        /// Known events this connector subscribes to (e.g. Slack bot events, GitHub webhook events). Names are type-specific and validated by the managed-create flow when forwarded to the third-party service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Connector branding icon. SHA-1 hash that resolves to the uploaded icon through the Vercel avatar service. Consumers render this with `https://vercel.com/api/www/avatar/{icon}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Stable `scl_` connector ID. Use this value directly in `{connector}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the connector is known to have been edited since the app package it publishes to the provider was last built, so that package no longer matches it. Absent when it was not computed, or when the connector type publishes no such package. Derived on every read rather than marked at edit time, so reverting an edit clears it. Only reported by connector types that publish a package a user has to re-publish by hand — Microsoft Teams today.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knownStale")]
        public bool? KnownStale { get; set; }

        /// <summary>
        /// Managed connector metadata exposed without leaking the manager connector or installation identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed")]
        public global::Vercel.ConnectConnectorCreateResultManaged? Managed { get; set; }

        /// <summary>
        /// Connector name within the owning team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Redirect URI registered with the third-party service for this connector, if any. Used by `startAuthorization`/`startInstallation` to replay the exact URI back to the provider's token endpoint. Absent on connectors created before this field was introduced; those callers fall back to the `https://connect.vercel.com/callback` default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// Time when this connector started requiring reinstallation because an installation-affecting app-token grant changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinstallAt")]
        public double? ReinstallAt { get; set; }

        /// <summary>
        /// Best-effort identifier of the third-party service this connector represents, independent of `type`. Examples: `'slack'`, `'mcp.linear.app'`, and `'auth.example.com'`. Always present in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Token subject types supported by the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedSubjectTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedSubjectTypes { get; set; }

        /// <summary>
        /// Whether the connector icon can propagate to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsIcon")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateResultSupportsIconJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorCreateResultSupportsIcon SupportsIcon { get; set; }

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
        /// Which of the service's products/surfaces this connector points at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Destinations that incoming triggers should be forwarded to. Limited to 3 entries. Set the initial destination with `triggerDestination` during creation. Replace the complete set with `PATCH /v1/connect/connectors/{connector}/trigger-destinations`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerDestinations")]
        public global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestination>? TriggerDestinations { get; set; }

        /// <summary>
        /// Incoming trigger configuration. Only present when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::Vercel.ConnectTriggerConfiguration? Triggers { get; set; }

        /// <summary>
        /// Connector implementation type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorCreateResultTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorCreateResultType Type { get; set; }

        /// <summary>
        /// Icon identifier supplied by the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeIcon")]
        public string? TypeIcon { get; set; }

        /// <summary>
        /// Human-readable name of the connector type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeName { get; set; }

        /// <summary>
        /// Team-scoped UID. URL-encode this value before using it in `{connector}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Last update time in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Principal that most recently updated the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2>))]
        public global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2>? UpdatedBy { get; set; }

        /// <summary>
        /// User-token capabilities and known grants for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userTokens")]
        public global::Vercel.ConnectConnectorCreateResultUserTokens? UserTokens { get; set; }

        /// <summary>
        /// Public website for the connected service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateResult" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Creation time in epoch milliseconds.
        /// </param>
        /// <param name="displayName">
        /// Human-readable connector name.
        /// </param>
        /// <param name="id">
        /// Stable `scl_` connector ID. Use this value directly in `{connector}`.
        /// </param>
        /// <param name="name">
        /// Connector name within the owning team.
        /// </param>
        /// <param name="service">
        /// Best-effort identifier of the third-party service this connector represents, independent of `type`. Examples: `'slack'`, `'mcp.linear.app'`, and `'auth.example.com'`. Always present in API responses.
        /// </param>
        /// <param name="supportedSubjectTypes">
        /// Token subject types supported by the connector.
        /// </param>
        /// <param name="supportsIcon">
        /// Whether the connector icon can propagate to the provider.
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
        /// <param name="type">
        /// Connector implementation type.
        /// </param>
        /// <param name="typeName">
        /// Human-readable name of the connector type.
        /// </param>
        /// <param name="uid">
        /// Team-scoped UID. URL-encode this value before using it in `{connector}`.
        /// </param>
        /// <param name="updatedAt">
        /// Last update time in epoch milliseconds.
        /// </param>
        /// <param name="accentColor">
        /// Hex accent color (e.g., `#000000`) for branding.
        /// </param>
        /// <param name="appTokens">
        /// App-token capabilities and known grants for the connector.
        /// </param>
        /// <param name="backgroundColor">
        /// Hex background color (e.g., `#000000`) for branding.
        /// </param>
        /// <param name="clientUrl">
        /// Provider-side URL for viewing or managing the resource represented by the connector. The destination can be an app, account, phone line, or service instance, depending on the connector type.
        /// </param>
        /// <param name="connectionMethod">
        /// The connection method this connector was created from, when the create request named one.
        /// </param>
        /// <param name="createdBy">
        /// Principal that created the connector.
        /// </param>
        /// <param name="creationMode">
        /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
        /// </param>
        /// <param name="defaultInstallationId">
        /// Installation used when a token request does not specify an installation.
        /// </param>
        /// <param name="devsite">
        /// Developer website for the connected service.
        /// </param>
        /// <param name="docsite">
        /// Developer documentation for the connected service.
        /// </param>
        /// <param name="events">
        /// Known events this connector subscribes to (e.g. Slack bot events, GitHub webhook events). Names are type-specific and validated by the managed-create flow when forwarded to the third-party service.
        /// </param>
        /// <param name="icon">
        /// Connector branding icon. SHA-1 hash that resolves to the uploaded icon through the Vercel avatar service. Consumers render this with `https://vercel.com/api/www/avatar/{icon}`.
        /// </param>
        /// <param name="knownStale">
        /// Whether the connector is known to have been edited since the app package it publishes to the provider was last built, so that package no longer matches it. Absent when it was not computed, or when the connector type publishes no such package. Derived on every read rather than marked at edit time, so reverting an edit clears it. Only reported by connector types that publish a package a user has to re-publish by hand — Microsoft Teams today.
        /// </param>
        /// <param name="managed">
        /// Managed connector metadata exposed without leaking the manager connector or installation identifiers.
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI registered with the third-party service for this connector, if any. Used by `startAuthorization`/`startInstallation` to replay the exact URI back to the provider's token endpoint. Absent on connectors created before this field was introduced; those callers fall back to the `https://connect.vercel.com/callback` default.
        /// </param>
        /// <param name="reinstallAt">
        /// Time when this connector started requiring reinstallation because an installation-affecting app-token grant changed.
        /// </param>
        /// <param name="target">
        /// Which of the service's products/surfaces this connector points at.
        /// </param>
        /// <param name="triggerDestinations">
        /// Destinations that incoming triggers should be forwarded to. Limited to 3 entries. Set the initial destination with `triggerDestination` during creation. Replace the complete set with `PATCH /v1/connect/connectors/{connector}/trigger-destinations`.
        /// </param>
        /// <param name="triggers">
        /// Incoming trigger configuration. Only present when enabled.
        /// </param>
        /// <param name="typeIcon">
        /// Icon identifier supplied by the connector type.
        /// </param>
        /// <param name="updatedBy">
        /// Principal that most recently updated the connector.
        /// </param>
        /// <param name="userTokens">
        /// User-token capabilities and known grants for the connector.
        /// </param>
        /// <param name="website">
        /// Public website for the connected service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateResult(
            double createdAt,
            string displayName,
            string id,
            string name,
            string service,
            global::System.Collections.Generic.IList<string> supportedSubjectTypes,
            global::Vercel.ConnectConnectorCreateResultSupportsIcon supportsIcon,
            bool supportsInstallation,
            bool supportsRevocation,
            bool supportsTriggers,
            global::Vercel.ConnectConnectorCreateResultType type,
            string typeName,
            string uid,
            double updatedAt,
            string? accentColor,
            global::Vercel.ConnectConnectorCreateResultAppTokens? appTokens,
            string? backgroundColor,
            string? clientUrl,
            string? connectionMethod,
            global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2>? createdBy,
            global::Vercel.ConnectConnectorCreateResultCreationMode? creationMode,
            string? defaultInstallationId,
            string? devsite,
            string? docsite,
            global::System.Collections.Generic.IList<string>? events,
            string? icon,
            bool? knownStale,
            global::Vercel.ConnectConnectorCreateResultManaged? managed,
            string? redirectUri,
            double? reinstallAt,
            string? target,
            global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestination>? triggerDestinations,
            global::Vercel.ConnectTriggerConfiguration? triggers,
            string? typeIcon,
            global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2>? updatedBy,
            global::Vercel.ConnectConnectorCreateResultUserTokens? userTokens,
            string? website)
        {
            this.AccentColor = accentColor;
            this.AppTokens = appTokens;
            this.BackgroundColor = backgroundColor;
            this.ClientUrl = clientUrl;
            this.ConnectionMethod = connectionMethod;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.CreationMode = creationMode;
            this.DefaultInstallationId = defaultInstallationId;
            this.Devsite = devsite;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Docsite = docsite;
            this.Events = events;
            this.Icon = icon;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KnownStale = knownStale;
            this.Managed = managed;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RedirectUri = redirectUri;
            this.ReinstallAt = reinstallAt;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.SupportedSubjectTypes = supportedSubjectTypes ?? throw new global::System.ArgumentNullException(nameof(supportedSubjectTypes));
            this.SupportsIcon = supportsIcon;
            this.SupportsInstallation = supportsInstallation;
            this.SupportsRevocation = supportsRevocation;
            this.SupportsTriggers = supportsTriggers;
            this.Target = target;
            this.TriggerDestinations = triggerDestinations;
            this.Triggers = triggers;
            this.Type = type;
            this.TypeIcon = typeIcon;
            this.TypeName = typeName ?? throw new global::System.ArgumentNullException(nameof(typeName));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.UserTokens = userTokens;
            this.Website = website;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateResult" /> class.
        /// </summary>
        public ConnectConnectorCreateResult()
        {
        }

    }
}