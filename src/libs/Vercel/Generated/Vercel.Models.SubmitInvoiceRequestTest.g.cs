
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Test mode
    /// </summary>
    public sealed partial class SubmitInvoiceRequestTest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validate")]
        public bool? Validate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SubmitInvoiceRequestTestResultJsonConverter))]
        public global::Vercel.SubmitInvoiceRequestTestResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceRequestTest" /> class.
        /// </summary>
        /// <param name="validate"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitInvoiceRequestTest(
            bool? validate,
            global::Vercel.SubmitInvoiceRequestTestResult? result)
        {
            this.Validate = validate;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceRequestTest" /> class.
        /// </summary>
        public SubmitInvoiceRequestTest()
        {
        }
    }
}