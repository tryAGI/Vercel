
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UploadProjectAvatarResponseLatestDeploymentBranchMatcherType
    {
        /// <summary>
        ///
        /// </summary>
        EndsWith,
        /// <summary>
        ///
        /// </summary>
        Equals,
        /// <summary>
        ///
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseLatestDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLatestDeploymentBranchMatcherType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLatestDeploymentBranchMatcherType.EndsWith => "endsWith",
                UploadProjectAvatarResponseLatestDeploymentBranchMatcherType.Equals => "equals",
                UploadProjectAvatarResponseLatestDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLatestDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UploadProjectAvatarResponseLatestDeploymentBranchMatcherType.EndsWith,
                "equals" => UploadProjectAvatarResponseLatestDeploymentBranchMatcherType.Equals,
                "startsWith" => UploadProjectAvatarResponseLatestDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}