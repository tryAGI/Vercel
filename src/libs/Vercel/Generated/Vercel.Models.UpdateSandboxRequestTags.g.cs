
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Key-value tags to associate with the sandbox. Replaces existing tags. Set to empty object to clear. Maximum 5 tags.<br/>
    /// Example: {"env":"staging","team":"platform"}
    /// </summary>
    public sealed partial class UpdateSandboxRequestTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}