
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant148RemovedUsersJoinedFromOrigin
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
    public static class UserEventPayloadVariant148RemovedUsersJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant148RemovedUsersJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant148RemovedUsersJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant148RemovedUsersJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}