
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Git Repository that will be connected to the project. When this is defined, any pushes to the specified connected Git Repository will be automatically deployed
    /// </summary>
    public sealed partial class CreateProjectRequestGitRepository
    {
        /// <summary>
        /// The name of the git repository. For example: \"vercel/next.js\"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// The Git Provider of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectRequestGitRepositoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectRequestGitRepositoryType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestGitRepository" /> class.
        /// </summary>
        /// <param name="repo">
        /// The name of the git repository. For example: \"vercel/next.js\"
        /// </param>
        /// <param name="type">
        /// The Git Provider of the repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequestGitRepository(
            string repo,
            global::Vercel.CreateProjectRequestGitRepositoryType type)
        {
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestGitRepository" /> class.
        /// </summary>
        public CreateProjectRequestGitRepository()
        {
        }
    }
}