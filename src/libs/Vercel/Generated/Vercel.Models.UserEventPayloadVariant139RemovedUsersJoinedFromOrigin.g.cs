
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant139RemovedUsersJoinedFromOrigin
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
    public static class UserEventPayloadVariant139RemovedUsersJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant139RemovedUsersJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant139RemovedUsersJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant139RemovedUsersJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}