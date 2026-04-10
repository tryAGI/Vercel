
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant163Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionDefaultTimeout")]
        public double? FunctionDefaultTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant163Previous" /> class.
        /// </summary>
        /// <param name="functionDefaultTimeout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant163Previous(
            double? functionDefaultTimeout)
        {
            this.FunctionDefaultTimeout = functionDefaultTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant163Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant163Previous()
        {
        }
    }
}