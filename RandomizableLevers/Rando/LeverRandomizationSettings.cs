﻿namespace RandomizableLevers.Rando
{
    public class LeverRandomizationSettings
    {
        public bool 自定义用总开关;

        public bool 拉杆随机;

        [Newtonsoft.Json.JsonIgnore]
        public bool Any => 自定义用总开关 || 拉杆随机;

        [MenuChanger.Attributes.MenuRange(-1, 99)]
        public int 拉杆随机组别 = -1;
    }
}
