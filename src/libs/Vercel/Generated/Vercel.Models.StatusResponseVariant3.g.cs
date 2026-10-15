
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StatusResponseVariant3
    {
        /// <summary>
        /// Present and `true` when the token can read artifacts but cannot upload them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnly")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.StatusResponseVariant3StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.StatusResponseVariant3Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponseVariant3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="readOnly">
        /// Present and `true` when the token can read artifacts but cannot upload them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatusResponseVariant3(
            global::Vercel.StatusResponseVariant3Status status,
            bool? readOnly)
        {
            this.ReadOnly = readOnly;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponseVariant3" /> class.
        /// </summary>
        public StatusResponseVariant3()
        {
        }

    }
}