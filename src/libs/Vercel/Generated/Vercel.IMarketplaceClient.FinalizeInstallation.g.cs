#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Finalize Installation<br/>
        /// This endpoint allows the partner to mark an installation as finalized. This means you will not send any more invoices for the installation. Use this after a customer has requested uninstall and you have sent any remaining invoices. This will allow the uninstall process to proceed immediately after all invoices have been paid. &lt;br/&gt; Use the `credentials.access_token` we provided in the [Upsert Installation](#upsert-installation) body to authorize this request.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task FinalizeInstallationAsync(
            string integrationConfigurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}