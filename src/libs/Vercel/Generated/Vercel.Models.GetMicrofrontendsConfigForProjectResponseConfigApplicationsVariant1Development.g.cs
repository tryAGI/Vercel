
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Development configuration for the default application.
    /// </summary>
    public sealed partial class GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development
    {
        /// <summary>
        /// Fallback for local development, could point to any environment. This is required for the default app. This value is used as the fallback for child apps as well if they do not have a fallback. If passing a string, include the protocol (optional), host (required) and port (optional). For example: `https://this.ismyhost:8080`. If omitted, the protocol defaults to HTTPS. If omitted, the port defaults to `80` for HTTP and `443` for HTTPS. See https://vercel.com/docs/microfrontends/local-development.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fallback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? Local { get; set; }

        /// <summary>
        /// The task to run when starting the development server. Should reference a script in the package.json of the application. The default value is "dev". See https://vercel.com/docs/microfrontends/local-development.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development" /> class.
        /// </summary>
        /// <param name="fallback">
        /// Fallback for local development, could point to any environment. This is required for the default app. This value is used as the fallback for child apps as well if they do not have a fallback. If passing a string, include the protocol (optional), host (required) and port (optional). For example: `https://this.ismyhost:8080`. If omitted, the protocol defaults to HTTPS. If omitted, the port defaults to `80` for HTTP and `443` for HTTPS. See https://vercel.com/docs/microfrontends/local-development.
        /// </param>
        /// <param name="local"></param>
        /// <param name="task">
        /// The task to run when starting the development server. Should reference a script in the package.json of the application. The default value is "dev". See https://vercel.com/docs/microfrontends/local-development.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development(
            string fallback,
            global::Vercel.OneOf<string, double?>? local,
            string? task)
        {
            this.Fallback = fallback ?? throw new global::System.ArgumentNullException(nameof(fallback));
            this.Local = local;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development" /> class.
        /// </summary>
        public GetMicrofrontendsConfigForProjectResponseConfigApplicationsVariant1Development()
        {
        }
    }
}