
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateStaticIpsResponseItemAws
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subnetIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SubnetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityGroupId")]
        public string? SecurityGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStaticIpsResponseItemAws" /> class.
        /// </summary>
        /// <param name="subnetIds"></param>
        /// <param name="securityGroupId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStaticIpsResponseItemAws(
            global::System.Collections.Generic.IList<string> subnetIds,
            string? securityGroupId)
        {
            this.SubnetIds = subnetIds ?? throw new global::System.ArgumentNullException(nameof(subnetIds));
            this.SecurityGroupId = securityGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStaticIpsResponseItemAws" /> class.
        /// </summary>
        public UpdateStaticIpsResponseItemAws()
        {
        }
    }
}