
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared7e5cde0fd7c87b94CrsPhp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared7e5cde0fd7c87b94CrsPhpActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsPhpAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94CrsPhp" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared7e5cde0fd7c87b94CrsPhp(
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94CrsPhpAction action,
            bool active)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94CrsPhp" /> class.
        /// </summary>
        public AutoSDKShared7e5cde0fd7c87b94CrsPhp()
        {
        }

    }
}