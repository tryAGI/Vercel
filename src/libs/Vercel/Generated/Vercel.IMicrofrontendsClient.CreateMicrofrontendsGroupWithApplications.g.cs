#nullable enable

namespace Vercel
{
    public partial interface IMicrofrontendsClient
    {
        /// <summary>
        /// Create a microfrontends group with applications<br/>
        /// Creates a microfrontends group and attaches multiple projects in a single request.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateMicrofrontendsGroupWithApplicationsResponse> CreateMicrofrontendsGroupWithApplicationsAsync(

            global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a microfrontends group with applications<br/>
        /// Creates a microfrontends group and attaches multiple projects in a single request.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateMicrofrontendsGroupWithApplicationsResponse> CreateMicrofrontendsGroupWithApplicationsAsync(
            string groupName,
            global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestDefaultApp defaultApp,
            global::System.Collections.Generic.IList<global::Vercel.CreateMicrofrontendsGroupWithApplicationsRequestOtherApplication> otherApplications,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}