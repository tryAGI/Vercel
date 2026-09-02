
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current state of the endpoint. - `creating`: the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.<br/>
    /// Example: available
    /// </summary>
    public enum PrivateLinkEndpointStatus
    {
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        Available,
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        Creating,
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        Deleting,
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        Failed,
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        PendingAcceptance,
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        Provisioning,
        /// <summary>
        /// the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLinkEndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLinkEndpointStatus value)
        {
            return value switch
            {
                PrivateLinkEndpointStatus.Available => "available",
                PrivateLinkEndpointStatus.Creating => "creating",
                PrivateLinkEndpointStatus.Deleting => "deleting",
                PrivateLinkEndpointStatus.Failed => "failed",
                PrivateLinkEndpointStatus.PendingAcceptance => "pending-acceptance",
                PrivateLinkEndpointStatus.Provisioning => "provisioning",
                PrivateLinkEndpointStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLinkEndpointStatus? ToEnum(string value)
        {
            return value switch
            {
                "available" => PrivateLinkEndpointStatus.Available,
                "creating" => PrivateLinkEndpointStatus.Creating,
                "deleting" => PrivateLinkEndpointStatus.Deleting,
                "failed" => PrivateLinkEndpointStatus.Failed,
                "pending-acceptance" => PrivateLinkEndpointStatus.PendingAcceptance,
                "provisioning" => PrivateLinkEndpointStatus.Provisioning,
                "rejected" => PrivateLinkEndpointStatus.Rejected,
                _ => null,
            };
        }
    }
}