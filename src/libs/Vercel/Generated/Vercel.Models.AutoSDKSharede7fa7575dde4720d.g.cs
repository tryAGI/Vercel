
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede7fa7575dde4720d
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede7fa7575dde4720dCondition> Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede68d1538d48d5cc1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede68d1538d48d5cc1 Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7fa7575dde4720d" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conditions"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede7fa7575dde4720d(
            string id,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede7fa7575dde4720dCondition> conditions,
            global::Vercel.AutoSDKSharede68d1538d48d5cc1 outcome)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7fa7575dde4720d" /> class.
        /// </summary>
        public AutoSDKSharede7fa7575dde4720d()
        {
        }

    }
}