using System;

namespace FluentBuilder
{
    public class FluentBuilder<TTarget> : IBuilder<TTarget>
        where TTarget : class
    {
        private Type _targetType;

        public FluentBuilder()
        {
            _targetType = typeof(TTarget);

            var allFields = _targetType.GetFields();
        }

        public TTarget Create(params object[] parameters)
        {
            return (TTarget)Activator.CreateInstance(_targetType, parameters);
        }
    }
}
