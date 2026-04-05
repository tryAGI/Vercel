
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegistrantFieldVariant2RequiredWhen
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
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant2RequiredWhen" /> class.
        /// </summary>
        /// <param name="valueIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegistrantFieldVariant2RequiredWhen(
            global::System.Collections.Generic.IList<string> valueIn)
        {
            this.ValueIn = valueIn ?? throw new global::System.ArgumentNullException(nameof(valueIn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrantFieldVariant2RequiredWhen" /> class.
        /// </summary>
        public RegistrantFieldVariant2RequiredWhen()
        {
        }
    }
}