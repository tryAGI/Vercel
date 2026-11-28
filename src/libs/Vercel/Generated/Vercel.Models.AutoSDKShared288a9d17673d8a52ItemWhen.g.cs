
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The fallback model is used when the answers of the primary model match this condition. Set exactly one of `confidenceBelow`, `probabilityBetween`, `any`, `all`, or `atLeast`. A condition tree can be 5 levels deep and can hold 100 conditions.
    /// </summary>
    public sealed partial class AutoSDKShared288a9d17673d8a52ItemWhen
    {
        /// <summary>
        /// The question to check, with `confidenceBelow` or `probabilityBetween`. Without it, the condition checks every question of the applicable type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        public string? Question { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceBelow")]
        public double? ConfidenceBelow { get; set; }

        /// <summary>
        /// A `[lower, upper]` pair.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilityBetween")]
        public global::System.Collections.Generic.IList<double>? ProbabilityBetween { get; set; }

        /// <summary>
        /// Nested conditions. Each one has the same shape as `when`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any")]
        public global::System.Collections.Generic.IList<object>? Any { get; set; }

        /// <summary>
        /// Nested conditions. Each one has the same shape as `when`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        public global::System.Collections.Generic.IList<object>? All { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atLeast")]
        public global::Vercel.AutoSDKShared288a9d17673d8a52ItemWhenAtLeast? AtLeast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared288a9d17673d8a52ItemWhen" /> class.
        /// </summary>
        /// <param name="question">
        /// The question to check, with `confidenceBelow` or `probabilityBetween`. Without it, the condition checks every question of the applicable type.
        /// </param>
        /// <param name="confidenceBelow"></param>
        /// <param name="probabilityBetween">
        /// A `[lower, upper]` pair.
        /// </param>
        /// <param name="any">
        /// Nested conditions. Each one has the same shape as `when`.
        /// </param>
        /// <param name="all">
        /// Nested conditions. Each one has the same shape as `when`.
        /// </param>
        /// <param name="atLeast"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared288a9d17673d8a52ItemWhen(
            string? question,
            double? confidenceBelow,
            global::System.Collections.Generic.IList<double>? probabilityBetween,
            global::System.Collections.Generic.IList<object>? any,
            global::System.Collections.Generic.IList<object>? all,
            global::Vercel.AutoSDKShared288a9d17673d8a52ItemWhenAtLeast? atLeast)
        {
            this.Question = question;
            this.ConfidenceBelow = confidenceBelow;
            this.ProbabilityBetween = probabilityBetween;
            this.Any = any;
            this.All = all;
            this.AtLeast = atLeast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared288a9d17673d8a52ItemWhen" /> class.
        /// </summary>
        public AutoSDKShared288a9d17673d8a52ItemWhen()
        {
        }

    }
}