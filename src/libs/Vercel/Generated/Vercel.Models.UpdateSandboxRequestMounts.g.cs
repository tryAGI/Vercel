
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Drives to mount to the sandbox at the provided path. Replaces the current mounts; an empty object removes them all. Changes take effect when the next session starts.
    /// </summary>
    public sealed partial class UpdateSandboxRequestMounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}