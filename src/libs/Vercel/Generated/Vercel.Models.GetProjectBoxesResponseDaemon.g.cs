
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemon
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonConfig Config { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The deployment whose daemons this configuration comes from. Absent for daemons managed through the daemons API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonInstances Instances { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1, global::Vercel.GetProjectBoxesResponseDaemonScopeVariant2, global::Vercel.GetProjectBoxesResponseDaemonScopeVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1, global::Vercel.GetProjectBoxesResponseDaemonScopeVariant2, global::Vercel.GetProjectBoxesResponseDaemonScopeVariant3> Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectBoxesResponseDaemonStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemon" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="createdAt"></param>
        /// <param name="instances"></param>
        /// <param name="name"></param>
        /// <param name="scope"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
        /// <param name="deploymentId">
        /// The deployment whose daemons this configuration comes from. Absent for daemons managed through the daemons API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemon(
            global::Vercel.GetProjectBoxesResponseDaemonConfig config,
            string createdAt,
            global::Vercel.GetProjectBoxesResponseDaemonInstances instances,
            string name,
            global::Vercel.OneOf<global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1, global::Vercel.GetProjectBoxesResponseDaemonScopeVariant2, global::Vercel.GetProjectBoxesResponseDaemonScopeVariant3> scope,
            global::Vercel.GetProjectBoxesResponseDaemonStatus status,
            string updatedAt,
            string? deploymentId)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DeploymentId = deploymentId;
            this.Instances = instances ?? throw new global::System.ArgumentNullException(nameof(instances));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scope = scope;
            this.Status = status;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemon" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemon()
        {
        }

    }
}