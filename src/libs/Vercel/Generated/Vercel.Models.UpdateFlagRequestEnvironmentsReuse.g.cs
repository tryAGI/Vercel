
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allows linking this environment to another environment so this flag will be evaluated with the other flag's configuration
    /// </summary>
    public sealed partial class UpdateFlagRequestEnvironmentsReuse
    {
        /// <summary>
        /// Whether the reuse is active or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// The environment to link to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsReuse" /> class.
        /// </summary>
        /// <param name="active">
        /// Whether the reuse is active or not
        /// </param>
        /// <param name="environment">
        /// The environment to link to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagRequestEnvironmentsReuse(
            bool active,
            string environment)
        {
            this.Active = active;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagRequestEnvironmentsReuse" /> class.
        /// </summary>
        public UpdateFlagRequestEnvironmentsReuse()
        {
        }
    }
}