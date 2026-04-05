
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Resources to define the VM
    /// </summary>
    public sealed partial class CreateSandboxRequestResources
    {
        /// <summary>
        /// The number of virtual CPUs to allocate to the sandbox. Must be 1, or an even number.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpus")]
        public int? Vcpus { get; set; }

        /// <summary>
        /// The amount of memory in megabytes to allocate to the sandbox. Must equal vcpus * 2048.<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public int? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestResources" /> class.
        /// </summary>
        /// <param name="vcpus">
        /// The number of virtual CPUs to allocate to the sandbox. Must be 1, or an even number.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="memory">
        /// The amount of memory in megabytes to allocate to the sandbox. Must equal vcpus * 2048.<br/>
        /// Example: 4096
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxRequestResources(
            int? vcpus,
            int? memory)
        {
            this.Vcpus = vcpus;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestResources" /> class.
        /// </summary>
        public CreateSandboxRequestResources()
        {
        }
    }
}