using System;

namespace FluentBuilder
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class RequiredAttribute : Attribute
    {
        public bool IsRequired;

        public RequiredAttribute()
        {
            IsRequired = true;
        }
    }
}
