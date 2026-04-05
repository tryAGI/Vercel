
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagSettingsResponseEntitie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsResponseEntitieAttribute> Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponseEntitie" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="label"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagSettingsResponseEntitie(
            string kind,
            string label,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagSettingsResponseEntitieAttribute> attributes)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagSettingsResponseEntitie" /> class.
        /// </summary>
        public UpdateFlagSettingsResponseEntitie()
        {
        }
    }
}