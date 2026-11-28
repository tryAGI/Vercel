
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared1e1af2b60dfcf13a
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant1, global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2, global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant1, global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2, global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3> Fallthrough { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedOutcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared1e1af2b60dfcf13aPausedOutcome PausedOutcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse")]
        public global::Vercel.AutoSDKShared1e1af2b60dfcf13aReuse? Reuse { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedce53ae034203eae7> Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared1e1af2b60dfcf13aTarget>>>>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared1e1af2b60dfcf13a" /> class.
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
        public AutoSDKShared1e1af2b60dfcf13a(
            bool active,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant1, global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2, global::Vercel.AutoSDKShared1e1af2b60dfcf13aFallthroughVariant3> fallthrough,
            global::Vercel.AutoSDKShared1e1af2b60dfcf13aPausedOutcome pausedOutcome,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedce53ae034203eae7> rules,
            global::Vercel.AutoSDKShared1e1af2b60dfcf13aReuse? reuse,
            double? revision,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared1e1af2b60dfcf13aTarget>>>>? targets)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared1e1af2b60dfcf13a" /> class.
        /// </summary>
        public AutoSDKShared1e1af2b60dfcf13a()
        {
        }

    }
}