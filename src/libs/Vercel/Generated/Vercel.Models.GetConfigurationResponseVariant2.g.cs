
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The configuration with the provided id
    /// </summary>
    public sealed partial class GetConfigurationResponseVariant2
    {
        /// <summary>
        /// A timestamp that tells you when the configuration was installed successfully<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// A timestamp that tells you when the configuration was created<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The unique identifier of the configuration<br/>
        /// Example: icfg_3bwCLgxL8qt5kjRLcv2Dit7F
        /// </summary>
        /// <example>icfg_3bwCLgxL8qt5kjRLcv2Dit7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier of the app the configuration was created for<br/>
        /// Example: oac_xzpVzcUOgcB1nrVlirtKhbWV
        /// </summary>
        /// <example>oac_xzpVzcUOgcB1nrVlirtKhbWV</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// The user or team ID that owns the configuration<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </summary>
        /// <example>kr1PsOIzqEL5Xg6M4VZcZosf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The configuration status. Optional. If not defined, assume 'ready'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant2StatusJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant2Status? Status { get; set; }

        /// <summary>
        /// An external identifier defined by the integration vendor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// When a configuration is limited to access certain projects, this will contain each of the project ID it is allowed to access. If it is not defined, the configuration has full access.<br/>
        /// Example: [prj_xQxbutw1HpL6HLYPAzt5h75m8NjO]
        /// </summary>
        /// <example>[prj_xQxbutw1HpL6HLYPAzt5h75m8NjO]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<string>? Projects { get; set; }

        /// <summary>
        /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
        /// Example: marketplace
        /// </summary>
        /// <example>marketplace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant2SourceJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant2Source? Source { get; set; }

        /// <summary>
        /// The slug of the integration the configuration is created for.<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// When the configuration was created for a team, this will show the ID of the team.<br/>
        /// Example: team_nLlpyC6RE1qxydlFKbrxDlud
        /// </summary>
        /// <example>team_nLlpyC6RE1qxydlFKbrxDlud</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant2TypeJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant2Type Type { get; set; }

        /// <summary>
        /// A timestamp that tells you when the configuration was updated.<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the user that created the configuration.<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </summary>
        /// <example>kr1PsOIzqEL5Xg6M4VZcZosf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The resources that are allowed to be accessed by the configuration.<br/>
        /// Example: [read:project, read-write:log-drain]
        /// </summary>
        /// <example>[read:project, read-write:log-drain]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// A timestamp that tells you when the configuration was disabled. Note: Configurations can be disabled when the associated user loses access to a team. They do not function during this time until the configuration is 'transferred', meaning the associated user is changed to one with access to the team.<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        /// A timestamp that tells you when the configuration was deleted.<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// A timestamp that tells you when the configuration deletion has been started for cases when the deletion needs to be settled/approved by partners, such as when marketplace invoices have been paid.<br/>
        /// Example: 1558531915505L
        /// </summary>
        /// <example>1558531915505L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteRequestedAt")]
        public double? DeleteRequestedAt { get; set; }

        /// <summary>
        /// Record when the customer initited deletion, independent of whether `deleteRequestedAt` gets set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerDeleteRequestedAt")]
        public double? CustomerDeleteRequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant2DisabledReasonJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant2DisabledReason? DisabledReason { get; set; }

        /// <summary>
        /// Defines the installation type. - 'external' integrations are installed via the existing integrations flow - 'marketplace' integrations are natively installed: - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationResponseVariant2InstallationTypeJsonConverter))]
        public global::Vercel.GetConfigurationResponseVariant2InstallationType? InstallationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant2" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// A timestamp that tells you when the configuration was created<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="id">
        /// The unique identifier of the configuration<br/>
        /// Example: icfg_3bwCLgxL8qt5kjRLcv2Dit7F
        /// </param>
        /// <param name="integrationId">
        /// The unique identifier of the app the configuration was created for<br/>
        /// Example: oac_xzpVzcUOgcB1nrVlirtKhbWV
        /// </param>
        /// <param name="ownerId">
        /// The user or team ID that owns the configuration<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </param>
        /// <param name="slug">
        /// The slug of the integration the configuration is created for.<br/>
        /// Example: slack
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp that tells you when the configuration was updated.<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="userId">
        /// The ID of the user that created the configuration.<br/>
        /// Example: kr1PsOIzqEL5Xg6M4VZcZosf
        /// </param>
        /// <param name="scopes">
        /// The resources that are allowed to be accessed by the configuration.<br/>
        /// Example: [read:project, read-write:log-drain]
        /// </param>
        /// <param name="completedAt">
        /// A timestamp that tells you when the configuration was installed successfully<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="status">
        /// The configuration status. Optional. If not defined, assume 'ready'.
        /// </param>
        /// <param name="externalId">
        /// An external identifier defined by the integration vendor.
        /// </param>
        /// <param name="projects">
        /// When a configuration is limited to access certain projects, this will contain each of the project ID it is allowed to access. If it is not defined, the configuration has full access.<br/>
        /// Example: [prj_xQxbutw1HpL6HLYPAzt5h75m8NjO]
        /// </param>
        /// <param name="source">
        /// Source defines where the configuration was installed from. It is used to analyze user engagement for integration installations in product metrics.<br/>
        /// Example: marketplace
        /// </param>
        /// <param name="teamId">
        /// When the configuration was created for a team, this will show the ID of the team.<br/>
        /// Example: team_nLlpyC6RE1qxydlFKbrxDlud
        /// </param>
        /// <param name="type"></param>
        /// <param name="disabledAt">
        /// A timestamp that tells you when the configuration was disabled. Note: Configurations can be disabled when the associated user loses access to a team. They do not function during this time until the configuration is 'transferred', meaning the associated user is changed to one with access to the team.<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="deletedAt">
        /// A timestamp that tells you when the configuration was deleted.<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="deleteRequestedAt">
        /// A timestamp that tells you when the configuration deletion has been started for cases when the deletion needs to be settled/approved by partners, such as when marketplace invoices have been paid.<br/>
        /// Example: 1558531915505L
        /// </param>
        /// <param name="customerDeleteRequestedAt">
        /// Record when the customer initited deletion, independent of whether `deleteRequestedAt` gets set.
        /// </param>
        /// <param name="disabledReason"></param>
        /// <param name="installationType">
        /// Defines the installation type. - 'external' integrations are installed via the existing integrations flow - 'marketplace' integrations are natively installed: - when accepting the TOS of a partner during the store creation process - if undefined, assume 'external'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationResponseVariant2(
            double createdAt,
            string id,
            string integrationId,
            string ownerId,
            string slug,
            double updatedAt,
            string userId,
            global::System.Collections.Generic.IList<string> scopes,
            double? completedAt,
            global::Vercel.GetConfigurationResponseVariant2Status? status,
            string? externalId,
            global::System.Collections.Generic.IList<string>? projects,
            global::Vercel.GetConfigurationResponseVariant2Source? source,
            string? teamId,
            global::Vercel.GetConfigurationResponseVariant2Type type,
            double? disabledAt,
            double? deletedAt,
            double? deleteRequestedAt,
            double? customerDeleteRequestedAt,
            global::Vercel.GetConfigurationResponseVariant2DisabledReason? disabledReason,
            global::Vercel.GetConfigurationResponseVariant2InstallationType? installationType)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Status = status;
            this.ExternalId = externalId;
            this.Projects = projects;
            this.Source = source;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.TeamId = teamId;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.DisabledAt = disabledAt;
            this.DeletedAt = deletedAt;
            this.DeleteRequestedAt = deleteRequestedAt;
            this.CustomerDeleteRequestedAt = customerDeleteRequestedAt;
            this.DisabledReason = disabledReason;
            this.InstallationType = installationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationResponseVariant2" /> class.
        /// </summary>
        public GetConfigurationResponseVariant2()
        {
        }
    }
}