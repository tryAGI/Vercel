
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentEventsResponseVariant2Info
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public string? Entrypoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public string? Step { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        public string? ReadyState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant2Info" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="entrypoint"></param>
        /// <param name="path"></param>
        /// <param name="step"></param>
        /// <param name="readyState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentEventsResponseVariant2Info(
            string type,
            string name,
            string? entrypoint,
            string? path,
            string? step,
            string? readyState)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Entrypoint = entrypoint;
            this.Path = path;
            this.Step = step;
            this.ReadyState = readyState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant2Info" /> class.
        /// </summary>
        public GetDeploymentEventsResponseVariant2Info()
        {
        }
    }
}