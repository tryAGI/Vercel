
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9bbe6cc4d61f3bf2Jobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag-definitions-present")]
        public global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsFlagDefinitionsPresent? FlagDefinitionsPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2Jobs" /> class.
        /// </summary>
        /// <param name="flagDefinitionsPresent"></param>
        /// <param name="lint"></param>
        /// <param name="mfeConfigPresent"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9bbe6cc4d61f3bf2Jobs(
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsFlagDefinitionsPresent? flagDefinitionsPresent,
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsLint? lint,
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsMfeConfigPresent? mfeConfigPresent,
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2JobsTypecheck? typecheck)
        {
            this.FlagDefinitionsPresent = flagDefinitionsPresent;
            this.Lint = lint;
            this.MfeConfigPresent = mfeConfigPresent;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9bbe6cc4d61f3bf2Jobs" /> class.
        /// </summary>
        public AutoSDKShared9bbe6cc4d61f3bf2Jobs()
        {
        }

    }
}