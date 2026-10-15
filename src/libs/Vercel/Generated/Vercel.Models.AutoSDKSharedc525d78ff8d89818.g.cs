#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedc525d78ff8d89818 : global::System.IEquatable<AutoSDKSharedc525d78ff8d89818>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared037328971b8d11db? Shared037328971b8d11db { get; init; }
#else
        public global::Vercel.AutoSDKShared037328971b8d11db? Shared037328971b8d11db { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared037328971b8d11db))]
#endif
        public bool IsShared037328971b8d11db => Shared037328971b8d11db != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared037328971b8d11db(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared037328971b8d11db? value)
        {
            value = Shared037328971b8d11db;
            return IsShared037328971b8d11db;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared037328971b8d11db PickShared037328971b8d11db() => Shared037328971b8d11db is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared037328971b8d11db' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared7edb780247ab9fb3? Shared7edb780247ab9fb3 { get; init; }
#else
        public global::Vercel.AutoSDKShared7edb780247ab9fb3? Shared7edb780247ab9fb3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared7edb780247ab9fb3))]
#endif
        public bool IsShared7edb780247ab9fb3 => Shared7edb780247ab9fb3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared7edb780247ab9fb3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared7edb780247ab9fb3? value)
        {
            value = Shared7edb780247ab9fb3;
            return IsShared7edb780247ab9fb3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared7edb780247ab9fb3 PickShared7edb780247ab9fb3() => Shared7edb780247ab9fb3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared7edb780247ab9fb3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc525d78ff8d89818(global::Vercel.AutoSDKShared037328971b8d11db value) => new AutoSDKSharedc525d78ff8d89818((global::Vercel.AutoSDKShared037328971b8d11db?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared037328971b8d11db?(AutoSDKSharedc525d78ff8d89818 @this) => @this.Shared037328971b8d11db;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc525d78ff8d89818(global::Vercel.AutoSDKShared037328971b8d11db? value)
        {
            Shared037328971b8d11db = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc525d78ff8d89818 FromShared037328971b8d11db(global::Vercel.AutoSDKShared037328971b8d11db? value) => new AutoSDKSharedc525d78ff8d89818(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedc525d78ff8d89818(global::Vercel.AutoSDKShared7edb780247ab9fb3 value) => new AutoSDKSharedc525d78ff8d89818((global::Vercel.AutoSDKShared7edb780247ab9fb3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared7edb780247ab9fb3?(AutoSDKSharedc525d78ff8d89818 @this) => @this.Shared7edb780247ab9fb3;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc525d78ff8d89818(global::Vercel.AutoSDKShared7edb780247ab9fb3? value)
        {
            Shared7edb780247ab9fb3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedc525d78ff8d89818 FromShared7edb780247ab9fb3(global::Vercel.AutoSDKShared7edb780247ab9fb3? value) => new AutoSDKSharedc525d78ff8d89818(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedc525d78ff8d89818(
            global::Vercel.AutoSDKShared037328971b8d11db? shared037328971b8d11db,
            global::Vercel.AutoSDKShared7edb780247ab9fb3? shared7edb780247ab9fb3
            )
        {
            Shared037328971b8d11db = shared037328971b8d11db;
            Shared7edb780247ab9fb3 = shared7edb780247ab9fb3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared7edb780247ab9fb3 as object ??
            Shared037328971b8d11db as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared037328971b8d11db?.ToString() ??
            Shared7edb780247ab9fb3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared037328971b8d11db && !IsShared7edb780247ab9fb3 || !IsShared037328971b8d11db && IsShared7edb780247ab9fb3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared037328971b8d11db, TResult>? shared037328971b8d11db = null,
            global::System.Func<global::Vercel.AutoSDKShared7edb780247ab9fb3, TResult>? shared7edb780247ab9fb3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared037328971b8d11db is { } __value0 && shared037328971b8d11db != null)
            {
                return shared037328971b8d11db(__value0);
            }
            else if (Shared7edb780247ab9fb3 is { } __value1 && shared7edb780247ab9fb3 != null)
            {
                return shared7edb780247ab9fb3(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared037328971b8d11db>? shared037328971b8d11db = null,

            global::System.Action<global::Vercel.AutoSDKShared7edb780247ab9fb3>? shared7edb780247ab9fb3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared037328971b8d11db is { } __value0)
            {
                shared037328971b8d11db?.Invoke(__value0);
            }
            else if (Shared7edb780247ab9fb3 is { } __value1)
            {
                shared7edb780247ab9fb3?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared037328971b8d11db>? shared037328971b8d11db = null,
            global::System.Action<global::Vercel.AutoSDKShared7edb780247ab9fb3>? shared7edb780247ab9fb3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared037328971b8d11db is { } __value0)
            {
                shared037328971b8d11db?.Invoke(__value0);
            }
            else if (Shared7edb780247ab9fb3 is { } __value1)
            {
                shared7edb780247ab9fb3?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared037328971b8d11db,
                typeof(global::Vercel.AutoSDKShared037328971b8d11db),
                Shared7edb780247ab9fb3,
                typeof(global::Vercel.AutoSDKShared7edb780247ab9fb3),
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
        public bool Equals(AutoSDKSharedc525d78ff8d89818 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared037328971b8d11db?>.Default.Equals(Shared037328971b8d11db, other.Shared037328971b8d11db) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared7edb780247ab9fb3?>.Default.Equals(Shared7edb780247ab9fb3, other.Shared7edb780247ab9fb3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedc525d78ff8d89818 obj1, AutoSDKSharedc525d78ff8d89818 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedc525d78ff8d89818>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedc525d78ff8d89818 obj1, AutoSDKSharedc525d78ff8d89818 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedc525d78ff8d89818 o && Equals(o);
        }
    }
}
