#nullable enable

namespace Vercel
{
    public partial interface IArtifactsClient
    {
        /// <summary>
        /// Record an artifacts cache usage event<br/>
        /// Records an artifacts cache usage event. The body of this request is an array of cache usage events. The supported event types are `HIT` and `MISS`. The source is either `LOCAL` the cache event was on the users filesystem cache or `REMOTE` if the cache event is for a remote cache. When the event is a `HIT` the request also accepts a number `duration` which is the time taken to generate the artifact in the cache.
        /// </summary>
        /// <param name="xArtifactClientCi">
        /// The continuous integration or delivery environment where this artifact is downloaded.<br/>
        /// Example: VERCEL
        /// </param>
        /// <param name="xArtifactClientInteractive">
        /// 1 if the client is an interactive shell. Otherwise 0<br/>
        /// Example: 0
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
        global::System.Threading.Tasks.Task RecordEventsAsync(

            global::System.Collections.Generic.IList<global::Vercel.RecordEventsRequestItem> request,
            string? xArtifactClientCi = default,
            int? xArtifactClientInteractive = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}