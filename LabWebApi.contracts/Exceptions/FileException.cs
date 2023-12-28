﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Exceptions
{
    [Serializable]
    public class FileException : Exception
    {
        public string Path { get; }
        public FileException() { }
        public FileException(string message)
        : base(message) { }
        public FileException(string message, Exception inner)
        : base(message, inner) { }
        public FileException(string message, string path)
        : base(message)
        {
            Path = path;
        }
        protected FileException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {
            this.Path = info.GetString("Path");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }
            info.AddValue("Path", Path);
            base.GetObjectData(info, context);
        }
    }
}
