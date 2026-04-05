
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A partial representation of a Build used by the deployment endpoint.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2Lambda
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2LambdaReadyStateJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2LambdaReadyState? ReadyState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public string? Entrypoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyStateAt")]
        public double? ReadyStateAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2LambdaOutputItem> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2Lambda" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="createdAt"></param>
        /// <param name="readyState"></param>
        /// <param name="entrypoint"></param>
        /// <param name="readyStateAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2Lambda(
            string id,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2LambdaOutputItem> output,
            double? createdAt,
            global::Vercel.GetDeploymentResponseVariant2LambdaReadyState? readyState,
            string? entrypoint,
            double? readyStateAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ReadyState = readyState;
            this.Entrypoint = entrypoint;
            this.ReadyStateAt = readyStateAt;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2Lambda" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2Lambda()
        {
        }
    }
}