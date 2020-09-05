using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DemoShapeData.Helper
{
    public static class IEnumerableExtensions
    {


        public static IEnumerable<ExpandoObject> ShapeData<TSource>(
            this IEnumerable<TSource> source,  string fields)
        {

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            //Create list to HOLD our ExpandoObjects
            var expandoObjectList = new List<ExpandoObject>();

            //Create list with PropertyInfo objects on TSource (REFLECTION)
            var propertyInfoList = new List<PropertyInfo>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                //all properties should be in the ExpandoObject
                var propertyInfos = typeof(TSource)
                                    .GetProperties(BindingFlags.Public |
                                    BindingFlags.Instance);

                propertyInfoList.AddRange(propertyInfos);
            } 
            else
            {
                //all the fields are separated by ","
                var fieldsAfterSplit = fields.Split(',');

                foreach (var field in fieldsAfterSplit)
                {

                    //trim each field
                    var propertyName = field.Trim();

                    //Use Reflection to get properties by name Fields
                    var propertyInfo = typeof(TSource)
                                       .GetProperty(propertyName, BindingFlags.IgnoreCase
                                       | BindingFlags.Public | BindingFlags.Instance);

                    if (propertyInfo == null)
                    {
                        throw new Exception($"Property {propertyName} wasn't found on" +
                            $" {typeof(TSource)}");
                    }

                    propertyInfoList.Add(propertyInfo);
                }

            }


            //run through the source objects
            foreach (TSource sourceObject in source)
            {

                //create an ExpandoObject that will hold the 
                //selected properties & values
                var dataShapedObject = new ExpandoObject();

                //Get the value of each property we have to return

                foreach (var propertyInfo in propertyInfoList)
                {
                    //GetValue returns the value of the property on the source object
                    var propertyValue = propertyInfo.GetValue(sourceObject);

                    //add the field to the ExpandoObject
                    ((IDictionary<string, object>)dataShapedObject)
                        .Add(propertyInfo.Name, propertyValue);
                }

                //add the ExpandoObject to the list
                expandoObjectList.Add(dataShapedObject);

            }

            //Return the list
            return expandoObjectList;

        }

    }
}
