#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace tryAGI.Vercel;

/// <summary>
/// MEAI AIFunction tool extensions for VercelClient.
/// </summary>
[System.CLSCompliant(false)]
public static class VercelClientExtensions
{
    /// <summary>
    /// Returns all Vercel tools as a list of AIFunction instances.
    /// </summary>
    public static IList<AIFunction> AsTools(this global::Vercel.VercelClient client)
    {
        return
        [
            client.AsListProjectsTool(),
            client.AsGetProjectTool(),
            client.AsListDeploymentsTool(),
            client.AsGetDeploymentTool(),
            client.AsListDomainsTool(),
        ];
    }

    /// <summary>
    /// Creates an AIFunction tool that lists Vercel projects.
    /// </summary>
    public static AIFunction AsListProjectsTool(this global::Vercel.VercelClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.GetProjectsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.ToString();
            },
            name: "Vercel_ListProjects",
            description: "List all Vercel projects for the authenticated user or team.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a specific Vercel project by name or ID.
    /// </summary>
    public static AIFunction AsGetProjectTool(this global::Vercel.VercelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The project name or ID")] string projectIdOrName,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.GetProjectAsync(
                    idOrName: projectIdOrName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Name,
                    response.Framework,
                    response.NodeVersion,
                    response.BuildCommand,
                    response.DevCommand,
                    response.OutputDirectory,
                    response.RootDirectory,
                    response.CreatedAt,
                    response.UpdatedAt,
                };
            },
            name: "Vercel_GetProject",
            description: "Get detailed information about a specific Vercel project including framework, node version, and build configuration.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists deployments.
    /// </summary>
    public static AIFunction AsListDeploymentsTool(this global::Vercel.VercelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Filter by project ID (optional)")] string? projectId,
                   [Description("Maximum number of deployments to return (optional)")] double? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Deployments.GetDeploymentsAsync(
                    projectId: projectId,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Deployments?.Select(d => new
                {
                    d.Uid,
                    d.Name,
                    d.Url,
                    d.State,
                    d.Created,
                    d.Target,
                    d.Source,
                    Creator = d.Creator?.Username,
                }).ToList();
            },
            name: "Vercel_ListDeployments",
            description: "List Vercel deployments, optionally filtered by project. Returns deployment URL, state, target, and creator info.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a specific deployment.
    /// </summary>
    public static AIFunction AsGetDeploymentTool(this global::Vercel.VercelClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The deployment ID or URL")] string deploymentId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Deployments.GetDeploymentAsync(
                    idOrUrl: deploymentId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.ToString();
            },
            name: "Vercel_GetDeployment",
            description: "Get detailed information about a specific Vercel deployment by ID or URL.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists domains.
    /// </summary>
    public static AIFunction AsListDomainsTool(this global::Vercel.VercelClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Domains.GetDomainsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Domains?.Select(d => new
                {
                    d.Name,
                    d.Verified,
                    d.CreatedAt,
                    d.ExpiresAt,
                    d.Nameservers,
                }).ToList();
            },
            name: "Vercel_ListDomains",
            description: "List all domains registered with the authenticated Vercel user or team, including verification status and expiry.");
    }
}
