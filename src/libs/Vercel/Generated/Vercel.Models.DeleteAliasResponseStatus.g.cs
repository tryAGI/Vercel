
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteAliasResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAliasResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAliasResponseStatus value)
        {
            return value switch
            {
                DeleteAliasResponseStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAliasResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => DeleteAliasResponseStatus.Success,
                _ => null,
            };
        }
    }
}