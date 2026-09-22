
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf9b373cd1ded5c73
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedceccd47983fcf9de> Properties { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf9b373cd1ded5c73TypeJsonConverter))]
        public global::Vercel.AutoSDKSharedf9b373cd1ded5c73Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui:order")]
        public global::System.Collections.Generic.IList<string>? Ui_order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf9b373cd1ded5c73" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        /// <param name="type"></param>
        /// <param name="ui_order"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf9b373cd1ded5c73(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKSharedceccd47983fcf9de> properties,
            global::System.Collections.Generic.IList<string>? required,
            global::Vercel.AutoSDKSharedf9b373cd1ded5c73Type type,
            global::System.Collections.Generic.IList<string>? ui_order)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Required = required;
            this.Type = type;
            this.Ui_order = ui_order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf9b373cd1ded5c73" /> class.
        /// </summary>
        public AutoSDKSharedf9b373cd1ded5c73()
        {
        }

    }
}