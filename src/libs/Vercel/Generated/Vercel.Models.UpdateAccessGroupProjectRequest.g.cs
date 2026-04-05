
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAccessGroupProjectRequest
    {
        /// <summary>
        /// The project role that will be added to this Access Group.<br/>
        /// Example: ADMIN
        /// </summary>
        /// <example>ADMIN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateAccessGroupProjectRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateAccessGroupProjectRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessGroupProjectRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// The project role that will be added to this Access Group.<br/>
        /// Example: ADMIN
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAccessGroupProjectRequest(
            global::Vercel.UpdateAccessGroupProjectRequestRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessGroupProjectRequest" /> class.
        /// </summary>
        public UpdateAccessGroupProjectRequest()
        {
        }
    }
}