
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Labeled event details for progressive disclosure in the activity feed.
    /// </summary>
    public sealed partial class UserEventDetail
    {
        /// <summary>
        /// Recognition context that should remain visible in a compact feed row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventDetailDisplayJsonConverter))]
        public global::Vercel.UserEventDetailDisplay? Display { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventDetail" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="display">
        /// Recognition context that should remain visible in a compact feed row.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventDetail(
            string label,
            string value,
            global::Vercel.UserEventDetailDisplay? display)
        {
            this.Display = display;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventDetail" /> class.
        /// </summary>
        public UserEventDetail()
        {
        }

    }
}