
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStorageStoresBlobResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public global::Vercel.CreateStorageStoresBlobResponseStore? Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponse" /> class.
        /// </summary>
        /// <param name="store"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStorageStoresBlobResponse(
            global::Vercel.CreateStorageStoresBlobResponseStore? store)
        {
            this.Store = store;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStorageStoresBlobResponse" /> class.
        /// </summary>
        public CreateStorageStoresBlobResponse()
        {
        }

    }
}