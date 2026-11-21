
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutOrganizationDsyncGroupRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PutOrganizationDsyncGroupRequestAssignments Assignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationDsyncGroupRequest" /> class.
        /// </summary>
        /// <param name="assignments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutOrganizationDsyncGroupRequest(
            global::Vercel.PutOrganizationDsyncGroupRequestAssignments assignments)
        {
            this.Assignments = assignments ?? throw new global::System.ArgumentNullException(nameof(assignments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutOrganizationDsyncGroupRequest" /> class.
        /// </summary>
        public PutOrganizationDsyncGroupRequest()
        {
        }

    }
}