using System;
using System.IO;

namespace Fractalize
{
    class FileProcessing
    {
        public string ReadTextFile(string path)
        {
            string content = "";
            StreamReader sr = null;

            try
            {
                if (File.Exists(path))
                {
                    sr = File.OpenText(path);
                    content = sr.ReadToEnd();
                }
                else
                {
                    throw new Exception("File " + path + " does not exist or Access is denied.");
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            return content;

        }

        public void WriteTextFile(string path, string content)
        {
            StreamWriter w = null;
            try
            {
                w = File.CreateText(path);
                w.Write(content);
                w.Flush();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                w.Close();

            }
        }

        public void AppendTextFile(string path, string content)
        {
            StreamWriter w = null;
            try
            {
                if (!File.Exists(path))
                {
                    w = File.CreateText(path);
                }
                else
                {
                    w = File.AppendText(path);
                }
                w.Write(content);
                w.Flush();
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                w.Close();

            }

        }

        public bool IsFileReadOnly(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            FileAttributes attributes = File.GetAttributes(filePath);
            FileAttributes attr = attributes | FileAttributes.ReadOnly;
            if (attr == attributes)
            {
                return true;
            }
            return false;
        }

        public void MakeFileWritable(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            FileAttributes attributes = File.GetAttributes(filePath);
            FileAttributes attr = attributes | FileAttributes.ReadOnly;
            if (attr == attributes)
            {
                attributes ^= FileAttributes.ReadOnly;
                File.SetAttributes(filePath, attributes);
            }
        } 
    }
}
