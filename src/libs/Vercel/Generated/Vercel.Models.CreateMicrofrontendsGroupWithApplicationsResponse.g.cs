
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMicrofrontendsGroupWithApplicationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newMicrofrontendsGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateMicrofrontendsGroupWithApplicationsResponseNewMicrofrontendsGroup NewMicrofrontendsGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrofrontendsGroupWithApplicationsResponse" /> class.
        /// </summary>
        /// <param name="newMicrofrontendsGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMicrofrontendsGroupWithApplicationsResponse(
            global::Vercel.CreateMicrofrontendsGroupWithApplicationsResponseNewMicrofrontendsGroup newMicrofrontendsGroup)
        {
            this.NewMicrofrontendsGroup = newMicrofrontendsGroup ?? throw new global::System.ArgumentNullException(nameof(newMicrofrontendsGroup));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrofrontendsGroupWithApplicationsResponse" /> class.
        /// </summary>
        public CreateMicrofrontendsGroupWithApplicationsResponse()
        {
        }
    }
}