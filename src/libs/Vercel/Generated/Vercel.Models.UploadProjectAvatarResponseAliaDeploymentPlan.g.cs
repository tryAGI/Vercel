
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentPlan
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
    public static class UploadProjectAvatarResponseAliaDeploymentPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentPlan value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentPlan.Enterprise => "enterprise",
                UploadProjectAvatarResponseAliaDeploymentPlan.Hobby => "hobby",
                UploadProjectAvatarResponseAliaDeploymentPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UploadProjectAvatarResponseAliaDeploymentPlan.Enterprise,
                "hobby" => UploadProjectAvatarResponseAliaDeploymentPlan.Hobby,
                "pro" => UploadProjectAvatarResponseAliaDeploymentPlan.Pro,
                _ => null,
            };
        }
    }
}