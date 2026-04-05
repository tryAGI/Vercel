
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamResourceConfig
    {
        /// <summary>
        /// The total amount of concurrent builds that can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentBuilds")]
        public double? ConcurrentBuilds { get; set; }

        /// <summary>
        /// Whether every build for this team / user has elastic concurrency enabled automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elasticConcurrencyEnabled")]
        public bool? ElasticConcurrencyEnabled { get; set; }

        /// <summary>
        /// The maximum size in kilobytes of an Edge Config. Only specified if a custom limit is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigSize")]
        public double? EdgeConfigSize { get; set; }

        /// <summary>
        /// The maximum number of edge configs an account can create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfigs")]
        public double? EdgeConfigs { get; set; }

        /// <summary>
        /// The maximum number of kv databases an account can create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kvDatabases")]
        public double? KvDatabases { get; set; }

        /// <summary>
        /// The maximum number of blob stores an account can create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobStores")]
        public double? BlobStores { get; set; }

        /// <summary>
        /// The maximum number of postgres databases an account can create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postgresDatabases")]
        public double? PostgresDatabases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildEntitlements")]
        public global::Vercel.TeamResourceConfigBuildEntitlements? BuildEntitlements { get; set; }

        /// <summary>
        /// Build machine configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildMachine")]
        public global::Vercel.TeamResourceConfigBuildMachine? BuildMachine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamResourceConfig" /> class.
        /// </summary>
        /// <param name="concurrentBuilds">
        /// The total amount of concurrent builds that can be used.
        /// </param>
        /// <param name="elasticConcurrencyEnabled">
        /// Whether every build for this team / user has elastic concurrency enabled automatically.
        /// </param>
        /// <param name="edgeConfigSize">
        /// The maximum size in kilobytes of an Edge Config. Only specified if a custom limit is set.
        /// </param>
        /// <param name="edgeConfigs">
        /// The maximum number of edge configs an account can create.
        /// </param>
        /// <param name="kvDatabases">
        /// The maximum number of kv databases an account can create.
        /// </param>
        /// <param name="blobStores">
        /// The maximum number of blob stores an account can create.
        /// </param>
        /// <param name="postgresDatabases">
        /// The maximum number of postgres databases an account can create.
        /// </param>
        /// <param name="buildEntitlements"></param>
        /// <param name="buildMachine">
        /// Build machine configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamResourceConfig(
            double? concurrentBuilds,
            bool? elasticConcurrencyEnabled,
            double? edgeConfigSize,
            double? edgeConfigs,
            double? kvDatabases,
            double? blobStores,
            double? postgresDatabases,
            global::Vercel.TeamResourceConfigBuildEntitlements? buildEntitlements,
            global::Vercel.TeamResourceConfigBuildMachine? buildMachine)
        {
            this.ConcurrentBuilds = concurrentBuilds;
            this.ElasticConcurrencyEnabled = elasticConcurrencyEnabled;
            this.EdgeConfigSize = edgeConfigSize;
            this.EdgeConfigs = edgeConfigs;
            this.KvDatabases = kvDatabases;
            this.BlobStores = blobStores;
            this.PostgresDatabases = postgresDatabases;
            this.BuildEntitlements = buildEntitlements;
            this.BuildMachine = buildMachine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamResourceConfig" /> class.
        /// </summary>
        public TeamResourceConfig()
        {
        }
    }
}