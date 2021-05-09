using Api.Data.Collections;

namespace Api.Controllers
{
    internal interface IMongoCollection<T>
    {
        void InsertOne(Infectado infectado);
    }
}