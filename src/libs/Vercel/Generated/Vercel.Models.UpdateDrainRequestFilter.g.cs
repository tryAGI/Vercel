
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDrainRequestFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateDrainRequestFilterFilterVariant1, global::Vercel.UpdateDrainRequestFilterFilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateDrainRequestFilterFilterVariant1, global::Vercel.UpdateDrainRequestFilterFilterVariant2> Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestFilter" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDrainRequestFilter(
            string version,
            global::Vercel.OneOf<global::Vercel.UpdateDrainRequestFilterFilterVariant1, global::Vercel.UpdateDrainRequestFilterFilterVariant2> filter)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrainRequestFilter" /> class.
        /// </summary>
        public UpdateDrainRequestFilter()
        {
        }
    }
}