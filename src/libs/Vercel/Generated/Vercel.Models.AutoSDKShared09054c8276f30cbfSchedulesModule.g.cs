
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when this build serves a Python schedule's module: the `@schedule` handlers that importing `module` registers.
    /// </summary>
    public sealed partial class AutoSDKShared09054c8276f30cbfSchedulesModule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Module { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared09054c8276f30cbfSchedulesModule" /> class.
        /// </summary>
        /// <param name="module"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared09054c8276f30cbfSchedulesModule(
            string module)
        {
            this.Module = module ?? throw new global::System.ArgumentNullException(nameof(module));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared09054c8276f30cbfSchedulesModule" /> class.
        /// </summary>
        public AutoSDKShared09054c8276f30cbfSchedulesModule()
        {
        }

    }
}