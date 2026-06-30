
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UploadProjectAvatarResponseTargetsBranchMatcherType
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
    public static class UploadProjectAvatarResponseTargetsBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTargetsBranchMatcherType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTargetsBranchMatcherType.EndsWith => "endsWith",
                UploadProjectAvatarResponseTargetsBranchMatcherType.Equals => "equals",
                UploadProjectAvatarResponseTargetsBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTargetsBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UploadProjectAvatarResponseTargetsBranchMatcherType.EndsWith,
                "equals" => UploadProjectAvatarResponseTargetsBranchMatcherType.Equals,
                "startsWith" => UploadProjectAvatarResponseTargetsBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}