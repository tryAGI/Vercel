#nullable enable

namespace Vercel
{
    public partial interface ICertsClient
    {
        /// <summary>
        /// Upload a cert<br/>
        /// Upload a cert
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
        global::System.Threading.Tasks.Task<global::Vercel.UploadCertResponse> UploadCertAsync(

            global::Vercel.UploadCertRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a cert<br/>
        /// Upload a cert
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="ca">
        /// The certificate authority
        /// </param>
        /// <param name="key">
        /// The certificate key
        /// </param>
        /// <param name="cert">
        /// The certificate
        /// </param>
        /// <param name="skipValidation">
        /// Skip validation of the certificate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UploadCertResponse> UploadCertAsync(
            string ca,
            string key,
            string cert,
            string? teamId = default,
            string? slug = default,
            bool? skipValidation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}