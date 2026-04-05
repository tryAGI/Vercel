
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant65Job
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployHook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant65JobDeployHook DeployHook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant65Job" /> class.
        /// </summary>
        /// <param name="deployHook"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant65Job(
            global::Vercel.UserEventPayloadVariant65JobDeployHook deployHook,
            string state)
        {
            this.DeployHook = deployHook ?? throw new global::System.ArgumentNullException(nameof(deployHook));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant65Job" /> class.
        /// </summary>
        public UserEventPayloadVariant65Job()
        {
        }
    }
}