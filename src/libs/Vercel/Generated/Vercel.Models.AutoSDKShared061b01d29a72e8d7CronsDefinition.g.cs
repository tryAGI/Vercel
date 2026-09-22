
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared061b01d29a72e8d7CronsDefinition
    {
        /// <summary>
        /// A human-readable description of what this cron job does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The hostname that should be used.<br/>
        /// Example: vercel.com
        /// </summary>
        /// <example>vercel.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// Whether the host was inferred from the production deployment URL rather than explicitly provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostInferred")]
        public bool? HostInferred { get; set; }

        /// <summary>
        /// The path that should be called for the cronjob.<br/>
        /// Example: /api/crons/sync-something?hello=world
        /// </summary>
        /// <example>/api/crons/sync-something?hello=world</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The cron expression.<br/>
        /// Example: 0 0 * * *
        /// </summary>
        /// <example>0 0 * * *</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schedule { get; set; }

        /// <summary>
        /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared061b01d29a72e8d7CronsDefinitionSourceJsonConverter))]
        public global::Vercel.AutoSDKShared061b01d29a72e8d7CronsDefinitionSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7CronsDefinition" /> class.
        /// </summary>
        /// <param name="host">
        /// The hostname that should be used.<br/>
        /// Example: vercel.com
        /// </param>
        /// <param name="path">
        /// The path that should be called for the cronjob.<br/>
        /// Example: /api/crons/sync-something?hello=world
        /// </param>
        /// <param name="schedule">
        /// The cron expression.<br/>
        /// Example: 0 0 * * *
        /// </param>
        /// <param name="description">
        /// A human-readable description of what this cron job does.
        /// </param>
        /// <param name="hostInferred">
        /// Whether the host was inferred from the production deployment URL rather than explicitly provided.
        /// </param>
        /// <param name="source">
        /// The origin of this definition. 'api' means created via the API. Undefined means it originated from a deployment (vercel.json).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared061b01d29a72e8d7CronsDefinition(
            string host,
            string path,
            string schedule,
            string? description,
            bool? hostInferred,
            global::Vercel.AutoSDKShared061b01d29a72e8d7CronsDefinitionSource? source)
        {
            this.Description = description;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.HostInferred = hostInferred;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared061b01d29a72e8d7CronsDefinition" /> class.
        /// </summary>
        public AutoSDKShared061b01d29a72e8d7CronsDefinition()
        {
        }

    }
}