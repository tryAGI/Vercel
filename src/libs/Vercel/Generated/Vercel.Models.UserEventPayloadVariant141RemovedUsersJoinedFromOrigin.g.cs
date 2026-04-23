
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant141RemovedUsersJoinedFromOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Dsync,
        /// <summary>
        /// 
        /// </summary>
        Feedback,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        Mail,
        /// <summary>
        /// 
        /// </summary>
        NsnbAutoApprove,
        /// <summary>
        /// 
        /// </summary>
        NsnbHobbyUpgrade,
        /// <summary>
        /// 
        /// </summary>
        NsnbInvite,
        /// <summary>
        /// 
        /// </summary>
        NsnbRedeploy,
        /// <summary>
        /// 
        /// </summary>
        NsnbRedeployAttributionCard,
        /// <summary>
        /// 
        /// </summary>
        NsnbRequestAccess,
        /// <summary>
        /// 
        /// </summary>
        NsnbViewerUpgrade,
        /// <summary>
        /// 
        /// </summary>
        OrganizationTeams,
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant141RemovedUsersJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant141RemovedUsersJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant141RemovedUsersJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant141RemovedUsersJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}