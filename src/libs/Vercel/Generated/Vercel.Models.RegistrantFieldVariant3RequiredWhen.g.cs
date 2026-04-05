
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegistrantFieldVariant3RequiredWhen
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ValueIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant3RequiredWhen" /> class.
        /// </summary>
        /// <param name="valueIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrantFieldVariant3RequiredWhen(
            global::System.Collections.Generic.IList<string> valueIn)
        {
            this.ValueIn = valueIn ?? throw new global::System.ArgumentNullException(nameof(valueIn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant3RequiredWhen" /> class.
        /// </summary>
        public RegistrantFieldVariant3RequiredWhen()
        {
        }
    }
}