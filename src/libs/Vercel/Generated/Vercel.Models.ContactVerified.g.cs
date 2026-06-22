
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The registrant contact has been verified.
    /// </summary>
    public sealed partial class ContactVerified
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactVerified" /> class.
        /// </summary>
        /// <param name="verified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactVerified(
            bool verified)
        {
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactVerified" /> class.
        /// </summary>
        public ContactVerified()
        {
        }

    }
}