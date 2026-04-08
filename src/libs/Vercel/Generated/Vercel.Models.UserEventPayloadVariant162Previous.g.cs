
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant162Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultMemoryType")]
        public string? FunctionDefaultMemoryType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant162Previous" /> class.
        /// </summary>
        /// <param name="functionDefaultMemoryType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant162Previous(
            string? functionDefaultMemoryType)
        {
            this.FunctionDefaultMemoryType = functionDefaultMemoryType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant162Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant162Previous()
        {
        }
    }
}