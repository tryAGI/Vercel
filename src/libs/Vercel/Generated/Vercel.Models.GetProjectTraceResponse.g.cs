
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectTraceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectTraceResponseTrace Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponse" /> class.
        /// </summary>
        /// <param name="trace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectTraceResponse(
            global::Vercel.GetProjectTraceResponseTrace trace)
        {
            this.Trace = trace ?? throw new global::System.ArgumentNullException(nameof(trace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectTraceResponse" /> class.
        /// </summary>
        public GetProjectTraceResponse()
        {
        }

    }
}