
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared303c00bc2455dd70Env2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared303c00bc2455dd70EnvTypeJsonConverter))]
        public global::Vercel.AutoSDKShared303c00bc2455dd70EnvType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared303c00bc2455dd70Env2" /> class.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared303c00bc2455dd70Env2(
            string service,
            global::Vercel.AutoSDKShared303c00bc2455dd70EnvType type)
        {
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared303c00bc2455dd70Env2" /> class.
        /// </summary>
        public AutoSDKShared303c00bc2455dd70Env2()
        {
        }

    }
}