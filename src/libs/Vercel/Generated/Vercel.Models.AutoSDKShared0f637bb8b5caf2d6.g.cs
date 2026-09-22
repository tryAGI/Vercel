
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f637bb8b5caf2d6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6ExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6IncludeItem>>>? Include { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6Rule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f637bb8b5caf2d6" /> class.
        /// </summary>
        /// <param name="exclude"></param>
        /// <param name="include"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f637bb8b5caf2d6(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6ExcludeItem>>>? exclude,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6IncludeItem>>>? include,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0f637bb8b5caf2d6Rule>? rules)
        {
            this.Exclude = exclude;
            this.Include = include;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f637bb8b5caf2d6" /> class.
        /// </summary>
        public AutoSDKShared0f637bb8b5caf2d6()
        {
        }

    }
}