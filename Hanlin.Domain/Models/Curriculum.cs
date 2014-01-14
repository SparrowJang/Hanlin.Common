using Hanlin.Common.Enums;

namespace Hanlin.Domain.Models
{
    public class Curriculum : Enumeration<string>
    {
        public static readonly Curriculum �ꤤ�p92�Һ� = new Curriculum("92", "92�~������p�ǤE�~�@�e�ҵ{���n");
        public static readonly Curriculum �ꤤ�p97�Һ� = new Curriculum("100", "97�~������p�ǤE�~�@�e�ҵ{���n"); // The value was mistakenly chosen as '100'.
        public static readonly Curriculum ����99�Һ� = new Curriculum("99", "99���q���Ť��ǽҵ{���n");
        
        public Curriculum()
        {
        }

        public Curriculum(string value, string name)
            : base(value, name)
        {
        }
    }
}
