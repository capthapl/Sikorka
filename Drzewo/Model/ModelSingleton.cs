using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo.Model
{
    public class ModelSingleton
    {
        [BsonId]
        [BsonElement(elementName: "Document")]
        public string Document { get; set; }
        [BsonElement(elementName: "Data")]
        public string Data { get; set; }
    }
}
