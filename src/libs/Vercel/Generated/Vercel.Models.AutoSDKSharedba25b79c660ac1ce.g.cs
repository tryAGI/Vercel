
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedba25b79c660ac1ce
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
        public global::Vercel.AutoSDKSharedba25b79c660ac1ceReuse? Reuse { get; set; }

        /// <summary>
        /// Allows assigning targets to variants while bypassing the flag's rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba25b79c660ac1ceTarget>>>>? Targets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pausedOutcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedba25b79c660ac1cePausedOutcome PausedOutcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede7fa7575dde4720d> Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallthrough")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede68d1538d48d5cc1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede68d1538d48d5cc1 Fallthrough { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedba25b79c660ac1ce" /> class.
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
        public AutoSDKSharedba25b79c660ac1ce(
            bool active,
            global::Vercel.AutoSDKSharedba25b79c660ac1cePausedOutcome pausedOutcome,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede7fa7575dde4720d> rules,
            global::Vercel.AutoSDKSharede68d1538d48d5cc1 fallthrough,
            global::Vercel.AutoSDKSharedba25b79c660ac1ceReuse? reuse,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedba25b79c660ac1ceTarget>>>>? targets,
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
        /// Initializes a new instance of the <see cref="AutoSDKSharedba25b79c660ac1ce" /> class.
        /// </summary>
        public AutoSDKSharedba25b79c660ac1ce()
        {
        }

    }
}