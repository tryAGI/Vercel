
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectProtectionBypassResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionBypass")]
        public object? ProtectionBypass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassResponse" /> class.
        /// </summary>
        /// <param name="protectionBypass"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectProtectionBypassResponse(
            object? protectionBypass)
        {
            this.ProtectionBypass = protectionBypass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassResponse" /> class.
        /// </summary>
        public UpdateProjectProtectionBypassResponse()
        {
        }
    }
}