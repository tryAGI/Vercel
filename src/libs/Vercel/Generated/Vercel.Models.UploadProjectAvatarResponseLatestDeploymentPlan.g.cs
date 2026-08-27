
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseLatestDeploymentPlan
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Hobby,
        /// <summary>
        ///
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseLatestDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLatestDeploymentPlan value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLatestDeploymentPlan.Enterprise => "enterprise",
                UploadProjectAvatarResponseLatestDeploymentPlan.Hobby => "hobby",
                UploadProjectAvatarResponseLatestDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLatestDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UploadProjectAvatarResponseLatestDeploymentPlan.Enterprise,
                "hobby" => UploadProjectAvatarResponseLatestDeploymentPlan.Hobby,
                "pro" => UploadProjectAvatarResponseLatestDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}