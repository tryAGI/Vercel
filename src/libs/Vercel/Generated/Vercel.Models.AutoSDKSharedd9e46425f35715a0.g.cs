
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd9e46425f35715a0Condition> Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant1, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant1, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant4> Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0" /> class.
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="id"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd9e46425f35715a0Condition> conditions,
            string id,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant1, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant2, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant3, global::Vercel.AutoSDKSharedd9e46425f35715a0OutcomeVariant4> outcome)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0()
        {
        }

    }
}