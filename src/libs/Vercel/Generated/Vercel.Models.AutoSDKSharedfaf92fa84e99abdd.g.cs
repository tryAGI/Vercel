#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedfaf92fa84e99abdd : global::System.IEquatable<AutoSDKSharedfaf92fa84e99abdd>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared947f69fa305d000e? Shared947f69fa305d000e { get; init; }
#else
        public global::Vercel.AutoSDKShared947f69fa305d000e? Shared947f69fa305d000e { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared947f69fa305d000e))]
#endif
        public bool IsShared947f69fa305d000e => Shared947f69fa305d000e != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared947f69fa305d000e(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared947f69fa305d000e? value)
        {
            value = Shared947f69fa305d000e;
            return IsShared947f69fa305d000e;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared947f69fa305d000e PickShared947f69fa305d000e() => Shared947f69fa305d000e is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared947f69fa305d000e' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2? AutoSDKSharedfaf92fa84e99abddVariant2 { get; init; }
#else
        public global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2? AutoSDKSharedfaf92fa84e99abddVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedfaf92fa84e99abddVariant2))]
#endif
        public bool IsAutoSDKSharedfaf92fa84e99abddVariant2 => AutoSDKSharedfaf92fa84e99abddVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedfaf92fa84e99abddVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2? value)
        {
            value = AutoSDKSharedfaf92fa84e99abddVariant2;
            return IsAutoSDKSharedfaf92fa84e99abddVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2 PickAutoSDKSharedfaf92fa84e99abddVariant2() => AutoSDKSharedfaf92fa84e99abddVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedfaf92fa84e99abddVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedfaf92fa84e99abdd(global::Vercel.AutoSDKShared947f69fa305d000e value) => new AutoSDKSharedfaf92fa84e99abdd((global::Vercel.AutoSDKShared947f69fa305d000e?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared947f69fa305d000e?(AutoSDKSharedfaf92fa84e99abdd @this) => @this.Shared947f69fa305d000e;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedfaf92fa84e99abdd(global::Vercel.AutoSDKShared947f69fa305d000e? value)
        {
            Shared947f69fa305d000e = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedfaf92fa84e99abdd FromShared947f69fa305d000e(global::Vercel.AutoSDKShared947f69fa305d000e? value) => new AutoSDKSharedfaf92fa84e99abdd(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedfaf92fa84e99abdd(global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2 value) => new AutoSDKSharedfaf92fa84e99abdd((global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2?(AutoSDKSharedfaf92fa84e99abdd @this) => @this.AutoSDKSharedfaf92fa84e99abddVariant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedfaf92fa84e99abdd(global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2? value)
        {
            AutoSDKSharedfaf92fa84e99abddVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedfaf92fa84e99abdd FromAutoSDKSharedfaf92fa84e99abddVariant2(global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2? value) => new AutoSDKSharedfaf92fa84e99abdd(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedfaf92fa84e99abdd(
            global::Vercel.AutoSDKShared947f69fa305d000e? shared947f69fa305d000e,
            global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2? autoSDKSharedfaf92fa84e99abddVariant2
            )
        {
            Shared947f69fa305d000e = shared947f69fa305d000e;
            AutoSDKSharedfaf92fa84e99abddVariant2 = autoSDKSharedfaf92fa84e99abddVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKSharedfaf92fa84e99abddVariant2 as object ??
            Shared947f69fa305d000e as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared947f69fa305d000e?.ToString() ??
            AutoSDKSharedfaf92fa84e99abddVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared947f69fa305d000e && !IsAutoSDKSharedfaf92fa84e99abddVariant2 || !IsShared947f69fa305d000e && IsAutoSDKSharedfaf92fa84e99abddVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared947f69fa305d000e, TResult>? shared947f69fa305d000e = null,
            global::System.Func<global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2, TResult>? autoSDKSharedfaf92fa84e99abddVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared947f69fa305d000e is { } __value0 && shared947f69fa305d000e != null)
            {
                return shared947f69fa305d000e(__value0);
            }
            else if (AutoSDKSharedfaf92fa84e99abddVariant2 is { } __value1 && autoSDKSharedfaf92fa84e99abddVariant2 != null)
            {
                return autoSDKSharedfaf92fa84e99abddVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared947f69fa305d000e>? shared947f69fa305d000e = null,

            global::System.Action<global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2>? autoSDKSharedfaf92fa84e99abddVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared947f69fa305d000e is { } __value0)
            {
                shared947f69fa305d000e?.Invoke(__value0);
            }
            else if (AutoSDKSharedfaf92fa84e99abddVariant2 is { } __value1)
            {
                autoSDKSharedfaf92fa84e99abddVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared947f69fa305d000e>? shared947f69fa305d000e = null,
            global::System.Action<global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2>? autoSDKSharedfaf92fa84e99abddVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared947f69fa305d000e is { } __value0)
            {
                shared947f69fa305d000e?.Invoke(__value0);
            }
            else if (AutoSDKSharedfaf92fa84e99abddVariant2 is { } __value1)
            {
                autoSDKSharedfaf92fa84e99abddVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared947f69fa305d000e,
                typeof(global::Vercel.AutoSDKShared947f69fa305d000e),
                AutoSDKSharedfaf92fa84e99abddVariant2,
                typeof(global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2),
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
        public bool Equals(AutoSDKSharedfaf92fa84e99abdd other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared947f69fa305d000e?>.Default.Equals(Shared947f69fa305d000e, other.Shared947f69fa305d000e) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2?>.Default.Equals(AutoSDKSharedfaf92fa84e99abddVariant2, other.AutoSDKSharedfaf92fa84e99abddVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedfaf92fa84e99abdd obj1, AutoSDKSharedfaf92fa84e99abdd obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedfaf92fa84e99abdd>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedfaf92fa84e99abdd obj1, AutoSDKSharedfaf92fa84e99abdd obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedfaf92fa84e99abdd o && Equals(o);
        }
    }
}
