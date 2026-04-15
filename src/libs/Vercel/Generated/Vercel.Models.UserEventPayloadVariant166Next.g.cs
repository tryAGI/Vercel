
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant166Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultTimeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FunctionDefaultTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant166Next" /> class.
        /// </summary>
        /// <param name="functionDefaultTimeout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant166Next(
            double functionDefaultTimeout)
        {
            this.FunctionDefaultTimeout = functionDefaultTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant166Next" /> class.
        /// </summary>
        public UserEventPayloadVariant166Next()
        {
        }
    }
}