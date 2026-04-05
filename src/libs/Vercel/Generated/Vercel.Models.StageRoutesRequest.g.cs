
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StageRoutesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        public global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRoute>? Routes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesRequest" /> class.
        /// </summary>
        /// <param name="overwrite"></param>
        /// <param name="routes">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StageRoutesRequest(
            bool? overwrite,
            global::System.Collections.Generic.IList<global::Vercel.StageRoutesRequestRoute>? routes)
        {
            this.Overwrite = overwrite;
            this.Routes = routes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesRequest" /> class.
        /// </summary>
        public StageRoutesRequest()
        {
        }
    }
}