
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSandboxResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute> Routes { get; set; }

        /// <summary>
        /// This object contains information related to a Vercel NamedSandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.NamedSandbox Sandbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxResponseVariant1" /> class.
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="sandbox">
        /// This object contains information related to a Vercel NamedSandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxResponseVariant1(
            global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute> routes,
            global::Vercel.NamedSandbox sandbox)
        {
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Sandbox = sandbox ?? throw new global::System.ArgumentNullException(nameof(sandbox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxResponseVariant1" /> class.
        /// </summary>
        public UpdateSandboxResponseVariant1()
        {
        }

    }
}