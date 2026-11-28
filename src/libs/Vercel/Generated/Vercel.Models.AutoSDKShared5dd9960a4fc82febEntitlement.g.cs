
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared5dd9960a4fc82febEntitlement
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entitlement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5dd9960a4fc82febEntitlement" /> class.
        /// </summary>
        /// <param name="entitlement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared5dd9960a4fc82febEntitlement(
            string entitlement)
        {
            this.Entitlement = entitlement ?? throw new global::System.ArgumentNullException(nameof(entitlement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5dd9960a4fc82febEntitlement" /> class.
        /// </summary>
        public AutoSDKShared5dd9960a4fc82febEntitlement()
        {
        }

    }
}