
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTeamRequest
    {
        /// <summary>
        /// Optional array of objects that describe the reason why the team is being deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasons")]
        public global::System.Collections.Generic.IList<global::Vercel.DeleteTeamRequestReason>? Reasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamRequest" /> class.
        /// </summary>
        /// <param name="reasons">
        /// Optional array of objects that describe the reason why the team is being deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTeamRequest(
            global::System.Collections.Generic.IList<global::Vercel.DeleteTeamRequestReason>? reasons)
        {
            this.Reasons = reasons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamRequest" /> class.
        /// </summary>
        public DeleteTeamRequest()
        {
        }
    }
}