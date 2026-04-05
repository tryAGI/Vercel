
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The canary deployment being rolled out<br/>
    /// Example: {"id":"dpl_def456","name":"my-shop@9c7e2f4","url":"9c7e2f4-my-shop.vercel.app","target":"production","source":"git","createdAt":1716210100000,"readyState":"READY","readyStateAt":1716210400000}
    /// </summary>
    public sealed partial class CompleteRollingReleaseResponseRollingReleaseCanaryDeployment
    {
        /// <summary>
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </summary>
        /// <example>my-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </summary>
        /// <example>dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
        /// Example: READY
        /// </summary>
        /// <example>READY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState ReadyState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyStateAt")]
        public double? ReadyStateAt { get; set; }

        /// <summary>
        /// Where was the deployment created from<br/>
        /// Example: cli
        /// </summary>
        /// <example>cli</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSourceJsonConverter))]
        public global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource? Source { get; set; }

        /// <summary>
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTargetJsonConverter))]
        public global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget? Target { get; set; }

        /// <summary>
        /// A string with the unique URL of the deployment<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </summary>
        /// <example>my-instant-deployment-3ij3cxz9qr.now.sh</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteRollingReleaseResponseRollingReleaseCanaryDeployment" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </param>
        /// <param name="createdAt">
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="id">
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </param>
        /// <param name="readyState">
        /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
        /// Example: READY
        /// </param>
        /// <param name="url">
        /// A string with the unique URL of the deployment<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </param>
        /// <param name="readyStateAt"></param>
        /// <param name="source">
        /// Where was the deployment created from<br/>
        /// Example: cli
        /// </param>
        /// <param name="target">
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteRollingReleaseResponseRollingReleaseCanaryDeployment(
            string name,
            double createdAt,
            string id,
            global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState readyState,
            string url,
            double? readyStateAt,
            global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentSource? source,
            global::Vercel.CompleteRollingReleaseResponseRollingReleaseCanaryDeploymentTarget? target)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ReadyState = readyState;
            this.ReadyStateAt = readyStateAt;
            this.Source = source;
            this.Target = target;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteRollingReleaseResponseRollingReleaseCanaryDeployment" /> class.
        /// </summary>
        public CompleteRollingReleaseResponseRollingReleaseCanaryDeployment()
        {
        }
    }
}