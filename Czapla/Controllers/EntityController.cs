using Drzewo.Model;
using Drzewo.Model.Core;
using Newtonsoft.Json;

namespace Czapla.Controllers
{
    public static class EntityController
    {
        public static EntityBase<T> SerializeJsonAndWrapToEntity<T> (string data, string documentName)
        {
            var serialized = DeserializeJson<T>(data);
            return WrapDataToEntityBase<T>(serialized, documentName);
        }

        public static EntityBase<T> WrapDataToEntityBase<T>(T data, string documentName)
        {
            return new EntityBase<T>()
            {
                DocumentName = documentName,
                Data = data
            };
        }

        private static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
