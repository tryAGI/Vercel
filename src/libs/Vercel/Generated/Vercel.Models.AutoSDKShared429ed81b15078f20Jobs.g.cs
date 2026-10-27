
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared429ed81b15078f20Jobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag-definitions-present")]
        public global::Vercel.AutoSDKShared429ed81b15078f20JobsFlagDefinitionsPresent? FlagDefinitionsPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.AutoSDKShared429ed81b15078f20JobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.AutoSDKShared429ed81b15078f20JobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.AutoSDKShared429ed81b15078f20JobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared429ed81b15078f20Jobs" /> class.
        /// </summary>
        /// <param name="flagDefinitionsPresent"></param>
        /// <param name="lint"></param>
        /// <param name="mfeConfigPresent"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared429ed81b15078f20Jobs(
            global::Vercel.AutoSDKShared429ed81b15078f20JobsFlagDefinitionsPresent? flagDefinitionsPresent,
            global::Vercel.AutoSDKShared429ed81b15078f20JobsLint? lint,
            global::Vercel.AutoSDKShared429ed81b15078f20JobsMfeConfigPresent? mfeConfigPresent,
            global::Vercel.AutoSDKShared429ed81b15078f20JobsTypecheck? typecheck)
        {
            this.FlagDefinitionsPresent = flagDefinitionsPresent;
            this.Lint = lint;
            this.MfeConfigPresent = mfeConfigPresent;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared429ed81b15078f20Jobs" /> class.
        /// </summary>
        public AutoSDKShared429ed81b15078f20Jobs()
        {
        }

    }
}