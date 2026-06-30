
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional VHS drive configuration captured for an optimized image.
    /// </summary>
    public sealed partial class VcrImageDetailVhsConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        public global::System.Collections.Generic.IList<string>? Entrypoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workingDir")]
        public string? WorkingDir { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageDetailVhsConfig" /> class.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="entrypoint"></param>
        /// <param name="workingDir"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VcrImageDetailVhsConfig(
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.IList<string>? entrypoint,
            string? workingDir)
        {
            this.Command = command;
            this.Entrypoint = entrypoint;
            this.WorkingDir = workingDir;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcrImageDetailVhsConfig" /> class.
        /// </summary>
        public VcrImageDetailVhsConfig()
        {
        }

    }
}