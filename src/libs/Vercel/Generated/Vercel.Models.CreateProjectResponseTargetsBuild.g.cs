
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectResponseTargetsBuild
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Use { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseTargetsBuild" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="dest"></param>
        /// <param name="src"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseTargetsBuild(
            string use,
            string? dest,
            string? src)
        {
            this.Dest = dest;
            this.Src = src;
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseTargetsBuild" /> class.
        /// </summary>
        public CreateProjectResponseTargetsBuild()
        {
        }

    }
}