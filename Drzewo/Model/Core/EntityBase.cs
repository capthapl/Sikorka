using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo.Model.Core
{
    [Serializable]
    public sealed class EntityBase<T>
    {
        public string DocumentName { get; set; }
        public T Data { get; set; }
    }
}
