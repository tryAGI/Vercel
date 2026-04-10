
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant211PreviousProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticIps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant211PreviousProjectStaticIps StaticIps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant211PreviousProject" /> class.
        /// </summary>
        /// <param name="staticIps"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant211PreviousProject(
            global::Vercel.UserEventPayloadVariant211PreviousProjectStaticIps staticIps,
            string? id)
        {
            this.Id = id;
            this.StaticIps = staticIps ?? throw new global::System.ArgumentNullException(nameof(staticIps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant211PreviousProject" /> class.
        /// </summary>
        public UserEventPayloadVariant211PreviousProject()
        {
        }
    }
}