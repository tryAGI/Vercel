
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant164Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultRegions")]
        public global::System.Collections.Generic.IList<string>? FunctionDefaultRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant164Previous" /> class.
        /// </summary>
        /// <param name="functionDefaultRegions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant164Previous(
            global::System.Collections.Generic.IList<string>? functionDefaultRegions)
        {
            this.FunctionDefaultRegions = functionDefaultRegions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant164Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant164Previous()
        {
        }
    }
}