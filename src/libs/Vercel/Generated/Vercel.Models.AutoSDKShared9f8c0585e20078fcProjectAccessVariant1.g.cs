
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9f8c0585e20078fcProjectAccessVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9f8c0585e20078fcProjectAccessVariant1AccessJsonConverter))]
        public global::Vercel.AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9f8c0585e20078fcProjectAccessVariant1" /> class.
        /// </summary>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9f8c0585e20078fcProjectAccessVariant1(
            global::Vercel.AutoSDKShared9f8c0585e20078fcProjectAccessVariant1ManagedBy managedBy,
            global::Vercel.AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access access)
        {
            this.Access = access;
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9f8c0585e20078fcProjectAccessVariant1" /> class.
        /// </summary>
        public AutoSDKShared9f8c0585e20078fcProjectAccessVariant1()
        {
        }

    }
}