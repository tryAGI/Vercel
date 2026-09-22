
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbd3f01cc8f6abd3dVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Date { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedbd3f01cc8f6abd3dVariant3TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasError")]
        public global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3AliasError? AliasError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasWarning")]
        public global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3AliasWarning? AliasWarning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbd3f01cc8f6abd3dVariant3" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="deploymentId"></param>
        /// <param name="alias"></param>
        /// <param name="type"></param>
        /// <param name="aliasError"></param>
        /// <param name="aliasWarning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbd3f01cc8f6abd3dVariant3(
            double date,
            string deploymentId,
            global::System.Collections.Generic.IList<string> alias,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3Type type,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3AliasError? aliasError,
            global::Vercel.AutoSDKSharedbd3f01cc8f6abd3dVariant3AliasWarning? aliasWarning)
        {
            this.Date = date;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Type = type;
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.AliasError = aliasError;
            this.AliasWarning = aliasWarning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbd3f01cc8f6abd3dVariant3" /> class.
        /// </summary>
        public AutoSDKSharedbd3f01cc8f6abd3dVariant3()
        {
        }

    }
}