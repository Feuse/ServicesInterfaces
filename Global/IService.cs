using ServicesInterfaces.Global;
using ServicesModels;
using ServicesModels.BadooAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces
{
    public interface IService
    {
        public Task<Data> AppStartUp(Data data);
        public Task<List<string>> GetEncounters(Data data);
        public Task<MessageState> Like(Data data);
        public Task<string> UpdateAboutMe(Data data);
        public Task<IDictionary<string, string>> GetImages(Data data);
        public Task<IDictionary<string, string>> RemoveImage(Data data);
        public Task<string> UploadImage(Data data);

    }
}
