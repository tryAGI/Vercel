
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedbfe68caea048321bDataCache
    {
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userDisabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UserDisabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bDataCache" /> class.
        /// </summary>
        /// <param name="userDisabled"></param>
        /// <param name="storageSizeBytes"></param>
        /// <param name="unlimited"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedbfe68caea048321bDataCache(
            bool userDisabled,
            double? storageSizeBytes,
            bool? unlimited)
        {
            this.StorageSizeBytes = storageSizeBytes;
            this.Unlimited = unlimited;
            this.UserDisabled = userDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedbfe68caea048321bDataCache" /> class.
        /// </summary>
        public AutoSDKSharedbfe68caea048321bDataCache()
        {
        }

    }
}