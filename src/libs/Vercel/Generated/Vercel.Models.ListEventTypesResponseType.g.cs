
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEventTypesResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReplacedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListEventTypesResponseTypeNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListEventTypesResponseTypeName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventTypesResponseType" /> class.
        /// </summary>
        /// <param name="replacedBy"></param>
        /// <param name="deprecated"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEventTypesResponseType(
            global::System.Collections.Generic.IList<string> replacedBy,
            bool deprecated,
            global::Vercel.ListEventTypesResponseTypeName name,
            string description)
        {
            this.ReplacedBy = replacedBy ?? throw new global::System.ArgumentNullException(nameof(replacedBy));
            this.Deprecated = deprecated;
            this.Name = name;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventTypesResponseType" /> class.
        /// </summary>
        public ListEventTypesResponseType()
        {
        }
    }
}