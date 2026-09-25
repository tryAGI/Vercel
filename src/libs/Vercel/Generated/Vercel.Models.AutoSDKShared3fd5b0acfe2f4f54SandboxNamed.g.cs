
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared3fd5b0acfe2f4f54SandboxNamed
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workingDirectory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkingDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyAt")]
        public double? ReadyAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3fd5b0acfe2f4f54SandboxNamed" /> class.
        /// </summary>
        /// <param name="sandboxName"></param>
        /// <param name="workingDirectory"></param>
        /// <param name="readyAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared3fd5b0acfe2f4f54SandboxNamed(
            string sandboxName,
            string workingDirectory,
            double? readyAt)
        {
            this.SandboxName = sandboxName ?? throw new global::System.ArgumentNullException(nameof(sandboxName));
            this.WorkingDirectory = workingDirectory ?? throw new global::System.ArgumentNullException(nameof(workingDirectory));
            this.ReadyAt = readyAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3fd5b0acfe2f4f54SandboxNamed" /> class.
        /// </summary>
        public AutoSDKShared3fd5b0acfe2f4f54SandboxNamed()
        {
        }

    }
}