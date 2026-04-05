
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseLambdaOutputItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseLambdaOutputItem" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="functionName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseLambdaOutputItem(
            string path,
            string functionName)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseLambdaOutputItem" /> class.
        /// </summary>
        public CreateDeploymentResponseLambdaOutputItem()
        {
        }
    }
}