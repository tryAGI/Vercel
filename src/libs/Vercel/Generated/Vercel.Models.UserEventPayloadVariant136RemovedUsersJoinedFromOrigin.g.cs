
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant136RemovedUsersJoinedFromOrigin
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
    public static class UserEventPayloadVariant136RemovedUsersJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant136RemovedUsersJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant136RemovedUsersJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant136RemovedUsersJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}