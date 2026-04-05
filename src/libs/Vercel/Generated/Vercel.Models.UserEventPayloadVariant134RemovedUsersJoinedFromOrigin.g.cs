
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant134RemovedUsersJoinedFromOrigin
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
    public static class UserEventPayloadVariant134RemovedUsersJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant134RemovedUsersJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant134RemovedUsersJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbRedeploy,
                "nsnb-request-access" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant134RemovedUsersJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}