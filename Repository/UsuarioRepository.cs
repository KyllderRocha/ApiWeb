using ApiWeb.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Repository
{
    public class UsuarioRepository
    {
        MongoClient client;
        IMongoDatabase database;
        IMongoCollection<Usuario> collection;
        public UsuarioRepository()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://PPOUser:EduardaFellipe@cluster0.byu72.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            client = new MongoClient(settings);
            database = client.GetDatabase("test");
            collection = database.GetCollection<Usuario>("User");

        }
        public Usuario Login(string Email, string Senha)
        {
            var filter = Builders<Usuario>.Filter.Eq("Email", Email)
                & Builders<Usuario>.Filter.Eq("Senha", Senha);

            return collection.Find(filter).FirstOrDefault();
        }

        public Usuario GetUser(string ID)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, ID);

            return collection.Find(filter).FirstOrDefault();
        }

        public List<Anotacao> GetAnotacao(string ID)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, ID);

            return collection.Find(filter).FirstOrDefault().anotacoes;
        }

        public List<Evento> GetEventos(string ID)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, ID);

            return collection.Find(filter).FirstOrDefault().eventos;
        }

        public void PostUser(Usuario usuario)
        { 
            collection.InsertOne(usuario);
        }

        public void PutUser(Usuario usuario)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, usuario.ID);
            var update = Builders<Usuario>.Update.Set("Nome", usuario.Nome)
                .Set("Senha", usuario.Senha)
                .Set("Email", usuario.Email)
                .Set("Altura", usuario.Altura);

            collection.UpdateOne(filter, update);
        }
        public void PutAnotacao(Usuario usuario)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, usuario.ID);
            var update = Builders<Usuario>.Update.Set("anotacoes", usuario.anotacoes);

            collection.UpdateOne(filter, update);
        }

        public void PutEventos(Usuario usuario)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, usuario.ID);
            var update = Builders<Usuario>.Update.Set("eventos", usuario.eventos);

            collection.UpdateOne(filter, update);
        }

        public void Delete(Usuario usuario)
        {
            var filter = Builders<Usuario>.Filter.Eq(x => x.ID, usuario.ID);
            collection.DeleteOne(filter);
        }

    }
}
