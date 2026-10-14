#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedeee32c9fbde3e88c : global::System.IEquatable<AutoSDKSharedeee32c9fbde3e88c>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared97ad06bd8a349d59? Shared97ad06bd8a349d59 { get; init; }
#else
        public global::Vercel.AutoSDKShared97ad06bd8a349d59? Shared97ad06bd8a349d59 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared97ad06bd8a349d59))]
#endif
        public bool IsShared97ad06bd8a349d59 => Shared97ad06bd8a349d59 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared97ad06bd8a349d59(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared97ad06bd8a349d59? value)
        {
            value = Shared97ad06bd8a349d59;
            return IsShared97ad06bd8a349d59;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared97ad06bd8a349d59 PickShared97ad06bd8a349d59() => Shared97ad06bd8a349d59 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared97ad06bd8a349d59' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared171aaf52dacf0e58? Shared171aaf52dacf0e58 { get; init; }
#else
        public global::Vercel.AutoSDKShared171aaf52dacf0e58? Shared171aaf52dacf0e58 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared171aaf52dacf0e58))]
#endif
        public bool IsShared171aaf52dacf0e58 => Shared171aaf52dacf0e58 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared171aaf52dacf0e58(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared171aaf52dacf0e58? value)
        {
            value = Shared171aaf52dacf0e58;
            return IsShared171aaf52dacf0e58;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared171aaf52dacf0e58 PickShared171aaf52dacf0e58() => Shared171aaf52dacf0e58 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared171aaf52dacf0e58' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedeee32c9fbde3e88c(global::Vercel.AutoSDKShared97ad06bd8a349d59 value) => new AutoSDKSharedeee32c9fbde3e88c((global::Vercel.AutoSDKShared97ad06bd8a349d59?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared97ad06bd8a349d59?(AutoSDKSharedeee32c9fbde3e88c @this) => @this.Shared97ad06bd8a349d59;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedeee32c9fbde3e88c(global::Vercel.AutoSDKShared97ad06bd8a349d59? value)
        {
            Shared97ad06bd8a349d59 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedeee32c9fbde3e88c FromShared97ad06bd8a349d59(global::Vercel.AutoSDKShared97ad06bd8a349d59? value) => new AutoSDKSharedeee32c9fbde3e88c(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedeee32c9fbde3e88c(global::Vercel.AutoSDKShared171aaf52dacf0e58 value) => new AutoSDKSharedeee32c9fbde3e88c((global::Vercel.AutoSDKShared171aaf52dacf0e58?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared171aaf52dacf0e58?(AutoSDKSharedeee32c9fbde3e88c @this) => @this.Shared171aaf52dacf0e58;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedeee32c9fbde3e88c(global::Vercel.AutoSDKShared171aaf52dacf0e58? value)
        {
            Shared171aaf52dacf0e58 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedeee32c9fbde3e88c FromShared171aaf52dacf0e58(global::Vercel.AutoSDKShared171aaf52dacf0e58? value) => new AutoSDKSharedeee32c9fbde3e88c(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedeee32c9fbde3e88c(
            global::Vercel.AutoSDKShared97ad06bd8a349d59? shared97ad06bd8a349d59,
            global::Vercel.AutoSDKShared171aaf52dacf0e58? shared171aaf52dacf0e58
            )
        {
            Shared97ad06bd8a349d59 = shared97ad06bd8a349d59;
            Shared171aaf52dacf0e58 = shared171aaf52dacf0e58;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared171aaf52dacf0e58 as object ??
            Shared97ad06bd8a349d59 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared97ad06bd8a349d59?.ToString() ??
            Shared171aaf52dacf0e58?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared97ad06bd8a349d59 && !IsShared171aaf52dacf0e58 || !IsShared97ad06bd8a349d59 && IsShared171aaf52dacf0e58;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared97ad06bd8a349d59, TResult>? shared97ad06bd8a349d59 = null,
            global::System.Func<global::Vercel.AutoSDKShared171aaf52dacf0e58, TResult>? shared171aaf52dacf0e58 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared97ad06bd8a349d59 is { } __value0 && shared97ad06bd8a349d59 != null)
            {
                return shared97ad06bd8a349d59(__value0);
            }
            else if (Shared171aaf52dacf0e58 is { } __value1 && shared171aaf52dacf0e58 != null)
            {
                return shared171aaf52dacf0e58(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared97ad06bd8a349d59>? shared97ad06bd8a349d59 = null,

            global::System.Action<global::Vercel.AutoSDKShared171aaf52dacf0e58>? shared171aaf52dacf0e58 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared97ad06bd8a349d59 is { } __value0)
            {
                shared97ad06bd8a349d59?.Invoke(__value0);
            }
            else if (Shared171aaf52dacf0e58 is { } __value1)
            {
                shared171aaf52dacf0e58?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared97ad06bd8a349d59>? shared97ad06bd8a349d59 = null,
            global::System.Action<global::Vercel.AutoSDKShared171aaf52dacf0e58>? shared171aaf52dacf0e58 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared97ad06bd8a349d59 is { } __value0)
            {
                shared97ad06bd8a349d59?.Invoke(__value0);
            }
            else if (Shared171aaf52dacf0e58 is { } __value1)
            {
                shared171aaf52dacf0e58?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared97ad06bd8a349d59,
                typeof(global::Vercel.AutoSDKShared97ad06bd8a349d59),
                Shared171aaf52dacf0e58,
                typeof(global::Vercel.AutoSDKShared171aaf52dacf0e58),
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
        public bool Equals(AutoSDKSharedeee32c9fbde3e88c other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared97ad06bd8a349d59?>.Default.Equals(Shared97ad06bd8a349d59, other.Shared97ad06bd8a349d59) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared171aaf52dacf0e58?>.Default.Equals(Shared171aaf52dacf0e58, other.Shared171aaf52dacf0e58)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedeee32c9fbde3e88c obj1, AutoSDKSharedeee32c9fbde3e88c obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedeee32c9fbde3e88c>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedeee32c9fbde3e88c obj1, AutoSDKSharedeee32c9fbde3e88c obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedeee32c9fbde3e88c o && Equals(o);
        }
    }
}
