
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProjectFilterGit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider>, global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider>, global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders?> Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owners")]
        public global::System.Collections.Generic.IList<string>? Owners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos")]
        public global::System.Collections.Generic.IList<string>? Repos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectFilterGit" /> class.
        /// </summary>
        /// <param name="providers"></param>
        /// <param name="owners"></param>
        /// <param name="repos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProjectFilterGit(
            global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGitProvider>, global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGitProviders?> providers,
            global::System.Collections.Generic.IList<string>? owners,
            global::System.Collections.Generic.IList<string>? repos)
        {
            this.Providers = providers;
            this.Owners = owners;
            this.Repos = repos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectFilterGit" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProjectFilterGit()
        {
        }
    }
}