
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRollingReleaseConfigResponseVariant2RollingRelease
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stages")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage>? Stages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRollingReleaseConfigResponseVariant2RollingRelease" /> class.
        /// </summary>
        /// <param name="stages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRollingReleaseConfigResponseVariant2RollingRelease(
            global::System.Collections.Generic.IList<global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage>? stages)
        {
            this.Stages = stages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRollingReleaseConfigResponseVariant2RollingRelease" /> class.
        /// </summary>
        public UpdateRollingReleaseConfigResponseVariant2RollingRelease()
        {
        }
    }
}