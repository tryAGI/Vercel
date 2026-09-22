
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedceccd47983fcf9deVariant4Items
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMaximum")]
        public double? ExclusiveMaximum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMinimum")]
        public double? ExclusiveMinimum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedceccd47983fcf9deVariant4ItemsTypeJsonConverter))]
        public global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4ItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant4Items" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="exclusiveMaximum"></param>
        /// <param name="exclusiveMinimum"></param>
        /// <param name="maximum"></param>
        /// <param name="minimum"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedceccd47983fcf9deVariant4Items(
            double? @default,
            string? description,
            double? exclusiveMaximum,
            double? exclusiveMinimum,
            double? maximum,
            double? minimum,
            global::Vercel.AutoSDKSharedceccd47983fcf9deVariant4ItemsType type)
        {
            this.Default = @default;
            this.Description = description;
            this.ExclusiveMaximum = exclusiveMaximum;
            this.ExclusiveMinimum = exclusiveMinimum;
            this.Maximum = maximum;
            this.Minimum = minimum;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedceccd47983fcf9deVariant4Items" /> class.
        /// </summary>
        public AutoSDKSharedceccd47983fcf9deVariant4Items()
        {
        }

    }
}