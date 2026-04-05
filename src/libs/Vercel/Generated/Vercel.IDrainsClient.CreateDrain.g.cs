#nullable enable

namespace Vercel
{
    public partial interface IDrainsClient
    {
        /// <summary>
        /// Create a new Drain<br/>
        /// Create a new Drain with the provided configuration.
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.CreateDrainResponseVariant1, global::Vercel.CreateDrainResponseVariant2>> CreateDrainAsync(

            global::Vercel.CreateDrainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Drain<br/>
        /// Create a new Drain with the provided configuration.
        /// </summary>
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
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.CreateDrainResponseVariant1, global::Vercel.CreateDrainResponseVariant2>> CreateDrainAsync(
            string name,
            global::Vercel.CreateDrainRequestProjects projects,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateDrainRequestSchemas2> schemas,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::Vercel.OneOf<string, global::Vercel.CreateDrainRequestFilter>? filter = default,
            global::Vercel.OneOf<global::Vercel.CreateDrainRequestDeliveryVariant1, global::Vercel.CreateDrainRequestDeliveryVariant2>? delivery = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateDrainRequestSamplingItem>? sampling = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateDrainRequestTransform>? transforms = default,
            global::Vercel.OneOf<global::Vercel.OneOf<global::Vercel.CreateDrainRequestSourceVariant1, global::Vercel.CreateDrainRequestSourceVariant2, global::Vercel.CreateDrainRequestSourceVariant3>?, global::Vercel.CreateDrainRequestSource2>? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}