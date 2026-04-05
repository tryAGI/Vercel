
#nullable enable

namespace Vercel
{
    /// <summary>
    /// NSNB Blocked metadata
    /// </summary>
    public sealed partial class CancelDeploymentResponseSeatBlock
    {
        /// <summary>
        /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseSeatBlockBlockCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseSeatBlockBlockCode BlockCode { get; set; }

        /// <summary>
        /// The blocked vercel user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Determines if the user was verified during the block. In the git integration case, the commit sender was the author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVerified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? GitUserId { get; set; }

        /// <summary>
        /// The git provider type associated with gitUserId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseSeatBlockGitProviderJsonConverter))]
        public global::Vercel.CancelDeploymentResponseSeatBlockGitProvider? GitProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseSeatBlock" /> class.
        /// </summary>
        /// <param name="blockCode">
        /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
        /// </param>
        /// <param name="userId">
        /// The blocked vercel user ID.
        /// </param>
        /// <param name="isVerified">
        /// Determines if the user was verified during the block. In the git integration case, the commit sender was the author.
        /// </param>
        /// <param name="gitUserId"></param>
        /// <param name="gitProvider">
        /// The git provider type associated with gitUserId.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseSeatBlock(
            global::Vercel.CancelDeploymentResponseSeatBlockBlockCode blockCode,
            string? userId,
            bool? isVerified,
            global::Vercel.OneOf<string, double?>? gitUserId,
            global::Vercel.CancelDeploymentResponseSeatBlockGitProvider? gitProvider)
        {
            this.BlockCode = blockCode;
            this.UserId = userId;
            this.IsVerified = isVerified;
            this.GitUserId = gitUserId;
            this.GitProvider = gitProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseSeatBlock" /> class.
        /// </summary>
        public CancelDeploymentResponseSeatBlock()
        {
        }
    }
}