using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarSavingTool.Builders;
using StarSavingTool.Builders.Interfaces;

namespace StarSavingTool.Console
{
    public class GameSaveFile : BaseSaveBuilder
    {
        protected override void CreateComponents(IComponenSetting setting)
        {
            setting.RegisterComponent<HeaderComponent>();
            setting.RegisterComponent<InformationsComponent>();

            setting.RegisterComponent<AchiviementsComponent>();
            setting.RegisterComponent<LogsComponent>();
            setting.RegisterComponent<ModsComponent>();
            setting.RegisterComponent<ScoreComponent>();
            setting.RegisterComponent<StatusComponent>();
        }
    }
}
