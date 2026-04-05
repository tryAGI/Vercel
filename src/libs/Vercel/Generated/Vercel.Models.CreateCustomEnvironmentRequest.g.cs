
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCustomEnvironmentRequest
    {
        /// <summary>
        /// The slug of the custom environment to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Description of the custom environment. This is optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// How we want to determine a matching branch. This is optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.CreateCustomEnvironmentRequestBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// Where to copy environment variables from. This is optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyEnvVarsFrom")]
        public string? CopyEnvVarsFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// The slug of the custom environment to create.
        /// </param>
        /// <param name="description">
        /// Description of the custom environment. This is optional.
        /// </param>
        /// <param name="branchMatcher">
        /// How we want to determine a matching branch. This is optional.
        /// </param>
        /// <param name="copyEnvVarsFrom">
        /// Where to copy environment variables from. This is optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCustomEnvironmentRequest(
            string? slug,
            string? description,
            global::Vercel.CreateCustomEnvironmentRequestBranchMatcher? branchMatcher,
            string? copyEnvVarsFrom)
        {
            this.Slug = slug;
            this.Description = description;
            this.BranchMatcher = branchMatcher;
            this.CopyEnvVarsFrom = copyEnvVarsFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomEnvironmentRequest" /> class.
        /// </summary>
        public CreateCustomEnvironmentRequest()
        {
        }
    }
}