
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRedirectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.EditRedirectResponseVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRedirectResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="alias"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRedirectResponse(
            global::Vercel.EditRedirectResponseVersion version,
            string? alias)
        {
            this.Alias = alias;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRedirectResponse" /> class.
        /// </summary>
        public EditRedirectResponse()
        {
        }
    }
}