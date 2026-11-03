
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrderResponseErrorVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseErrorVariant1CodeJsonConverter))]
        public global::Vercel.GetOrderResponseErrorVariant1Code Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Vercel.GetOrderResponseErrorVariant1Details? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant1" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseErrorVariant1(
            global::Vercel.GetOrderResponseErrorVariant1Code code,
            global::Vercel.GetOrderResponseErrorVariant1Details? details)
        {
            this.Code = code;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseErrorVariant1" /> class.
        /// </summary>
        public GetOrderResponseErrorVariant1()
        {
        }

    }
}