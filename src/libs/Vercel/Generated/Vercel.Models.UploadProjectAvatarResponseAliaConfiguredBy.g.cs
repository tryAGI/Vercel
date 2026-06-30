
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseAliaConfiguredBy
    {
        /// <summary>
        /// 
        /// </summary>
        A,
        /// <summary>
        /// 
        /// </summary>
        Cname,
        /// <summary>
        /// 
        /// </summary>
        Dns01,
        /// <summary>
        /// 
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaConfiguredBy value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaConfiguredBy.A => "A",
                UploadProjectAvatarResponseAliaConfiguredBy.Cname => "CNAME",
                UploadProjectAvatarResponseAliaConfiguredBy.Dns01 => "dns-01",
                UploadProjectAvatarResponseAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => UploadProjectAvatarResponseAliaConfiguredBy.A,
                "CNAME" => UploadProjectAvatarResponseAliaConfiguredBy.Cname,
                "dns-01" => UploadProjectAvatarResponseAliaConfiguredBy.Dns01,
                "http" => UploadProjectAvatarResponseAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}