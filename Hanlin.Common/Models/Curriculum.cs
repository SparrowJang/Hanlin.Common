﻿using Hanlin.Common.Enums;

namespace Hanlin.Common.Models
{
    public class Curriculum : Enumeration<string>
    {
        public static readonly Curriculum 國中小92課綱 = new Curriculum("92", "92年國民中小學九年一貫課程綱要");
        public static readonly Curriculum 國中小97課綱 = new Curriculum("100", "97年國民中小學九年一貫課程綱要"); // The value was mistakenly chosen as '100'.
        public static readonly Curriculum 高中99課綱 = new Curriculum("99", "99普通高級中學課程綱要");
        
        public Curriculum()
        {
        }

        public Curriculum(string value, string name)
            : base(value, name)
        {
        }
    }
}
