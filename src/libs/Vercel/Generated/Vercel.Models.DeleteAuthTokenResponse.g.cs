
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Authentication token successfully deleted.
    /// </summary>
    public sealed partial class DeleteAuthTokenResponse
    {
        /// <summary>
        /// The unique identifier of the token that was deleted.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </summary>
        /// <example>5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAuthTokenResponse" /> class.
        /// </summary>
        /// <param name="tokenId">
        /// The unique identifier of the token that was deleted.<br/>
        /// Example: 5d9f2ebd38ddca62e5d51e9c1704c72530bdc8bfdd41e782a6687c48399e8391
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAuthTokenResponse(
            string tokenId)
        {
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAuthTokenResponse" /> class.
        /// </summary>
        public DeleteAuthTokenResponse()
        {
        }
    }
}