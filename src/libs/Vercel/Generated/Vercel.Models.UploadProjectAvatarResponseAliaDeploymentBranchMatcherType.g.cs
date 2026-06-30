
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentBranchMatcherType
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
    public static class UploadProjectAvatarResponseAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                UploadProjectAvatarResponseAliaDeploymentBranchMatcherType.Equals => "equals",
                UploadProjectAvatarResponseAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UploadProjectAvatarResponseAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => UploadProjectAvatarResponseAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => UploadProjectAvatarResponseAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}