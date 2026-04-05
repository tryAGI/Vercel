
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseRouteVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseRouteVariant2HandleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseRouteVariant2Handle Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant2" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseRouteVariant2(
            global::Vercel.CancelDeploymentResponseRouteVariant2Handle handle,
            string? src,
            string? dest,
            double? status)
        {
            this.Handle = handle;
            this.Src = src;
            this.Dest = dest;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant2" /> class.
        /// </summary>
        public CancelDeploymentResponseRouteVariant2()
        {
        }
    }
}