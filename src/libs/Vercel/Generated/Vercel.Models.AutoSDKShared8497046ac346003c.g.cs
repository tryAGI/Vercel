
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared8497046ac346003c
    {
        /// <summary>
        /// projectIds are added when the config is uploaded to s3 deployment assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.AutoSDKSharedb2aa6c85fab0cd65? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared8497046ac346003c" /> class.
        /// </summary>
        /// <param name="config">
        /// projectIds are added when the config is uploaded to s3 deployment assets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared8497046ac346003c(
            global::Vercel.AutoSDKSharedb2aa6c85fab0cd65? config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared8497046ac346003c" /> class.
        /// </summary>
        public AutoSDKShared8497046ac346003c()
        {
        }

    }
}