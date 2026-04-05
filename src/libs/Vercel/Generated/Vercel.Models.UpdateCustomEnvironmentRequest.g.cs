
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomEnvironmentRequest
    {
        /// <summary>
        /// The slug of the custom environment.
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
        public global::Vercel.UpdateCustomEnvironmentRequestBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEnvironmentRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// The slug of the custom environment.
        /// </param>
        /// <param name="description">
        /// Description of the custom environment. This is optional.
        /// </param>
        /// <param name="branchMatcher">
        /// How we want to determine a matching branch. This is optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomEnvironmentRequest(
            string? slug,
            string? description,
            global::Vercel.UpdateCustomEnvironmentRequestBranchMatcher? branchMatcher)
        {
            this.Slug = slug;
            this.Description = description;
            this.BranchMatcher = branchMatcher;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEnvironmentRequest" /> class.
        /// </summary>
        public UpdateCustomEnvironmentRequest()
        {
        }
    }
}