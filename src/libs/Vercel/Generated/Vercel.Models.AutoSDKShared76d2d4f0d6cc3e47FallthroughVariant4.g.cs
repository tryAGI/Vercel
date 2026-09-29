
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4TypeJsonConverter))]
        public global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4(
            global::Vercel.AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4" /> class.
        /// </summary>
        public AutoSDKShared76d2d4f0d6cc3e47FallthroughVariant4()
        {
        }

    }
}