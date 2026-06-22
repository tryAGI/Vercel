
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseServiceVariant2Redirect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permanent")]
        public bool? Permanent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public double? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2RedirectHaVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2RedirectHaVariant2>>? Has { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<string>? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseServiceVariant2Redirect" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="permanent"></param>
        /// <param name="statusCode"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseServiceVariant2Redirect(
            string source,
            string destination,
            bool? permanent,
            double? statusCode,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2RedirectHaVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2RedirectHaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant1, global::Vercel.CreateDeploymentResponseServiceVariant2RedirectMissingItemVariant2>>? missing,
            global::System.Collections.Generic.IList<string>? env)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Permanent = permanent;
            this.StatusCode = statusCode;
            this.Has = has;
            this.Missing = missing;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseServiceVariant2Redirect" /> class.
        /// </summary>
        public CreateDeploymentResponseServiceVariant2Redirect()
        {
        }

    }
}