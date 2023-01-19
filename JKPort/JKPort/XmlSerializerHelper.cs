using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public static class XmlSerializerHelper
{
    /// <summary>
    /// serialize structs
    /// </summary>
    /// <param name="path">include folder and filename</param>
    /// <param name="p_object">struct</param>
    public static void Serialize(String path, object p_object)
    {
        using (var stream = File.Create(path))
        {
            var s = new XmlSerializer(p_object.GetType());
            s.Serialize(stream, p_object);
        }
    }

    // todo: make this working
    public static bool Validate<T>(String path)
    {
        var stream = File.OpenRead(path);
        try
        {
            var s = new XmlSerializer(typeof(T));
            var g = (T)s.Deserialize(stream);
            return true;
        }
        catch (Exception e)
        {
            System.Windows.Forms.MessageBox.Show(e.InnerException + e.StackTrace + e.Source, e.Message);
            return false;
        }
        finally { stream.Dispose(); }
    }

    public static void SerializeWithPath(String path, object p_object)
    {
        string dir = path.Substring(0, path.LastIndexOf("/"));
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);
        Serialize(path, p_object);
    }

    public static T Deserialize<T>(String path)//an XML class needs a parameterless constructor
    {
        using (var stream = File.OpenRead(path))
        {
            var s = new XmlSerializer(typeof(T));
            return (T)s.Deserialize(stream);
        }
    }
}