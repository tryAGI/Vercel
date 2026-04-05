
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMicrofrontendsGroupWithApplicationsRequest
    {
        /// <summary>
        /// The name of the microfrontends group that will be used to identify the group<br/>
        /// Example: MFE Group 1
        /// </summary>
        /// <example>MFE Group 1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupName { get; set; }

        /// <summary>
        /// The default app for the new microfrontend group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultApp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestDefaultApp DefaultApp { get; set; }

        /// <summary>
        /// The list of other applications that will be used in the new microfrontend group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otherApplications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication> OtherApplications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrofrontendsGroupWithApplicationsRequest" /> class.
        /// </summary>
        /// <param name="groupName">
        /// The name of the microfrontends group that will be used to identify the group<br/>
        /// Example: MFE Group 1
        /// </param>
        /// <param name="defaultApp">
        /// The default app for the new microfrontend group
        /// </param>
        /// <param name="otherApplications">
        /// The list of other applications that will be used in the new microfrontend group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMicrofrontendsGroupWithApplicationsRequest(
            string groupName,
            global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestDefaultApp defaultApp,
            global::System.Collections.Generic.IList<global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication> otherApplications)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.DefaultApp = defaultApp ?? throw new global::System.ArgumentNullException(nameof(defaultApp));
            this.OtherApplications = otherApplications ?? throw new global::System.ArgumentNullException(nameof(otherApplications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrofrontendsGroupWithApplicationsRequest" /> class.
        /// </summary>
        public CreateMicrofrontendsGroupWithApplicationsRequest()
        {
        }
    }
}