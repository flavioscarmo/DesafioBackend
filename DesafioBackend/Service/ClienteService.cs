using DesafioBackend.Model;

namespace DesafioBackend.Service
{
    public interface ClienteService
    { 
        Task<ClienteModel> GetAsync(string id);

        Task<IEnumerable<ClienteModel>> GetAllAsync();

        Task<ClienteModel> PostAsync(ClienteModel model);

        Task<ClienteModel> PutAsync(ClienteModel model);

        Task<bool> DeleteAsync(string id);
    }
}
