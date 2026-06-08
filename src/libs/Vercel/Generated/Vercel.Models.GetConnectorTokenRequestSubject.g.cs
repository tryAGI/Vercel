
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectorTokenRequestSubject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        public string? Sub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iss")]
        public string? Iss { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aud")]
        public string? Aud { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalClaims")]
        public object? AdditionalClaims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorTokenRequestSubject" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="issuer"></param>
        /// <param name="sub"></param>
        /// <param name="iss"></param>
        /// <param name="aud"></param>
        /// <param name="additionalClaims"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectorTokenRequestSubject(
            string type,
            string? id,
            string? issuer,
            string? sub,
            string? iss,
            string? aud,
            object? additionalClaims)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id;
            this.Issuer = issuer;
            this.Sub = sub;
            this.Iss = iss;
            this.Aud = aud;
            this.AdditionalClaims = additionalClaims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorTokenRequestSubject" /> class.
        /// </summary>
        public GetConnectorTokenRequestSubject()
        {
        }

    }
}