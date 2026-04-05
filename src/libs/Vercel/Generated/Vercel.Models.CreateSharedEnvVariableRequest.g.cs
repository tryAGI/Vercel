
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSharedEnvVariableRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableRequestEv> Evs { get; set; }

        /// <summary>
        /// The type of environment variable<br/>
        /// Example: encrypted
        /// </summary>
        /// <example>encrypted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateSharedEnvVariableRequestTypeJsonConverter))]
        public global::Vercel.CreateSharedEnvVariableRequestType? Type { get; set; }

        /// <summary>
        /// The target environment of the Shared Environment Variable<br/>
        /// Example: [production, preview]
        /// </summary>
        /// <example>[production, preview]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableRequestTargetItem>? Target { get; set; }

        /// <summary>
        /// Associate a Shared Environment Variable to projects.<br/>
        /// Example: [prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrHRCRV]
        /// </summary>
        /// <example>[prj_2WjyKQmM8ZnGcJsPWMrHRHrE, prj_2WjyKQmM8ZnGcJsPWMrHRCRV]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSharedEnvVariableRequest" /> class.
        /// </summary>
        /// <param name="evs"></param>
        /// <param name="type">
        /// The type of environment variable<br/>
        /// Example: encrypted
        /// </param>
        /// <param name="target">
        /// The target environment of the Shared Environment Variable<br/>
        /// Example: [production, preview]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSharedEnvVariableRequest(
            global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableRequestEv> evs,
            global::Vercel.CreateSharedEnvVariableRequestType? type,
            global::System.Collections.Generic.IList<global::Vercel.CreateSharedEnvVariableRequestTargetItem>? target)
        {
            this.Evs = evs ?? throw new global::System.ArgumentNullException(nameof(evs));
            this.Type = type;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSharedEnvVariableRequest" /> class.
        /// </summary>
        public CreateSharedEnvVariableRequest()
        {
        }
    }
}