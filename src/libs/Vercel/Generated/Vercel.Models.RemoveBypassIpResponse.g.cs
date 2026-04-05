
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveBypassIpResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBypassIpResponse" /> class.
        /// </summary>
        /// <param name="ok"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBypassIpResponse(
            bool ok)
        {
            this.Ok = ok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBypassIpResponse" /> class.
        /// </summary>
        public RemoveBypassIpResponse()
        {
        }
    }
}