
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The data of the segment
    /// </summary>
    public sealed partial class AutoSDKShared2ea6923996597ff4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4dd3b1b30ff7300>? Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2ea6923996597ff4IncludeItem>>>? Include { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2ea6923996597ff4ExcludeItem>>>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2ea6923996597ff4" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2ea6923996597ff4(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShareda4dd3b1b30ff7300>? rules,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2ea6923996597ff4IncludeItem>>>? include,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2ea6923996597ff4ExcludeItem>>>? exclude)
        {
            this.Rules = rules;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2ea6923996597ff4" /> class.
        /// </summary>
        public AutoSDKShared2ea6923996597ff4()
        {
        }

    }
}