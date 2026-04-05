
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitInvoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceId")]
        public string? InvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationErrors")]
        public global::System.Collections.Generic.IList<string>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceResponse" /> class.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <param name="test"></param>
        /// <param name="validationErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitInvoiceResponse(
            string? invoiceId,
            bool? test,
            global::System.Collections.Generic.IList<string>? validationErrors)
        {
            this.InvoiceId = invoiceId;
            this.Test = test;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInvoiceResponse" /> class.
        /// </summary>
        public SubmitInvoiceResponse()
        {
        }
    }
}