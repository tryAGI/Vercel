
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Job { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2KindJsonConverter))]
        public global::Vercel.CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2" /> class.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2(
            string job,
            global::Vercel.CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2Kind kind)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2" /> class.
        /// </summary>
        public CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant2()
        {
        }

    }
}