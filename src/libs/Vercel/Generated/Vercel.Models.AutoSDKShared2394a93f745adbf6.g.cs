
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2394a93f745adbf6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallthrough")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant1, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant3, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant1, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant3, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant4> Fallthrough { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedOutcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2394a93f745adbf6PausedOutcome PausedOutcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse")]
        public global::Vercel.AutoSDKShared2394a93f745adbf6Reuse? Reuse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public double? Revision { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd9e46425f35715a0> Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2394a93f745adbf6Target>>>>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2394a93f745adbf6" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="fallthrough"></param>
        /// <param name="pausedOutcome"></param>
        /// <param name="rules"></param>
        /// <param name="reuse"></param>
        /// <param name="revision"></param>
        /// <param name="targets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2394a93f745adbf6(
            bool active,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant1, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant2, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant3, global::Vercel.AutoSDKShared2394a93f745adbf6FallthroughVariant4> fallthrough,
            global::Vercel.AutoSDKShared2394a93f745adbf6PausedOutcome pausedOutcome,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd9e46425f35715a0> rules,
            global::Vercel.AutoSDKShared2394a93f745adbf6Reuse? reuse,
            double? revision,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2394a93f745adbf6Target>>>>? targets)
        {
            this.Active = active;
            this.Fallthrough = fallthrough;
            this.PausedOutcome = pausedOutcome ?? throw new global::System.ArgumentNullException(nameof(pausedOutcome));
            this.Reuse = reuse;
            this.Revision = revision;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Targets = targets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2394a93f745adbf6" /> class.
        /// </summary>
        public AutoSDKShared2394a93f745adbf6()
        {
        }

    }
}