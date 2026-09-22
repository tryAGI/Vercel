
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared618805c2ca46e0a6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3e4933d1b69c5ad0> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared618805c2ca46e0a6" /> class.
        /// </summary>
        /// <param name="runs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared618805c2ca46e0a6(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3e4933d1b69c5ad0> runs)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared618805c2ca46e0a6" /> class.
        /// </summary>
        public AutoSDKShared618805c2ca46e0a6()
        {
        }

    }
}