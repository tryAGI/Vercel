
#nullable enable

namespace Vercel
{
    /// <summary>
    /// move-out
    /// </summary>
    public sealed partial class PatchDomainRequestVariant2
    {
        /// <summary>
        /// Example: move-out
        /// </summary>
        /// <example>move-out</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        public string? Op { get; set; }

        /// <summary>
        /// User or team to move domain to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public string? Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainRequestVariant2" /> class.
        /// </summary>
        /// <param name="op">
        /// Example: move-out
        /// </param>
        /// <param name="destination">
        /// User or team to move domain to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDomainRequestVariant2(
            string? op,
            string? destination)
        {
            this.Op = op;
            this.Destination = destination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDomainRequestVariant2" /> class.
        /// </summary>
        public PatchDomainRequestVariant2()
        {
        }
    }
}