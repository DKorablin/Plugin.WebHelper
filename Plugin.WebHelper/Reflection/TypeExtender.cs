using System;
using System.Collections.Generic;
using System.Reflection;

namespace Plugin.WebHelper.Reflection
{
	public static class TypeExtender
	{
		public static T[] GetCustomAttributes<T>(this MemberInfo info, Boolean inherit) where T : Attribute
		{
			List<T> result = new List<T>();
			Type typeOfResult = typeof(T);

			if(info.Module.Assembly.ReflectionOnly)
			{
				foreach(CustomAttributeData attribute in CustomAttributeData.GetCustomAttributes(info))
				{
					if(attribute.Constructor.DeclaringType.FullName == typeOfResult.FullName)
					{
						ConstructorInfo ctor = typeOfResult.GetConstructor(new Type[] { });
						T item = (T)ctor.Invoke(null);
						foreach(var argument in attribute.NamedArguments)
						{
							PropertyInfo property = typeOfResult.GetProperty(argument.MemberInfo.Name);

							if(property != null)
								property.SetValue(item, argument.TypedValue.Value, null);
							else
							{
								FieldInfo field = typeOfResult.GetField(argument.MemberInfo.Name);
								field?.SetValue(item, argument.TypedValue.Value);
							}
						}
						result.Add(item);
					}
				}
			} else
			{
				Object[] attributes = info.GetCustomAttributes(typeOfResult, inherit);
				foreach(Object item in attributes)
					result.Add((T)item);
			}
			return result.ToArray();
		}
		public static Boolean ContainsCustomAttribute(this MemberInfo info, Type attributeType, Boolean inherit)
		{
			if(info.Module.Assembly.ReflectionOnly)
			{
				foreach(CustomAttributeData attribute in CustomAttributeData.GetCustomAttributes(info))
					if(attribute.Constructor.DeclaringType.FullName == attributeType.FullName)
						return true;
				return false;
			} else
				return info.GetCustomAttributes(attributeType, inherit).Length > 0;
		}
	}
}