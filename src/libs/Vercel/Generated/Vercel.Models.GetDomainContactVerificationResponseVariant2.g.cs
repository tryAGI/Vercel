
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDomainContactVerificationResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// a string to be decoded into a Date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifyBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VerifyBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainContactVerificationResponseVariant2" /> class.
        /// </summary>
        /// <param name="verified"></param>
        /// <param name="verifyBy">
        /// a string to be decoded into a Date
        /// </param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainContactVerificationResponseVariant2(
            bool verified,
            string verifyBy,
            string email)
        {
            this.Verified = verified;
            this.VerifyBy = verifyBy ?? throw new global::System.ArgumentNullException(nameof(verifyBy));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainContactVerificationResponseVariant2" /> class.
        /// </summary>
        public GetDomainContactVerificationResponseVariant2()
        {
        }

    }
}