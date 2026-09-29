
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared76d2d4f0d6cc3e47
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant1, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant2, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant1, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant2, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4> Fallthrough { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedOutcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared76d2d4f0d6cc3e47PausedOutcome PausedOutcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse")]
        public global::Vercel.AutoSDKShared76d2d4f0d6cc3e47Reuse? Reuse { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f45691814810f14> Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47Target>>>>? Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared76d2d4f0d6cc3e47" /> class.
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
        public AutoSDKShared76d2d4f0d6cc3e47(
            bool active,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant1, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant2, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant3, global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4> fallthrough,
            global::Vercel.AutoSDKShared76d2d4f0d6cc3e47PausedOutcome pausedOutcome,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f45691814810f14> rules,
            global::Vercel.AutoSDKShared76d2d4f0d6cc3e47Reuse? reuse,
            double? revision,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared76d2d4f0d6cc3e47Target>>>>? targets)
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
        /// Initializes a new instance of the <see cref="AutoSDKShared76d2d4f0d6cc3e47" /> class.
        /// </summary>
        public AutoSDKShared76d2d4f0d6cc3e47()
        {
        }

    }
}