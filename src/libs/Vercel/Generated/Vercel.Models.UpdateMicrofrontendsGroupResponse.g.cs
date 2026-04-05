
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsGroupResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedMicrofrontendsGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsGroupResponseUpdatedMicrofrontendsGroup UpdatedMicrofrontendsGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsGroupResponse" /> class.
        /// </summary>
        /// <param name="updatedMicrofrontendsGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsGroupResponse(
            global::Vercel.UpdateMicrofrontendsGroupResponseUpdatedMicrofrontendsGroup updatedMicrofrontendsGroup)
        {
            this.UpdatedMicrofrontendsGroup = updatedMicrofrontendsGroup ?? throw new global::System.ArgumentNullException(nameof(updatedMicrofrontendsGroup));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsGroupResponse" /> class.
        /// </summary>
        public UpdateMicrofrontendsGroupResponse()
        {
        }
    }
}