
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Schedules the project for automatic deletion after the given timeframe.
    /// </summary>
    public sealed partial class CreateProjectRequestExpiration
    {
        /// <summary>
        /// How far in the future the project will be automatically deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeframe")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectRequestExpirationTimeframeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectRequestExpirationTimeframe Timeframe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestExpiration" /> class.
        /// </summary>
        /// <param name="timeframe">
        /// How far in the future the project will be automatically deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequestExpiration(
            global::Vercel.CreateProjectRequestExpirationTimeframe timeframe)
        {
            this.Timeframe = timeframe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequestExpiration" /> class.
        /// </summary>
        public CreateProjectRequestExpiration()
        {
        }

    }
}