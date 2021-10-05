using ServicesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesInterfaces.Facades
{
    public interface IActionsFacade
    {
        Task<IDictionary<string, string>> GetImages(Data data);
        Task<IDictionary<string, string>> RemoveImage(Data data);
        Task<List<string>> ScheduleTask(List<Data> data, string id);
        Task<Data> UpdateAboutMe(Data data);
        Task<IDictionary<string, string>> UploadImage(Data data);
    }
}
