﻿using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

public static class JSONSerializer
{
    /// <summary>
    ///     Serializes an object to JSON
    /// </summary>
    public static string Serialize<TType>(TType instance)
        where TType : class
    {
        var serializer = new DataContractJsonSerializer(typeof(TType));
        using (var stream = new MemoryStream())
        {
            serializer.WriteObject(stream, instance);
            return Encoding.Default.GetString(stream.ToArray());
        }
    }

    /// <summary>
    ///     DeSerializes an object from JSON
    /// </summary>
    public static TType DeSerialize<TType>(string json)
        where TType : class
    {
        using (var stream = new MemoryStream(Encoding.Default.GetBytes(json)))
        {
            var serializer = new DataContractJsonSerializer(typeof(TType));
            return serializer.ReadObject(stream) as TType;
        }
    }
}