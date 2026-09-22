
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The microfrontends for the alias including the routing configuration
    /// </summary>
    public sealed partial class AutoSDKShareda43c8be44c1b9566
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applications")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared82df63ae69e9ea93JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared82df63ae69e9ea93 Applications { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultApp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda43c8be44c1b9566DefaultApp DefaultApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda43c8be44c1b9566" /> class.
        /// </summary>
        /// <param name="applications"></param>
        /// <param name="defaultApp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda43c8be44c1b9566(
            global::Vercel.AutoSDKShared82df63ae69e9ea93 applications,
            global::Vercel.AutoSDKShareda43c8be44c1b9566DefaultApp defaultApp)
        {
            this.Applications = applications;
            this.DefaultApp = defaultApp ?? throw new global::System.ArgumentNullException(nameof(defaultApp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda43c8be44c1b9566" /> class.
        /// </summary>
        public AutoSDKShareda43c8be44c1b9566()
        {
        }

    }
}