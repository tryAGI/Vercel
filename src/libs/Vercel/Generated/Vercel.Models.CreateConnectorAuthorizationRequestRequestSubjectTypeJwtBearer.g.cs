
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerTypeJsonConverter))]
        public global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sub"></param>
        /// <param name="iss"></param>
        /// <param name="aud"></param>
        /// <param name="additionalClaims"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer(
            global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType type,
            string? sub,
            string? iss,
            string? aud,
            object? additionalClaims)
        {
            this.Type = type;
            this.Sub = sub;
            this.Iss = iss;
            this.Aud = aud;
            this.AdditionalClaims = additionalClaims;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer" /> class.
        /// </summary>
        public CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer()
        {
        }

    }
}