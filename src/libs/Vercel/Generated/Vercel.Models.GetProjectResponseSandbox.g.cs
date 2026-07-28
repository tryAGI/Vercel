
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseSandbox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseSandboxRegionJsonConverter))]
        public global::Vercel.GetProjectResponseSandboxRegion? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseSandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseSandbox" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="failoverRegions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseSandbox(
            global::Vercel.GetProjectResponseSandboxRegion? region,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectResponseSandboxFailoverRegion>? failoverRegions)
        {
            this.Region = region;
            this.FailoverRegions = failoverRegions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseSandbox" /> class.
        /// </summary>
        public GetProjectResponseSandbox()
        {
        }

    }
}