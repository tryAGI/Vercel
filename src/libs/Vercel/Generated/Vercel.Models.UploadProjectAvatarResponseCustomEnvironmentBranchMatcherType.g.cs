
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType
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
    public static class UploadProjectAvatarResponseCustomEnvironmentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType.EndsWith => "endsWith",
                UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType.Equals => "equals",
                UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType.EndsWith,
                "equals" => UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType.Equals,
                "startsWith" => UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}