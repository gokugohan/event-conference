using EventConference.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Contracts
{
    public interface ISettingRepository:IRepositoryBase<Setting>
    {
        IDictionary<string, string> GetAllSettingsAsDictionary();
        Task<IDictionary<string, string>> GetAllSettingsAsDictionaryAsync();
        IEnumerable<Setting> GetAllSettings();
        Task<IEnumerable<Setting>> GetAllSettingsAsync();

        IEnumerable<SettingGroupModel> GetSettingGroups();

    }
}
