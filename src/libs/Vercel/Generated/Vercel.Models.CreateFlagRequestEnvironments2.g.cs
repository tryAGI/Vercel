
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFlagRequestEnvironments2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Allows linking this environment to another environment so this flag will be evaluated with the other flag's configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse")]
        public global::Vercel.CreateFlagRequestEnvironmentsReuse? Reuse { get; set; }

        /// <summary>
        /// Allows assigning targets to variants while bypassing the flag's rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestEnvironmentsTarget>>>>? Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedOutcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateFlagRequestEnvironmentsPausedOutcome PausedOutcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestEnvironmentsRule> Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallthrough")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant1, global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant2, global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant1, global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant2, global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant3> Fallthrough { get; set; }

        /// <summary>
        /// The revision of the environment config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public double? Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironments2" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="pausedOutcome"></param>
        /// <param name="rules"></param>
        /// <param name="fallthrough"></param>
        /// <param name="reuse">
        /// Allows linking this environment to another environment so this flag will be evaluated with the other flag's configuration
        /// </param>
        /// <param name="targets">
        /// Allows assigning targets to variants while bypassing the flag's rules
        /// </param>
        /// <param name="revision">
        /// The revision of the environment config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFlagRequestEnvironments2(
            bool active,
            global::Vercel.CreateFlagRequestEnvironmentsPausedOutcome pausedOutcome,
            global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestEnvironmentsRule> rules,
            global::Vercel.AnyOf<global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant1, global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant2, global::Vercel.CreateFlagRequestEnvironmentsFallthroughVariant3> fallthrough,
            global::Vercel.CreateFlagRequestEnvironmentsReuse? reuse,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.CreateFlagRequestEnvironmentsTarget>>>>? targets,
            double? revision)
        {
            this.Active = active;
            this.Reuse = reuse;
            this.Targets = targets;
            this.PausedOutcome = pausedOutcome ?? throw new global::System.ArgumentNullException(nameof(pausedOutcome));
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Fallthrough = fallthrough;
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFlagRequestEnvironments2" /> class.
        /// </summary>
        public CreateFlagRequestEnvironments2()
        {
        }
    }
}