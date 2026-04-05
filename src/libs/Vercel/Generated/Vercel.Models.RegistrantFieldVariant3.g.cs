
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegistrantFieldVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation")]
        public string? Validation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_when")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::Vercel.RegistrantFieldVariant3RequiredWhen>))]
        public global::Vercel.AnyOf<string, global::Vercel.RegistrantFieldVariant3RequiredWhen>? RequiredWhen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RegistrantFieldVariant3TypeJsonConverter))]
        public global::Vercel.RegistrantFieldVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant3" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="label"></param>
        /// <param name="validation"></param>
        /// <param name="requiredWhen"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrantFieldVariant3(
            string description,
            bool required,
            string? label,
            string? validation,
            global::Vercel.AnyOf<string, global::Vercel.RegistrantFieldVariant3RequiredWhen>? requiredWhen,
            global::Vercel.RegistrantFieldVariant3Type type,
            string? value)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.Label = label;
            this.Validation = validation;
            this.RequiredWhen = requiredWhen;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant3" /> class.
        /// </summary>
        public RegistrantFieldVariant3()
        {
        }
    }
}