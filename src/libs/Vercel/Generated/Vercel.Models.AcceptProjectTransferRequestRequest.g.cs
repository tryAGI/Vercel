
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestRequest
    {
        /// <summary>
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </summary>
        /// <example>a-project-name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("newProjectName")]
        public string? NewProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidFeatures")]
        public global::Vercel.AcceptProjectTransferRequestRequestPaidFeatures? PaidFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedPolicies")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AcceptProjectTransferRequestRequestAcceptedPolicies2>? AcceptedPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequest" /> class.
        /// </summary>
        /// <param name="newProjectName">
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </param>
        /// <param name="paidFeatures"></param>
        /// <param name="acceptedPolicies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestRequest(
            string? newProjectName,
            global::Vercel.AcceptProjectTransferRequestRequestPaidFeatures? paidFeatures,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AcceptProjectTransferRequestRequestAcceptedPolicies2>? acceptedPolicies)
        {
            this.NewProjectName = newProjectName;
            this.PaidFeatures = paidFeatures;
            this.AcceptedPolicies = acceptedPolicies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequest" /> class.
        /// </summary>
        public AcceptProjectTransferRequestRequest()
        {
        }
    }
}