#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedc1460711be3474a5 : global::System.IEquatable<AutoSDKSharedc1460711be3474a5>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared03f29e765d13306d? Shared03f29e765d13306d { get; init; }
#else
        public global::Vercel.AutoSDKShared03f29e765d13306d? Shared03f29e765d13306d { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared03f29e765d13306d))]
#endif
        public bool IsShared03f29e765d13306d => Shared03f29e765d13306d != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared03f29e765d13306d(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared03f29e765d13306d? value)
        {
            value = Shared03f29e765d13306d;
            return IsShared03f29e765d13306d;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared03f29e765d13306d PickShared03f29e765d13306d() => Shared03f29e765d13306d is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared03f29e765d13306d' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedec20b3976551b9eb? Sharedec20b3976551b9eb { get; init; }
#else
        public global::Vercel.AutoSDKSharedec20b3976551b9eb? Sharedec20b3976551b9eb { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedec20b3976551b9eb))]
#endif
        public bool IsSharedec20b3976551b9eb => Sharedec20b3976551b9eb != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedec20b3976551b9eb(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedec20b3976551b9eb? value)
        {
            value = Sharedec20b3976551b9eb;
            return IsSharedec20b3976551b9eb;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedec20b3976551b9eb PickSharedec20b3976551b9eb() => Sharedec20b3976551b9eb is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedec20b3976551b9eb' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc1460711be3474a5(global::Vercel.AutoSDKShared03f29e765d13306d value) => new AutoSDKSharedc1460711be3474a5((global::Vercel.AutoSDKShared03f29e765d13306d?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared03f29e765d13306d?(AutoSDKSharedc1460711be3474a5 @this) => @this.Shared03f29e765d13306d;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc1460711be3474a5(global::Vercel.AutoSDKShared03f29e765d13306d? value)
        {
            Shared03f29e765d13306d = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc1460711be3474a5 FromShared03f29e765d13306d(global::Vercel.AutoSDKShared03f29e765d13306d? value) => new AutoSDKSharedc1460711be3474a5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc1460711be3474a5(global::Vercel.AutoSDKSharedec20b3976551b9eb value) => new AutoSDKSharedc1460711be3474a5((global::Vercel.AutoSDKSharedec20b3976551b9eb?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedec20b3976551b9eb?(AutoSDKSharedc1460711be3474a5 @this) => @this.Sharedec20b3976551b9eb;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc1460711be3474a5(global::Vercel.AutoSDKSharedec20b3976551b9eb? value)
        {
            Sharedec20b3976551b9eb = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc1460711be3474a5 FromSharedec20b3976551b9eb(global::Vercel.AutoSDKSharedec20b3976551b9eb? value) => new AutoSDKSharedc1460711be3474a5(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc1460711be3474a5(
            global::Vercel.AutoSDKShared03f29e765d13306d? shared03f29e765d13306d,
            global::Vercel.AutoSDKSharedec20b3976551b9eb? sharedec20b3976551b9eb
            )
        {
            Shared03f29e765d13306d = shared03f29e765d13306d;
            Sharedec20b3976551b9eb = sharedec20b3976551b9eb;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedec20b3976551b9eb as object ??
            Shared03f29e765d13306d as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared03f29e765d13306d?.ToString() ??
            Sharedec20b3976551b9eb?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared03f29e765d13306d && !IsSharedec20b3976551b9eb || !IsShared03f29e765d13306d && IsSharedec20b3976551b9eb;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared03f29e765d13306d, TResult>? shared03f29e765d13306d = null,
            global::System.Func<global::Vercel.AutoSDKSharedec20b3976551b9eb, TResult>? sharedec20b3976551b9eb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared03f29e765d13306d is { } __value0 && shared03f29e765d13306d != null)
            {
                return shared03f29e765d13306d(__value0);
            }
            else if (Sharedec20b3976551b9eb is { } __value1 && sharedec20b3976551b9eb != null)
            {
                return sharedec20b3976551b9eb(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared03f29e765d13306d>? shared03f29e765d13306d = null,

            global::System.Action<global::Vercel.AutoSDKSharedec20b3976551b9eb>? sharedec20b3976551b9eb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared03f29e765d13306d is { } __value0)
            {
                shared03f29e765d13306d?.Invoke(__value0);
            }
            else if (Sharedec20b3976551b9eb is { } __value1)
            {
                sharedec20b3976551b9eb?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared03f29e765d13306d>? shared03f29e765d13306d = null,
            global::System.Action<global::Vercel.AutoSDKSharedec20b3976551b9eb>? sharedec20b3976551b9eb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared03f29e765d13306d is { } __value0)
            {
                shared03f29e765d13306d?.Invoke(__value0);
            }
            else if (Sharedec20b3976551b9eb is { } __value1)
            {
                sharedec20b3976551b9eb?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared03f29e765d13306d,
                typeof(global::Vercel.AutoSDKShared03f29e765d13306d),
                Sharedec20b3976551b9eb,
                typeof(global::Vercel.AutoSDKSharedec20b3976551b9eb),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKSharedc1460711be3474a5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared03f29e765d13306d?>.Default.Equals(Shared03f29e765d13306d, other.Shared03f29e765d13306d) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedec20b3976551b9eb?>.Default.Equals(Sharedec20b3976551b9eb, other.Sharedec20b3976551b9eb)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedc1460711be3474a5 obj1, AutoSDKSharedc1460711be3474a5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedc1460711be3474a5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedc1460711be3474a5 obj1, AutoSDKSharedc1460711be3474a5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedc1460711be3474a5 o && Equals(o);
        }
    }
}
