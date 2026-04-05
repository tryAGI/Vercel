#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Update Resource Secrets<br/>
        /// This endpoint updates the secrets of a resource. If a resource has projects connected, the connected secrets are updated with the new secrets. The old secrets may still be used by existing connected projects because they are not automatically redeployed. Redeployment is a manual action and must be completed by the user. All new project connections will use the new secrets.&lt;br/&gt; &lt;br/&gt; Use cases for this endpoint:&lt;br/&gt; &lt;br/&gt; - Resetting the credentials of a database in the partner. If the user requests the credentials to be updated in the partner’s application, the partner post the new set of secrets to Vercel, the user should redeploy their application and the expire the old credentials.&lt;br/&gt;
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateResourceSecretsByIdAsync(
            string integrationConfigurationId,
            string resourceId,

            global::Vercel.UpdateResourceSecretsByIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Resource Secrets<br/>
        /// This endpoint updates the secrets of a resource. If a resource has projects connected, the connected secrets are updated with the new secrets. The old secrets may still be used by existing connected projects because they are not automatically redeployed. Redeployment is a manual action and must be completed by the user. All new project connections will use the new secrets.&lt;br/&gt; &lt;br/&gt; Use cases for this endpoint:&lt;br/&gt; &lt;br/&gt; - Resetting the credentials of a database in the partner. If the user requests the credentials to be updated in the partner’s application, the partner post the new set of secrets to Vercel, the user should redeploy their application and the expire the old credentials.&lt;br/&gt;
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="secrets"></param>
        /// <param name="partial">
        /// If true, will only overwrite the provided secrets instead of replacing all secrets.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateResourceSecretsByIdAsync(
            string integrationConfigurationId,
            string resourceId,
            global::System.Collections.Generic.IList<global::Vercel.UpdateResourceSecretsByIdRequestSecret> secrets,
            bool? partial = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}