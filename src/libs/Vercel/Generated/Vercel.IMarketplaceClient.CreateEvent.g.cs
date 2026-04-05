#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Create Event<br/>
        /// Partner notifies Vercel of any changes made to an Installation or a Resource. Vercel is expected to use `list-resources` and other read APIs to get the new state.&lt;br/&gt; &lt;br/&gt; `resource.updated` event should be dispatched when any state of a resource linked to Vercel is modified by the partner.&lt;br/&gt; `installation.updated` event should be dispatched when an installation's billing plan is changed via the provider instead of Vercel.&lt;br/&gt; &lt;br/&gt; Resource update use cases: &lt;br/&gt; &lt;br/&gt; - The user renames a database in the partner’s application. The partner should dispatch a `resource.updated` event to notify Vercel to update the resource in Vercel’s datastores.&lt;br/&gt; - A resource has been suspended due to a lack of use. The partner should dispatch a `resource.updated` event to notify Vercel to update the resource's status in Vercel's datastores.&lt;br/&gt;
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateEventAsync(
            string integrationConfigurationId,

            global::Vercel.CreateEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Event<br/>
        /// Partner notifies Vercel of any changes made to an Installation or a Resource. Vercel is expected to use `list-resources` and other read APIs to get the new state.&lt;br/&gt; &lt;br/&gt; `resource.updated` event should be dispatched when any state of a resource linked to Vercel is modified by the partner.&lt;br/&gt; `installation.updated` event should be dispatched when an installation's billing plan is changed via the provider instead of Vercel.&lt;br/&gt; &lt;br/&gt; Resource update use cases: &lt;br/&gt; &lt;br/&gt; - The user renames a database in the partner’s application. The partner should dispatch a `resource.updated` event to notify Vercel to update the resource in Vercel’s datastores.&lt;br/&gt; - A resource has been suspended due to a lack of use. The partner should dispatch a `resource.updated` event to notify Vercel to update the resource's status in Vercel's datastores.&lt;br/&gt;
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="event"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateEventAsync(
            string integrationConfigurationId,
            global::Vercel.OneOf<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2> @event,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}