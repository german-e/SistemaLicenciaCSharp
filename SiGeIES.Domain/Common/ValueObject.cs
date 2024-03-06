using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGeIES.Domain.Common
{
    public abstract class ValueObject<T> : IEquatable<T>
    {

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != GetType())
                return false;

            return GetEqualityComponents().SequenceEqual(((ValueObject<T>)obj).GetEqualityComponents());
        }

        // Override GetHashCode based on attributes
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) => current * 23 + (obj?.GetHashCode() ?? 0));
        }

        // Implement IEquatable<T> for efficient equality checks
        public bool Equals(T other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            
            return GetEqualityComponents().SequenceEqual((other as ValueObject<T>).GetEqualityComponents());
        }

        // Implement == and != operators
        public static bool operator ==(ValueObject<T> left, ValueObject<T> right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(ValueObject<T> left, ValueObject<T> right)
        {
            return !(left == right);
        }

        // Define the attributes that make up the value object
        protected abstract IEnumerable<object> GetEqualityComponents();




    }
}
