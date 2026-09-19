
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
        [global::System.Text.Json.Serialization.JsonPropertyName("customNameservers")]
        public global::System.Collections.Generic.IList<string>? CustomNameservers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PatchDomainResponseVariant3EchModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PatchDomainResponseVariant3EchMode EchMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renew")]
        public bool? Renew { get; set; }

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
        /// <param name="echMode"></param>
        /// <param name="customNameservers"></param>
        /// <param name="renew"></param>
        /// <param name="zone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDomainResponseVariant3(
            global::Vercel.PatchDomainResponseVariant3EchMode echMode,
            global::System.Collections.Generic.IList<string>? customNameservers,
            bool? renew,
            bool? zone)
        {
            this.CustomNameservers = customNameservers;
            this.EchMode = echMode;
            this.Renew = renew;
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