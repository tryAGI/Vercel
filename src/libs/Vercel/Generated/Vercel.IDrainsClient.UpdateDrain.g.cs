#nullable enable

namespace Vercel
{
    public partial interface IDrainsClient
    {
        /// <summary>
        /// Update an existing Drain<br/>
        /// Update the configuration of an existing drain.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1, global::Vercel.UpdateDrainResponseVariant2>> UpdateDrainAsync(
            string id,

            global::Vercel.UpdateDrainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing Drain<br/>
        /// Update the configuration of an existing drain.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name"></param>
        /// <param name="projects"></param>
        /// <param name="projectIds"></param>
        /// <param name="filter"></param>
        /// <param name="schemas"></param>
        /// <param name="delivery"></param>
        /// <param name="sampling"></param>
        /// <param name="transforms"></param>
        /// <param name="status"></param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UpdateDrainResponseVariant1, global::Vercel.UpdateDrainResponseVariant2>> UpdateDrainAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            global::Vercel.UpdateDrainRequestProjects? projects = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::Vercel.OneOf<string, global::Vercel.UpdateDrainRequestFilter>? filter = default,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.UpdateDrainRequestSchemas2>? schemas = default,
            global::Vercel.OneOf<global::Vercel.UpdateDrainRequestDeliveryVariant1, global::Vercel.UpdateDrainRequestDeliveryVariant2>? delivery = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestSamplingItem>? sampling = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateDrainRequestTransform>? transforms = default,
            global::Vercel.UpdateDrainRequestStatus? status = default,
            global::Vercel.OneOf<global::Vercel.OneOf<global::Vercel.UpdateDrainRequestSourceVariant1, global::Vercel.UpdateDrainRequestSourceVariant2, global::Vercel.UpdateDrainRequestSourceVariant3>?, global::Vercel.UpdateDrainRequestSource2>? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}