
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegistrantFieldVariant4
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::Vercel.RegistrantFieldVariant4RequiredWhen>))]
        public global::Vercel.AnyOf<string, global::Vercel.RegistrantFieldVariant4RequiredWhen>? RequiredWhen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RegistrantFieldVariant4TypeJsonConverter))]
        public global::Vercel.RegistrantFieldVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant4" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="label"></param>
        /// <param name="validation"></param>
        /// <param name="requiredWhen"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrantFieldVariant4(
            string description,
            bool required,
            string? label,
            string? validation,
            global::Vercel.AnyOf<string, global::Vercel.RegistrantFieldVariant4RequiredWhen>? requiredWhen,
            global::Vercel.RegistrantFieldVariant4Type type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.Label = label;
            this.Validation = validation;
            this.RequiredWhen = requiredWhen;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant4" /> class.
        /// </summary>
        public RegistrantFieldVariant4()
        {
        }
    }
}