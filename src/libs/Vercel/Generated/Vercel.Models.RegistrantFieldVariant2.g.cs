
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegistrantFieldVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::Vercel.RegistrantFieldVariant2RequiredWhen>))]
        public global::Vercel.AnyOf<string, global::Vercel.RegistrantFieldVariant2RequiredWhen>? RequiredWhen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RegistrantFieldVariant2TypeJsonConverter))]
        public global::Vercel.RegistrantFieldVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.RegistrantFieldVariant2Option> Options { get; set; }

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
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant2" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="options"></param>
        /// <param name="label"></param>
        /// <param name="validation"></param>
        /// <param name="requiredWhen"></param>
        /// <param name="type"></param>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrantFieldVariant2(
            string description,
            bool required,
            global::System.Collections.Generic.IList<global::Vercel.RegistrantFieldVariant2Option> options,
            string? label,
            string? validation,
            global::Vercel.AnyOf<string, global::Vercel.RegistrantFieldVariant2RequiredWhen>? requiredWhen,
            global::Vercel.RegistrantFieldVariant2Type type,
            object? fields)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.Label = label;
            this.Validation = validation;
            this.RequiredWhen = requiredWhen;
            this.Type = type;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant2" /> class.
        /// </summary>
        public RegistrantFieldVariant2()
        {
        }
    }
}