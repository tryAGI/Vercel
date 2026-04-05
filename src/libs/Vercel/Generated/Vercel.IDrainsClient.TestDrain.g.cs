#nullable enable

namespace Vercel
{
    public partial interface IDrainsClient
    {
        /// <summary>
        /// Validate Drain delivery configuration<br/>
        /// Validate the delivery configuration of a Drain using sample events.
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.TestDrainResponseVariant2>> TestDrainAsync(

            global::Vercel.TestDrainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Drain delivery configuration<br/>
        /// Validate the delivery configuration of a Drain using sample events.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="schemas"></param>
        /// <param name="delivery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<object, global::Vercel.TestDrainResponseVariant2>> TestDrainAsync(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.TestDrainRequestSchemas2> schemas,
            global::Vercel.OneOf<global::Vercel.TestDrainRequestDeliveryVariant1, global::Vercel.TestDrainRequestDeliveryVariant2> delivery,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}