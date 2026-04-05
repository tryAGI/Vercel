
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlagEnvironments2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse")]
        public global::Vercel.FlagEnvironmentsReuse? Reuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.FlagEnvironmentsTarget>>>>? Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public double? Revision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedOutcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagEnvironmentsPausedOutcome PausedOutcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallthrough")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.FlagEnvironmentsFallthroughVariant1, global::Vercel.FlagEnvironmentsFallthroughVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.FlagEnvironmentsFallthroughVariant1, global::Vercel.FlagEnvironmentsFallthroughVariant2> Fallthrough { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.FlagEnvironmentsRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagEnvironments2" /> class.
        /// </summary>
        /// <param name="pausedOutcome"></param>
        /// <param name="fallthrough"></param>
        /// <param name="active"></param>
        /// <param name="rules"></param>
        /// <param name="reuse"></param>
        /// <param name="targets"></param>
        /// <param name="revision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlagEnvironments2(
            global::Vercel.FlagEnvironmentsPausedOutcome pausedOutcome,
            global::Vercel.OneOf<global::Vercel.FlagEnvironmentsFallthroughVariant1, global::Vercel.FlagEnvironmentsFallthroughVariant2> fallthrough,
            bool active,
            global::System.Collections.Generic.IList<global::Vercel.FlagEnvironmentsRule> rules,
            global::Vercel.FlagEnvironmentsReuse? reuse,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.FlagEnvironmentsTarget>>>>? targets,
            double? revision)
        {
            this.Reuse = reuse;
            this.Targets = targets;
            this.Revision = revision;
            this.PausedOutcome = pausedOutcome ?? throw new global::System.ArgumentNullException(nameof(pausedOutcome));
            this.Fallthrough = fallthrough;
            this.Active = active;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagEnvironments2" /> class.
        /// </summary>
        public FlagEnvironments2()
        {
        }
    }
}