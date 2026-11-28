
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A conditional fallback. Only an alias can have one.
    /// </summary>
    public sealed partial class AutoSDKShared288a9d17673d8a52Item2
    {
        /// <summary>
        /// A model ID: a catalog model such as `openai/gpt-4o`, or one of your team's private models as `private/&lt;slug&gt;`. A fallback can also name a virtual model as `vmc/&lt;slug&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The fallback model is used when the answers of the primary model match this condition. Set exactly one of `confidenceBelow`, `probabilityBetween`, `any`, `all`, or `atLeast`. A condition tree can be 5 levels deep and can hold 100 conditions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared288a9d17673d8a52ItemWhen When { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared288a9d17673d8a52Item2" /> class.
        /// </summary>
        /// <param name="model">
        /// A model ID: a catalog model such as `openai/gpt-4o`, or one of your team's private models as `private/&lt;slug&gt;`. A fallback can also name a virtual model as `vmc/&lt;slug&gt;`.
        /// </param>
        /// <param name="when">
        /// The fallback model is used when the answers of the primary model match this condition. Set exactly one of `confidenceBelow`, `probabilityBetween`, `any`, `all`, or `atLeast`. A condition tree can be 5 levels deep and can hold 100 conditions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared288a9d17673d8a52Item2(
            string model,
            global::Vercel.AutoSDKShared288a9d17673d8a52ItemWhen when)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.When = when ?? throw new global::System.ArgumentNullException(nameof(when));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared288a9d17673d8a52Item2" /> class.
        /// </summary>
        public AutoSDKShared288a9d17673d8a52Item2()
        {
        }

    }
}