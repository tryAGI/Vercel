
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant227
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public global::Vercel.UserEventPayloadVariant227Geolocation? Geolocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public string? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        public string? Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoType")]
        public string? SsoType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factors")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant227Factor>? Factors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaOTP")]
        public bool? ViaOTP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaGithub")]
        public bool? ViaGithub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaGitlab")]
        public bool? ViaGitlab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaBitbucket")]
        public bool? ViaBitbucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaGoogle")]
        public bool? ViaGoogle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaApple")]
        public bool? ViaApple { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaSamlSso")]
        public bool? ViaSamlSso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viaPasskey")]
        public bool? ViaPasskey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant227" /> class.
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="geolocation"></param>
        /// <param name="env"></param>
        /// <param name="os"></param>
        /// <param name="username"></param>
        /// <param name="ssoType"></param>
        /// <param name="factors"></param>
        /// <param name="viaOTP"></param>
        /// <param name="viaGithub"></param>
        /// <param name="viaGitlab"></param>
        /// <param name="viaBitbucket"></param>
        /// <param name="viaGoogle"></param>
        /// <param name="viaApple"></param>
        /// <param name="viaSamlSso"></param>
        /// <param name="viaPasskey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant227(
            string? userAgent,
            global::Vercel.UserEventPayloadVariant227Geolocation? geolocation,
            string? env,
            string? os,
            string? username,
            string? ssoType,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant227Factor>? factors,
            bool? viaOTP,
            bool? viaGithub,
            bool? viaGitlab,
            bool? viaBitbucket,
            bool? viaGoogle,
            bool? viaApple,
            bool? viaSamlSso,
            bool? viaPasskey)
        {
            this.UserAgent = userAgent;
            this.Geolocation = geolocation;
            this.Env = env;
            this.Os = os;
            this.Username = username;
            this.SsoType = ssoType;
            this.Factors = factors;
            this.ViaOTP = viaOTP;
            this.ViaGithub = viaGithub;
            this.ViaGitlab = viaGitlab;
            this.ViaBitbucket = viaBitbucket;
            this.ViaGoogle = viaGoogle;
            this.ViaApple = viaApple;
            this.ViaSamlSso = viaSamlSso;
            this.ViaPasskey = viaPasskey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant227" /> class.
        /// </summary>
        public UserEventPayloadVariant227()
        {
        }
    }
}