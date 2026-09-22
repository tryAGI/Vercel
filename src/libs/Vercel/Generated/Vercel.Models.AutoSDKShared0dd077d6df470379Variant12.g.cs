
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allows custom git sources (local folder mounted to the container) in test mode
    /// </summary>
    public sealed partial class AutoSDKShared0dd077d6df470379Variant12
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0dd077d6df470379Variant12TypeJsonConverter))]
        public global::Vercel.AutoSDKShared0dd077d6df470379Variant12Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0dd077d6df470379Variant12" /> class.
        /// </summary>
        /// <param name="gitUrl"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0dd077d6df470379Variant12(
            string gitUrl,
            string @ref,
            string sha,
            global::Vercel.AutoSDKShared0dd077d6df470379Variant12Type type)
        {
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0dd077d6df470379Variant12" /> class.
        /// </summary>
        public AutoSDKShared0dd077d6df470379Variant12()
        {
        }

    }
}