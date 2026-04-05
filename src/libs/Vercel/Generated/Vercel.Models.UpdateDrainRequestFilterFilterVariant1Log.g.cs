
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainRequestFilterFilterVariant1Log
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestFilterFilterVariant1LogSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestFilterFilterVariant1Log" /> class.
        /// </summary>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainRequestFilterFilterVariant1Log(
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestFilterFilterVariant1LogSource>? sources)
        {
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestFilterFilterVariant1Log" /> class.
        /// </summary>
        public UpdateDrainRequestFilterFilterVariant1Log()
        {
        }
    }
}