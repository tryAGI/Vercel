
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc9c79e81839bbccdJobsTypecheck
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc9c79e81839bbccdJobsTypecheck" /> class.
        /// </summary>
        /// <param name="targets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc9c79e81839bbccdJobsTypecheck(
            global::System.Collections.Generic.IList<string> targets)
        {
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc9c79e81839bbccdJobsTypecheck" /> class.
        /// </summary>
        public AutoSDKSharedc9c79e81839bbccdJobsTypecheck()
        {
        }

    }
}