
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptProjectTransferRequestRequestAcceptedPolicies2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eula")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Eula { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Privacy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequestAcceptedPolicies2" /> class.
        /// </summary>
        /// <param name="eula"></param>
        /// <param name="privacy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptProjectTransferRequestRequestAcceptedPolicies2(
            global::System.DateTime eula,
            global::System.DateTime privacy)
        {
            this.Eula = eula;
            this.Privacy = privacy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptProjectTransferRequestRequestAcceptedPolicies2" /> class.
        /// </summary>
        public AcceptProjectTransferRequestRequestAcceptedPolicies2()
        {
        }
    }
}