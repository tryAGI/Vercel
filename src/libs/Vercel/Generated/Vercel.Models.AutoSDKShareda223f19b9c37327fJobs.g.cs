
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda223f19b9c37327fJobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lint")]
        public global::Vercel.AutoSDKShareda223f19b9c37327fJobsLint? Lint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mfe-config-present")]
        public global::Vercel.AutoSDKShareda223f19b9c37327fJobsMfeConfigPresent? MfeConfigPresent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typecheck")]
        public global::Vercel.AutoSDKShareda223f19b9c37327fJobsTypecheck? Typecheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda223f19b9c37327fJobs" /> class.
        /// </summary>
        /// <param name="lint"></param>
        /// <param name="mfeConfigPresent"></param>
        /// <param name="typecheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda223f19b9c37327fJobs(
            global::Vercel.AutoSDKShareda223f19b9c37327fJobsLint? lint,
            global::Vercel.AutoSDKShareda223f19b9c37327fJobsMfeConfigPresent? mfeConfigPresent,
            global::Vercel.AutoSDKShareda223f19b9c37327fJobsTypecheck? typecheck)
        {
            this.Lint = lint;
            this.MfeConfigPresent = mfeConfigPresent;
            this.Typecheck = typecheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda223f19b9c37327fJobs" /> class.
        /// </summary>
        public AutoSDKShareda223f19b9c37327fJobs()
        {
        }

    }
}