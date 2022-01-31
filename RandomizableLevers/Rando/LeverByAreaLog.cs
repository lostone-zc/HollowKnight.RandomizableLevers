using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RandomizerMod.Logging;
using RandomizerMod.RC;
using RandomizerCore;
using RandomizerCore.Logic;
using ItemChanger;
using CondensedSpoilerLogger;

namespace RandomizableLevers.Rando
{
    public class LeverByAreaLog : RandoLogger
    {
        public override void Log(LogArguments args)
        {
            if (!RandoInterop.Settings.拉干随机) return;

            StringBuilder sb = new();
            SpoilerReader sr = new(args);
            sr.Indent = 2;

            sb.AppendLine($"Lever spoiler for 种子: {args.gs.Seed}");
            sb.AppendLine();

            sb.AppendLine("德特茅斯:");
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Dirtmouth_Stag);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Dirtmouth_Elevator);
            sb.AppendLine();

            sb.AppendLine("十字路:");
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Outside_Ancestral_Mound);
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Crossroads_East);
            sb.AppendLine();

            sb.AppendLine("苍绿之径:");
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Greenpath_Stag);
            sb.AppendLine();

            sb.AppendLine("雾之峡谷:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Below_Overgrown_Mound);
            sb.AppendLine();

            sb.AppendLine("王后花园:");
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Petra_Arena);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Queens_Gardens_Ground_Block);
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Queens_Gardens_Stag);
            sb.AppendLine();

            sb.AppendLine("真菌荒地:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Queens_Station_Mask_Shard);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Fungal_Wastes_Below_Shrumal_Ogres);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Fungal_Wastes_Thorns_Gauntlet);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Fungal_Wastes_Bouncy_Grub);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Pilgrims_Way_Left);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Pilgrims_Way_Right);
            sb.AppendLine();

            sb.AppendLine("螳螂村:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Claw);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Lords_Access);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Lords_Top_Left);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Lords_Middle_Left);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Lords_Bottom_Left);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Lords_Middle_Right);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Mantis_Lords_Bottom_Right);
            sb.AppendLine();

            sb.AppendLine("泪水之城:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Above_Lemm_Left);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Above_Lemm_Right);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Above_Lemm_Upper);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Lemm);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Fountain);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Shade_Soul_Exit);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Storerooms);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Spire_Sentry_Lower);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Spire_Sentry_Upper);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_City_Bridge_Above_Fountain);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Emilitia);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Tower_of_Love);
            sb.AppendLine();

            sb.AppendLine("灵魂圣所:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Sanctum_Soul_Warrior);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Sanctum_Bottom);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Below_Spell_Twister);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Sanctum_East);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Sanctum_West_Upper);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Sanctum_West_Lower);
            sb.AppendLine();

            sb.AppendLine("皇家水道:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Dung_Defender);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Waterways_Hwurmp_Arena);
            sb.AppendLine();

            sb.AppendLine("水晶山峰:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Spike_Grub);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Tall_Room_Upper);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Tall_Room_Middle);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Tall_Room_Lower);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Above_Chest);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Below_Chest);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Crushers_Grub);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Crystal_Peak_Crushers_Chest);
            sb.AppendLine();

            sb.AppendLine("安息之地:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Resting_Grounds_Stag);
            sr.AddItemToStringBuilder(sb, LeverNames.Switch_Lower_Resting_Grounds);
            sb.AppendLine();

            sb.AppendLine("深渊:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Abyss_Lighthouse);
            sb.AppendLine();

            sb.AppendLine("废弃电车轨道:");
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Failed_Tramway_Right);
            sr.AddItemToStringBuilder(sb, LeverNames.Lever_Failed_Tramway_Left);
            sb.AppendLine();

            if (args.gs.LongLocationSettings.WhitePalaceRando != RandomizerMod.Settings.LongLocationSettings.WPSetting.ExcludeWhitePalace)
            {
                sb.AppendLine("白色宫殿:");
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Palace_Entrance_Orb);
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Palace_Left_Orb);
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Palace_Right_Orb);
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Palace_Atrium);
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Palace_Right);
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Palace_Final);
                sr.AddItemToStringBuilder(sb, LeverNames.Lever_Path_of_Pain);
                sb.AppendLine();
            }

            LogManager.Write(sb.ToString(), "各区域内拉干剧透日志.txt");
        }
    }
}
