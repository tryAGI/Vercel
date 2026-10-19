
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonScopeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectBoxesResponseDaemonScopeVariant1TypeJsonConverter))]
        public global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectBoxesResponseDaemonScopeVariant1ValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonScopeVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonScopeVariant1(
            global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1Value value,
            global::Vercel.GetProjectBoxesResponseDaemonScopeVariant1Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonScopeVariant1" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonScopeVariant1()
        {
        }

    }
}