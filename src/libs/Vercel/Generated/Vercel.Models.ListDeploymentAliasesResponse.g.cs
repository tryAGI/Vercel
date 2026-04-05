
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDeploymentAliasesResponse
    {
        /// <summary>
        /// A list of the aliases assigned to the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListDeploymentAliasesResponseAliase> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentAliasesResponse" /> class.
        /// </summary>
        /// <param name="aliases">
        /// A list of the aliases assigned to the deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDeploymentAliasesResponse(
            global::System.Collections.Generic.IList<global::Vercel.ListDeploymentAliasesResponseAliase> aliases)
        {
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentAliasesResponse" /> class.
        /// </summary>
        public ListDeploymentAliasesResponse()
        {
        }
    }
}