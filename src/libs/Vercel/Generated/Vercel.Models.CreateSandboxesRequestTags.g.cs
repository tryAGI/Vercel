
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
    /// Example: {"env":"staging","team":"platform"}
    /// </summary>
    public sealed partial class CreateSandboxesRequestTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}