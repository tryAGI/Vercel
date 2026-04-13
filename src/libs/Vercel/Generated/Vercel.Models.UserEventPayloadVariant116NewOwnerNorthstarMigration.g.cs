
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An archive of information about the Northstar migration, derived from the old (deprecated) property, `northstarMigrationEvents`.
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerNorthstarMigration
    {
        /// <summary>
        /// The ID of the team we created for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The number of projects migrated for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Projects { get; set; }

        /// <summary>
        /// The number of stores migrated for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Stores { get; set; }

        /// <summary>
        /// The number of integration configurations migrated for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IntegrationConfigurations { get; set; }

        /// <summary>
        /// The number of integration clients migrated for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationClients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IntegrationClients { get; set; }

        /// <summary>
        /// The migration start time timestamp for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// The migration end time timestamp for this user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerNorthstarMigration" /> class.
        /// </summary>
        /// <param name="teamId">
        /// The ID of the team we created for this user.
        /// </param>
        /// <param name="projects">
        /// The number of projects migrated for this user.
        /// </param>
        /// <param name="stores">
        /// The number of stores migrated for this user.
        /// </param>
        /// <param name="integrationConfigurations">
        /// The number of integration configurations migrated for this user.
        /// </param>
        /// <param name="integrationClients">
        /// The number of integration clients migrated for this user.
        /// </param>
        /// <param name="startTime">
        /// The migration start time timestamp for this user.
        /// </param>
        /// <param name="endTime">
        /// The migration end time timestamp for this user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerNorthstarMigration(
            string teamId,
            double projects,
            double stores,
            double integrationConfigurations,
            double integrationClients,
            double startTime,
            double endTime)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Projects = projects;
            this.Stores = stores;
            this.IntegrationConfigurations = integrationConfigurations;
            this.IntegrationClients = integrationClients;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerNorthstarMigration" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerNorthstarMigration()
        {
        }
    }
}