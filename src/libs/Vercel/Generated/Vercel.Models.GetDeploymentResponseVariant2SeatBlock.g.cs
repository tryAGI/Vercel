
#nullable enable

namespace Vercel
{
    /// <summary>
    /// NSNB Blocked metadata
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2SeatBlock
    {
        /// <summary>
        /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2SeatBlockBlockCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant2SeatBlockBlockCode BlockCode { get; set; }

        /// <summary>
        /// The git provider type associated with gitUserId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2SeatBlockGitProviderJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2SeatBlockGitProvider? GitProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUserId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? GitUserId { get; set; }

        /// <summary>
        /// Determines if the user was verified during the block. In the git integration case, the commit sender was the author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVerified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// The blocked vercel user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2SeatBlock" /> class.
        /// </summary>
        /// <param name="blockCode">
        /// The NSNB decision code for the seat block. TODO: We should consolidate block types.
        /// </param>
        /// <param name="gitProvider">
        /// The git provider type associated with gitUserId.
        /// </param>
        /// <param name="gitUserId"></param>
        /// <param name="isVerified">
        /// Determines if the user was verified during the block. In the git integration case, the commit sender was the author.
        /// </param>
        /// <param name="userId">
        /// The blocked vercel user ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2SeatBlock(
            global::Vercel.GetDeploymentResponseVariant2SeatBlockBlockCode blockCode,
            global::Vercel.GetDeploymentResponseVariant2SeatBlockGitProvider? gitProvider,
            global::Vercel.OneOf<string, double?>? gitUserId,
            bool? isVerified,
            string? userId)
        {
            this.BlockCode = blockCode;
            this.GitProvider = gitProvider;
            this.GitUserId = gitUserId;
            this.IsVerified = isVerified;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2SeatBlock" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2SeatBlock()
        {
        }

    }
}