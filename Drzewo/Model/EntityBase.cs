using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo.Model
{
    [Serializable]
    public abstract class EntityBase
    {
        [BsonId]
        public ObjectId Id { get; set; }

    }
}
