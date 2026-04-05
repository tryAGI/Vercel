#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update the microfrontends settings<br/>
        /// Update the microfrontends settings for a project.
        /// </summary>
        /// <param name="projectId">
        /// The unique project identifier<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateMicrofrontendsResponse> UpdateMicrofrontendsAsync(
            string projectId,

            global::Vercel.UpdateMicrofrontendsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the microfrontends settings<br/>
        /// Update the microfrontends settings for a project.
        /// </summary>
        /// <param name="projectId">
        /// The unique project identifier<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="microfrontendsGroupId">
        /// The unique group identifier to add this microfrontend to<br/>
        /// Example: mfe_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="enabled">
        /// Enable or disable microfrontends for the project<br/>
        /// Example: true
        /// </param>
        /// <param name="isDefaultApp">
        /// Whether the application is the default application for the microfrontends group<br/>
        /// Example: true
        /// </param>
        /// <param name="defaultRoute">
        /// The default route used for screenshots and preview links for the project<br/>
        /// Example: /home
        /// </param>
        /// <param name="routeObservabilityToThisProject">
        /// Whether observability data should be routed to this project or a root project. Can only be set for child applications.
        /// </param>
        /// <param name="doNotRouteWithMicrofrontendsRouting">
        /// Whether domains in this project should route as a microfrontend. Can only be set for child applications.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateMicrofrontendsResponse> UpdateMicrofrontendsAsync(
            string projectId,
            string? teamId = default,
            string? slug = default,
            string? microfrontendsGroupId = default,
            bool? enabled = default,
            bool? isDefaultApp = default,
            string? defaultRoute = default,
            bool? routeObservabilityToThisProject = default,
            bool? doNotRouteWithMicrofrontendsRouting = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}