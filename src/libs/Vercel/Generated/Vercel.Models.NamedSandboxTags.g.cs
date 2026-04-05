
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Key-value tags attached to the named sandbox.<br/>
    /// Example: {"team":"hive","user":"bob"}
    /// </summary>
    public sealed partial class NamedSandboxTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}