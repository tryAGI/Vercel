
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant163Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionZeroConfigFailover")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FunctionZeroConfigFailover { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant163Next" /> class.
        /// </summary>
        /// <param name="functionZeroConfigFailover"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant163Next(
            bool functionZeroConfigFailover)
        {
            this.FunctionZeroConfigFailover = functionZeroConfigFailover;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant163Next" /> class.
        /// </summary>
        public UserEventPayloadVariant163Next()
        {
        }
    }
}