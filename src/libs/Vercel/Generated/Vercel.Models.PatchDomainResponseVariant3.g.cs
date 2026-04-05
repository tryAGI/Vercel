
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchDomainResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renew")]
        public bool? Renew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customNameservers")]
        public global::System.Collections.Generic.IList<string>? CustomNameservers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone")]
        public bool? Zone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainResponseVariant3" /> class.
        /// </summary>
        /// <param name="renew"></param>
        /// <param name="customNameservers"></param>
        /// <param name="zone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDomainResponseVariant3(
            bool? renew,
            global::System.Collections.Generic.IList<string>? customNameservers,
            bool? zone)
        {
            this.Renew = renew;
            this.CustomNameservers = customNameservers;
            this.Zone = zone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainResponseVariant3" /> class.
        /// </summary>
        public PatchDomainResponseVariant3()
        {
        }
    }
}