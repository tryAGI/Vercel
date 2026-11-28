
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1AccessJsonConverter))]
        public global::Vercel.AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1ManagedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1" /> class.
        /// </summary>
        /// <param name="managedBy"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1(
            global::Vercel.AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1ManagedBy managedBy,
            global::Vercel.AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1Access access)
        {
            this.Access = access;
            this.ManagedBy = managedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1" /> class.
        /// </summary>
        public AutoSDKShared2b02cf1378da97a7ProjectAccessVariant1()
        {
        }

    }
}