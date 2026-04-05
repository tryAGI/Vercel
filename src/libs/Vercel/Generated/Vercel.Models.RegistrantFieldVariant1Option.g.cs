
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegistrantFieldVariant1Option
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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public object? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant1Option" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="label"></param>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrantFieldVariant1Option(
            string value,
            string label,
            object? fields)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant1Option" /> class.
        /// </summary>
        public RegistrantFieldVariant1Option()
        {
        }
    }
}