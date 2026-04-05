
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestDeleteRequest
    {
        /// <summary>
        /// Optional array of objects that describe the reason why the User account is being deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public global::System.Collections.Generic.IList<global::Vercel.RequestDeleteRequestReason>? Reasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDeleteRequest" /> class.
        /// </summary>
        /// <param name="reasons">
        /// Optional array of objects that describe the reason why the User account is being deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestDeleteRequest(
            global::System.Collections.Generic.IList<global::Vercel.RequestDeleteRequestReason>? reasons)
        {
            this.Reasons = reasons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDeleteRequest" /> class.
        /// </summary>
        public RequestDeleteRequest()
        {
        }
    }
}