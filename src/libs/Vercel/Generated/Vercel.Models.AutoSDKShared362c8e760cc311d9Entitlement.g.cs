
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared362c8e760cc311d9Entitlement
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
        /// Initializes a new instance of the <see cref="AutoSDKShared362c8e760cc311d9Entitlement" /> class.
        /// </summary>
        /// <param name="entitlement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared362c8e760cc311d9Entitlement(
            string entitlement)
        {
            this.Entitlement = entitlement ?? throw new global::System.ArgumentNullException(nameof(entitlement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared362c8e760cc311d9Entitlement" /> class.
        /// </summary>
        public AutoSDKShared362c8e760cc311d9Entitlement()
        {
        }

    }
}