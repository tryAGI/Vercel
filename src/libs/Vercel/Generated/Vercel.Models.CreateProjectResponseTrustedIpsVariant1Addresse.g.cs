
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponseTrustedIpsVariant1Addresse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseTrustedIpsVariant1Addresse" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponseTrustedIpsVariant1Addresse(
            string value,
            string? note)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponseTrustedIpsVariant1Addresse" /> class.
        /// </summary>
        public CreateProjectResponseTrustedIpsVariant1Addresse()
        {
        }
    }
}