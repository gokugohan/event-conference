using EventConference.Contracts;
using EventConference.Entities;
using EventConference.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventConference.Repository
{
    public class SettingRepository : RepositoryBase<Setting>, ISettingRepository
    {
        public SettingRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Setting> GetAllSettings()
        {
            return this.FindAll().OrderBy(x => x.Key);
        }

        public IDictionary<string, string> GetAllSettingsAsDictionary()
        {
            return this.FindAll().ToDictionary(x => x.Key, x => x.Value);
        }

        public async Task<IDictionary<string, string>> GetAllSettingsAsDictionaryAsync()
        {
            return await this.FindAll().ToDictionaryAsync(x => x.Key, x => x.Value);
        }

        public async Task<IEnumerable<Setting>> GetAllSettingsAsync()
        {
            return await this.FindAll().OrderBy(x => x.Key).ToListAsync();
        }

        public IEnumerable<SettingGroupModel> GetSettingGroups()
        {
            var group = this.RepositoryContext.Settings.Select(s => new Setting
            {
                Id = s.Id,
                Name = s.Name,
                Key = s.Key,
                Value = s.Value,
                Type = s.Type,
                Group = s.Group
            }).ToList().GroupBy(t => t.Group).OrderBy(o => o.Key).Select(s => new SettingGroupModel
            {
                Group = s.Key,
                Settings = s.OrderBy(d => d.Key).ToList()
            }).ToList();

            return group;
        }

    }
}
