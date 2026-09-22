
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared383028c008cc4ae0ProjectAccessVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared383028c008cc4ae0ProjectAccessVariant1AccessJsonConverter))]
        public global::Vercel.AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared383028c008cc4ae0ProjectAccessVariant1ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared383028c008cc4ae0ProjectAccessVariant1ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared383028c008cc4ae0ProjectAccessVariant1" /> class.
        /// </summary>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared383028c008cc4ae0ProjectAccessVariant1(
            global::Vercel.AutoSDKShared383028c008cc4ae0ProjectAccessVariant1ManagedBy managedBy,
            global::Vercel.AutoSDKShared383028c008cc4ae0ProjectAccessVariant1Access access)
        {
            this.Access = access;
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared383028c008cc4ae0ProjectAccessVariant1" /> class.
        /// </summary>
        public AutoSDKShared383028c008cc4ae0ProjectAccessVariant1()
        {
        }

    }
}