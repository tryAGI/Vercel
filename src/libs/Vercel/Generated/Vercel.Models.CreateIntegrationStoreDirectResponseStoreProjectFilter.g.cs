
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProjectFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGit? Git { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectFilter" /> class.
        /// </summary>
        /// <param name="git"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProjectFilter(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProjectFilterGit? git)
        {
            this.Git = git;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProjectFilter" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProjectFilter()
        {
        }
    }
}