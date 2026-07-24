
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// Time when this connector started requiring reinstallation because an installation-affecting app-token grant changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinstallAt")]
        public double? ReinstallAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateConnectorResponseCreatedByVariant1, global::Vercel.CreateConnectorResponseCreatedByVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateConnectorResponseCreatedByVariant1, global::Vercel.CreateConnectorResponseCreatedByVariant2>? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateConnectorResponseUpdatedByVariant1, global::Vercel.CreateConnectorResponseUpdatedByVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateConnectorResponseUpdatedByVariant1, global::Vercel.CreateConnectorResponseUpdatedByVariant2>? UpdatedBy { get; set; }

        /// <summary>
        /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorResponseCreationModeJsonConverter))]
        public global::Vercel.CreateConnectorResponseCreationMode? CreationMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateConnectorResponseType Type { get; set; }

        /// <summary>
        /// Best-effort identifier of the third-party service this client represents, independent of `type`. Examples: `'slack'`, `'mcp.linear.app'`, `'auth.example.com'`. Always non-empty on the API response — falls back through `storedClient.service ?? typeDef.service ?? typeDef.type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientUrl")]
        public string? ClientUrl { get; set; }

        /// <summary>
        /// Redirect URI registered with the third-party service for this client, if any. Used by `startAuthorization`/`startInstallation` to replay the exact URI back to the provider's token endpoint. Absent on clients created before this field was introduced; those callers fall back to the `https://connect.vercel.com/callback` default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultInstallationId")]
        public string? DefaultInstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeIcon")]
        public string? TypeIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devsite")]
        public string? Devsite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docsite")]
        public string? Docsite { get; set; }

        /// <summary>
        /// Client branding icon. SHA-1 hash that resolves to the uploaded icon via the Vercel avatar service. Clients render this with `https://vercel.com/api/www/avatar/{icon}`.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedSubjectTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedSubjectTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appTokens")]
        public global::Vercel.CreateConnectorResponseAppTokens? AppTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userTokens")]
        public global::Vercel.CreateConnectorResponseUserTokens? UserTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsInstallation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsInstallation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsRevocation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsRevocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerTenantId")]
        public string? OwnerTenantId { get; set; }

        /// <summary>
        /// Whether this client type supports trigger webhooks. Derived from the type definition; indicates that `triggers` and `triggerDestinations` may be meaningful for this client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsTriggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsTriggers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsIcon")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorResponseSupportsIconJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateConnectorResponseSupportsIcon SupportsIcon { get; set; }

        /// <summary>
        /// Incoming trigger configuration. Only present when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::Vercel.CreateConnectorResponseTriggers? Triggers { get; set; }

        /// <summary>
        /// Known events this client subscribes to (e.g. Slack bot events, GitHub webhook events). Names are type-specific and validated by the managed-create flow when forwarded to the third-party service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Destinations that incoming triggers should be forwarded to. Limited to `MAX_CONNEX_TRIGGER_DESTINATIONS` entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerDestinations")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseTriggerDestination>? TriggerDestinations { get; set; }

        /// <summary>
        /// Whether this connector is linked to the project supplied through `prioritizedProjectId`. Only present on prioritized list responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isConnectedToPrioritizedProject")]
        public bool? IsConnectedToPrioritizedProject { get; set; }

        /// <summary>
        /// Optional expansions populated by `?include=...` on the list endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes")]
        public global::Vercel.CreateConnectorResponseIncludes? Includes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ownerId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="public"></param>
        /// <param name="uid"></param>
        /// <param name="type"></param>
        /// <param name="service">
        /// Best-effort identifier of the third-party service this client represents, independent of `type`. Examples: `'slack'`, `'mcp.linear.app'`, `'auth.example.com'`. Always non-empty on the API response — falls back through `storedClient.service ?? typeDef.service ?? typeDef.type`.
        /// </param>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <param name="typeName"></param>
        /// <param name="supportedSubjectTypes"></param>
        /// <param name="supportsInstallation"></param>
        /// <param name="supportsRevocation"></param>
        /// <param name="supportsTriggers">
        /// Whether this client type supports trigger webhooks. Derived from the type definition; indicates that `triggers` and `triggerDestinations` may be meaningful for this client.
        /// </param>
        /// <param name="supportsIcon"></param>
        /// <param name="deletedAt"></param>
        /// <param name="reinstallAt">
        /// Time when this connector started requiring reinstallation because an installation-affecting app-token grant changed.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="updatedBy"></param>
        /// <param name="creationMode">
        /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
        /// </param>
        /// <param name="clientUrl"></param>
        /// <param name="redirectUri">
        /// Redirect URI registered with the third-party service for this client, if any. Used by `startAuthorization`/`startInstallation` to replay the exact URI back to the provider's token endpoint. Absent on clients created before this field was introduced; those callers fall back to the `https://connect.vercel.com/callback` default.
        /// </param>
        /// <param name="defaultInstallationId"></param>
        /// <param name="typeIcon"></param>
        /// <param name="website"></param>
        /// <param name="devsite"></param>
        /// <param name="docsite"></param>
        /// <param name="icon">
        /// Client branding icon. SHA-1 hash that resolves to the uploaded icon via the Vercel avatar service. Clients render this with `https://vercel.com/api/www/avatar/{icon}`.
        /// </param>
        /// <param name="backgroundColor">
        /// Hex background color (e.g., `#000000`) for branding.
        /// </param>
        /// <param name="accentColor">
        /// Hex accent color (e.g., `#000000`) for branding.
        /// </param>
        /// <param name="appTokens"></param>
        /// <param name="userTokens"></param>
        /// <param name="ownerTenantId"></param>
        /// <param name="triggers">
        /// Incoming trigger configuration. Only present when enabled.
        /// </param>
        /// <param name="events">
        /// Known events this client subscribes to (e.g. Slack bot events, GitHub webhook events). Names are type-specific and validated by the managed-create flow when forwarded to the third-party service.
        /// </param>
        /// <param name="triggerDestinations">
        /// Destinations that incoming triggers should be forwarded to. Limited to `MAX_CONNEX_TRIGGER_DESTINATIONS` entries.
        /// </param>
        /// <param name="isConnectedToPrioritizedProject">
        /// Whether this connector is linked to the project supplied through `prioritizedProjectId`. Only present on prioritized list responses.
        /// </param>
        /// <param name="includes">
        /// Optional expansions populated by `?include=...` on the list endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorResponse(
            string id,
            string ownerId,
            double createdAt,
            double updatedAt,
            bool @public,
            string uid,
            global::Vercel.CreateConnectorResponseType type,
            string service,
            string name,
            object data,
            string typeName,
            global::System.Collections.Generic.IList<string> supportedSubjectTypes,
            bool supportsInstallation,
            bool supportsRevocation,
            bool supportsTriggers,
            global::Vercel.CreateConnectorResponseSupportsIcon supportsIcon,
            double? deletedAt,
            double? reinstallAt,
            global::Vercel.OneOf<global::Vercel.CreateConnectorResponseCreatedByVariant1, global::Vercel.CreateConnectorResponseCreatedByVariant2>? createdBy,
            global::Vercel.OneOf<global::Vercel.CreateConnectorResponseUpdatedByVariant1, global::Vercel.CreateConnectorResponseUpdatedByVariant2>? updatedBy,
            global::Vercel.CreateConnectorResponseCreationMode? creationMode,
            string? clientUrl,
            string? redirectUri,
            string? defaultInstallationId,
            string? typeIcon,
            string? website,
            string? devsite,
            string? docsite,
            string? icon,
            string? backgroundColor,
            string? accentColor,
            global::Vercel.CreateConnectorResponseAppTokens? appTokens,
            global::Vercel.CreateConnectorResponseUserTokens? userTokens,
            string? ownerTenantId,
            global::Vercel.CreateConnectorResponseTriggers? triggers,
            global::System.Collections.Generic.IList<string>? events,
            global::System.Collections.Generic.IList<global::Vercel.CreateConnectorResponseTriggerDestination>? triggerDestinations,
            bool? isConnectedToPrioritizedProject,
            global::Vercel.CreateConnectorResponseIncludes? includes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            this.ReinstallAt = reinstallAt;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.CreationMode = creationMode;
            this.Public = @public;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Type = type;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ClientUrl = clientUrl;
            this.RedirectUri = redirectUri;
            this.DefaultInstallationId = defaultInstallationId;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
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
            this.OwnerTenantId = ownerTenantId;
            this.SupportsTriggers = supportsTriggers;
            this.SupportsIcon = supportsIcon;
            this.Triggers = triggers;
            this.Events = events;
            this.TriggerDestinations = triggerDestinations;
            this.IsConnectedToPrioritizedProject = isConnectedToPrioritizedProject;
            this.Includes = includes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorResponse" /> class.
        /// </summary>
        public CreateConnectorResponse()
        {
        }

    }
}