
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectDataCache
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userDisabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UserDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageSizeBytes")]
        public double? StorageSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlimited")]
        public bool? Unlimited { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectDataCache" /> class.
        /// </summary>
        /// <param name="userDisabled"></param>
        /// <param name="storageSizeBytes"></param>
        /// <param name="unlimited"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectDataCache(
            bool userDisabled,
            double? storageSizeBytes,
            bool? unlimited)
        {
            this.UserDisabled = userDisabled;
            this.StorageSizeBytes = storageSizeBytes;
            this.Unlimited = unlimited;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectDataCache" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectDataCache()
        {
        }
    }
}