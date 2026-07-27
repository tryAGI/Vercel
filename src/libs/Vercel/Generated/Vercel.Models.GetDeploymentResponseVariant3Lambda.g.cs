
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A partial representation of a Build used by the deployment endpoint.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant3Lambda
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
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3LambdaReadyStateJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3LambdaReadyState? ReadyState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant3LambdaOutputItem> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant3Lambda" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="readyState"></param>
        /// <param name="createdAt"></param>
        /// <param name="entrypoint"></param>
        /// <param name="readyStateAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant3Lambda(
            string id,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant3LambdaOutputItem> output,
            global::Vercel.GetDeploymentResponseVariant3LambdaReadyState? readyState,
            double? createdAt,
            string? entrypoint,
            double? readyStateAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ReadyState = readyState;
            this.CreatedAt = createdAt;
            this.Entrypoint = entrypoint;
            this.ReadyStateAt = readyStateAt;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant3Lambda" /> class.
        /// </summary>
        public GetDeploymentResponseVariant3Lambda()
        {
        }

    }
}