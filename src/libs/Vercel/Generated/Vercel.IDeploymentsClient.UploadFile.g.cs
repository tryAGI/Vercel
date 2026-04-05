#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Upload Deployment Files<br/>
        /// Before you create a deployment you need to upload the required files for that deployment. To do it, you need to first upload each file to this endpoint. Once that's completed, you can create a new deployment with the uploaded files. The file content must be placed inside the body of the request. In the case of a successful response you'll receive a status code 200 with an empty body.
        /// </summary>
        /// <param name="contentLength">
        /// The file size in bytes
        /// </param>
        /// <param name="xVercelDigest">
        /// The file SHA1 used to check the integrity
        /// </param>
        /// <param name="xNowDigest">
        /// The file SHA1 used to check the integrity
        /// </param>
        /// <param name="xNowSize">
        /// The file size as an alternative to `Content-Length`
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.UploadFileResponseVariant1, object>> UploadFileAsync(

            byte[] request,
            double? contentLength = default,
            string? xVercelDigest = default,
            string? xNowDigest = default,
            double? xNowSize = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}