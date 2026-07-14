
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStorageStoresByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetStorageStoresByIdResponseStore Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageStoresByIdResponse" /> class.
        /// </summary>
        /// <param name="store"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStorageStoresByIdResponse(
            global::Vercel.GetStorageStoresByIdResponseStore store)
        {
            this.Store = store ?? throw new global::System.ArgumentNullException(nameof(store));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageStoresByIdResponse" /> class.
        /// </summary>
        public GetStorageStoresByIdResponse()
        {
        }

    }
}