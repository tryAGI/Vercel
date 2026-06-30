
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaConfiguredBy
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
    public static class UpdateMicrofrontendsResponseAliaConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaConfiguredBy value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaConfiguredBy.A => "A",
                UpdateMicrofrontendsResponseAliaConfiguredBy.Cname => "CNAME",
                UpdateMicrofrontendsResponseAliaConfiguredBy.Dns01 => "dns-01",
                UpdateMicrofrontendsResponseAliaConfiguredBy.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "A" => UpdateMicrofrontendsResponseAliaConfiguredBy.A,
                "CNAME" => UpdateMicrofrontendsResponseAliaConfiguredBy.Cname,
                "dns-01" => UpdateMicrofrontendsResponseAliaConfiguredBy.Dns01,
                "http" => UpdateMicrofrontendsResponseAliaConfiguredBy.Http,
                _ => null,
            };
        }
    }
}