using Hanlin.Common.Enums;

namespace Hanlin.Domain.Models
{
    public class Curriculum : Enumeration<string>
    {
        public static readonly Curriculum �ꤤ�p92�Һ� = new Curriculum("92", "92�~������p�ǤE�~�@�e�ҵ{���n");
        public static readonly Curriculum �ꤤ�p97�Һ� = new Curriculum("100", "97�~������p�ǤE�~�@�e�ҵ{���n"); // The value was mistakenly chosen as '100'.
        public static readonly Curriculum ����99�Һ� = new Curriculum("99", "99���q���Ť��ǽҵ{���n");
        
        /// <summary>
        /// �b7��31�餽�G��A�N��103�Ǧ~�פJ�Ǫ��s�Ͱ_�v�~��I�C
        /// http://www.edu.tw/pages/detail.aspx?Node=1088&Page=20786&Index=3&wid=DDC91D2B-ACE4-4E00-9531-FC7F63364719
        /// 
        /// </summary>
        public static readonly Curriculum ����103�Һ� = new Curriculum("103", "103���q���Ť��ǽҵ{���n");

        public Curriculum()
        {
        }

        public Curriculum(string value, string name)
            : base(value, name)
        {
        }
    }
}
