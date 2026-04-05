
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRedirectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The redirect object to edit. The source field is used to match the redirect to modify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.EditRedirectRequestRedirect Redirect { get; set; }

        /// <summary>
        /// If true, restores the redirect from the latest production version to staging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore")]
        public bool? Restore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRedirectRequest" /> class.
        /// </summary>
        /// <param name="redirect">
        /// The redirect object to edit. The source field is used to match the redirect to modify.
        /// </param>
        /// <param name="name"></param>
        /// <param name="restore">
        /// If true, restores the redirect from the latest production version to staging.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRedirectRequest(
            global::Vercel.EditRedirectRequestRedirect redirect,
            string? name,
            bool? restore)
        {
            this.Name = name;
            this.Redirect = redirect ?? throw new global::System.ArgumentNullException(nameof(redirect));
            this.Restore = restore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRedirectRequest" /> class.
        /// </summary>
        public EditRedirectRequest()
        {
        }
    }
}