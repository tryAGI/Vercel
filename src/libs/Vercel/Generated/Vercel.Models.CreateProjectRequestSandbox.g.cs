
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specifies the default region and failover regions for sandboxes created in the project
    /// </summary>
    public sealed partial class CreateProjectRequestSandbox
    {
        /// <summary>
        /// The Vercel region sandboxes in this project are created in by default.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectRequestSandboxRegionJsonConverter))]
        public global::Vercel.CreateProjectRequestSandboxRegion? Region { get; set; }

        /// <summary>
        /// The regions sandboxes in this project fall back to when they cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
        /// </summary>
        /// <example>[sfo1, cle1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestSandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestSandbox" /> class.
        /// </summary>
        /// <param name="region">
        /// The Vercel region sandboxes in this project are created in by default.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="failoverRegions">
        /// The regions sandboxes in this project fall back to when they cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequestSandbox(
            global::Vercel.CreateProjectRequestSandboxRegion? region,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestSandboxFailoverRegion>? failoverRegions)
        {
            this.Region = region;
            this.FailoverRegions = failoverRegions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestSandbox" /> class.
        /// </summary>
        public CreateProjectRequestSandbox()
        {
        }

    }
}