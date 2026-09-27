
#nullable enable

namespace Vercel
{
    /// <summary>
    /// For kind=router: ordered candidates, bare slugs/references or `{ slug, ...attributes }`. For kind=alias: ordered fallback model slugs, optionally led by one conditional `{ model, when }` entry, used when the primary model's answers match `when`.
    /// </summary>
    public sealed partial class AiGatewayVirtualModelConfigModelVariant2
    {
        /// <summary>
        /// Highest task level the member handles, in [0, 1]. Read by the intelligence selector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public double? Intelligence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigModelVariant2" /> class.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="intelligence">
        /// Highest task level the member handles, in [0, 1]. Read by the intelligence selector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayVirtualModelConfigModelVariant2(
            string slug,
            double? intelligence)
        {
            this.Intelligence = intelligence;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayVirtualModelConfigModelVariant2" /> class.
        /// </summary>
        public AiGatewayVirtualModelConfigModelVariant2()
        {
        }

    }
}